string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine("Does Lyrics Contain goodbye: " + songLyrics.Contains("goodbye"));
Console.WriteLine("Does Lyrics Contain greetings: " + songLyrics.Contains("greetings"));

//dotnet learn search challenge:
var youSearchStart = songLyrics.StartsWith("You");
var goodbyeSearchStart = songLyrics.StartsWith("goodbye");
var helloSearchEnd = songLyrics.EndsWith("hello");
var goodbyeSearchEnd = songLyrics.EndsWith("goodbye");

Console.WriteLine(
    "Lyric Start\n" +
    $"You: {youSearchStart}\n" +
    $"goodbye: {goodbyeSearchStart}\n" +
    "Lyric End \n" +
    $"hello: {helloSearchEnd}\n" +
    $"goodbye: {goodbyeSearchEnd}"
    );