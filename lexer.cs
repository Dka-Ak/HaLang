using System;
using System.Collections.Generic;

public class Lexer
{
    public static List<string> Tokenize(string code)
    {
        // Tokenization logic here
        return new List<string>();
    }

    public static void Main(string[] args)
    {
        string code = System.IO.File.ReadAllText(args[0]);
        List<string> tokens = Tokenize(code);
        foreach (var token in tokens)
        {
            Console.WriteLine(token);
        }
    }
}
