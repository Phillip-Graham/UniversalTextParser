 namespace ManualTesting;

 using System.Text.Json;
 using UniversalTextParser;

 public class Program
 {
    const string testJson = """
        {
            "name": "Testing",
            "targets": [
                {
                    "recursive": false,
                    "directoryPath": "this\\is\\a\\test"
                }
            ],
            "steps": [
                {
                    "keyword": "alfonzo",
                    "regexString": "i hate backslashes"
                }
            ]
        }
    """;

    public static void Main()
    {
        ParserJob pj = JsonSerializer.Deserialize<ParserJob>(testJson);

        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
    }

 }