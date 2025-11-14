using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.FileIO;

namespace habitLogger
{
    class Program
    {
        static string connectionString = @"Data Source=habit-Logger.db";

        static void Main(string[] args)
        {


            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();

                tableCmd.CommandText =
                @"CREATE TABLE IF NOT EXISTS drinking_water (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Date TEXT,
                    Quantity INTEGER
                    )";

                tableCmd.ExecuteNonQuery();

                connection.Close();
            }

            GetUserInput();
        }

        static void GetUserInput()
        {
            Console.Clear();
            bool closeApp = false;
            while (closeApp == false)
            {
                Console.WriteLine(
                """


                Main Menu

                What would you like to do?

                Type 0 to Close Application
                Type 1 to View Records
                Type 2 to Insert
                Type 3 to Delete
                Type 4 to Update
                ----------------------------------------------

                """
                );


                string? command = Console.ReadLine();


                switch (command)
                {
                    case "0":
                        Console.WriteLine("\nGoodbye");
                        closeApp = true;
                        break;
                    case "1":
                        GetAllRecords();
                        break;
                    case "2":
                        Insert();
                        break;
                    case "3":
                        Delete();
                        break;
                    case "4":
                        Update();
                        break;
                    default:
                        Console.WriteLine("\nInvalid Command. Please enter a number from 0 to 4.\n");
                        break;

                }

            }
        }

        private static void Update()
        {
            Console.Clear();
            GetAllRecords();

            int recordId = GetNumberInput("\n\nEnter the id of the record you want to update or type 0 to exit to menu.");

            

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var checkCmd = connection.CreateCommand();
                checkCmd.CommandText =
                    $"SELECT EXISTS(SELECT 1 FROM drinking_water WHERE Id = {recordId})";

                int checkQuery = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (checkQuery == 0)
                {
                    Console.WriteLine($"\n\nRecord id {recordId} doesnt exist");
                    connection.Close();
                    Update();
                }

                connection.Close();

                Console.WriteLine("\n\nEnter what you want to update for this record.\n");

                string? column = Console.ReadLine();

                

                switch (column)
                {       
                    case "date":
                        string date = GetDateInput("\n\nEnter new date:\n");
                        connection.Open();
                        var dateCmd = connection.CreateCommand();
                        dateCmd.CommandText = $"UPDATE drinking_water SET date = '{date}' WHERE Id = {recordId}";
                        dateCmd.ExecuteNonQuery();
                        connection.Close();
                        Update();
                        break;
                    case "quantity":
                        int quantity = GetNumberInput("\n\nEnter your new quantity:\n");
                        connection.Open();
                        var quantityCmd = connection.CreateCommand();
                        quantityCmd.CommandText = $"UPDATE drinking_water SET quantity = '{quantity}' WHERE Id = {recordId}";
                        quantityCmd.ExecuteNonQuery();
                        connection.Close();
                        Update();
                    break;
                    case "both":
                        string dateBoth = GetDateInput("\n\nEnter new date:\n");
                        int quantityBoth = GetNumberInput("\n\nEnter your new quantity:\n");
                        connection.Open();
                        var tableCmd = connection.CreateCommand();
                        tableCmd.CommandText = $"UPDATE drinking_water SET date = '{dateBoth}', quantity = '{quantityBoth}' WHERE Id = {recordId}";
                        tableCmd.ExecuteNonQuery();
                        connection.Close();
                        Update();
                        break;
                    case "0":
                        Update();
                        break;
                    default:
                        Console.WriteLine("\n\nPlease enter date, quantity or both. If you want to select another id enter 0.");
                        break;
                }
            }
        }


        private static void Insert()
        {
            Console.Clear();

            string date = GetDateInput("\n\nPlease enter the date: (Format: dd-mm-yy) or Type 0 to return to main menu.");

            int quantity = GetNumberInput("\n\nEnter amount of water (No decimals)\n\n");

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();
                tableCmd.CommandText =
                    $"INSERT INTO drinking_water(date, quantity) VALUES('{date}', '{quantity}')";

                tableCmd.ExecuteNonQuery();

                connection.Close();
            }

            GetUserInput();
        }

        internal static string GetDateInput(string messageDate)
        {
            Console.WriteLine(messageDate);

            string? dateInput = Console.ReadLine();

            if (dateInput == "0") GetUserInput();

            return dateInput!;


        }

        internal static int GetNumberInput(string messageQuantity)
        {
            Console.WriteLine(messageQuantity);


            string? numberInput = Console.ReadLine();

            if (numberInput == "0") GetUserInput();

            int finalInput = Convert.ToInt32(numberInput);

            return finalInput;

        }

        private static void Delete()
        {
            Console.Clear();

            GetAllRecords();

            var recordId = GetNumberInput("\n\nEnter the Id of the row you want to delete or enter 0 to exit to menu");

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();
                tableCmd.CommandText =
                    $"DELETE FROM drinking_water WHERE Id = '{recordId}'";

                int rowCount = tableCmd.ExecuteNonQuery();

                if (rowCount == 0)
                {
                    Console.WriteLine($"\n\nThere are no records with the id:{recordId}");
                    Delete();
                }

            }

            Console.WriteLine($"\n\nId {recordId} has been deleted\n\n");
            
            GetUserInput();

        }

        private static void GetAllRecords()
        {
            Console.Clear();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();
                tableCmd.CommandText =
                    $"SELECT * FROM drinking_water";

                List<DrinkingWater> tableData = new();

                SqliteDataReader reader = tableCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        tableData.Add(
                            new DrinkingWater
                            {
                                Id = reader.GetInt32(0),
                                Date = DateTime.ParseExact(reader.GetString(1), "dd-MM-yy", new CultureInfo("en-US")),
                                Quantity = reader.GetInt32(2)
                            });
                    }
                }
                else
                {
                    Console.WriteLine("No Records Found");
                }

                connection.Close();

                Console.WriteLine("-----------------------------------------\n");
                foreach (var dw in tableData)
                {
                    Console.WriteLine($"{dw.Id} - {dw.Date.ToString("dd-MMM-yyyy")} - Quantity: {dw.Quantity}");
                }
                Console.WriteLine("-----------------------------------------\n");

            }
        }
    }
}

public class DrinkingWater
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int Quantity { get; set; }
}

