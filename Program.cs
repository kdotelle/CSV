﻿// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Linq;
// Text input for file name
// Iterate thru directory of files to confirm file exists
//use Directory class to search by extension?
// If so, loop thru row and confirm email matches
// Use regex to confirm email address has .com/.net/.edu etc. 
// Make a list for valid email and invalid emails
// Push emails to the correct list
// Print both lists

namespace CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GDC Technical Assignment");
            Console.WriteLine("Enter the file name:");
            var inputFile = Console.ReadLine();
            Console.WriteLine("Searching for file: {0}", inputFile);

            //from documentation
            string archiveDirectory = @"C:\archive";

            var files = from retrievedFile in Directory.EnumerateFiles(archiveDirectory, "*.csv", SearchOption.AllDirectories)
                        from line in File.ReadLines(retrievedFile)
                        where line.Contains(inputFile)
                        select new
                        {
                            File = retrievedFile,
                            Line = line
                        };

            foreach (var f in files)
            {
                Console.WriteLine("{0} contains {1}", f.File, f.Line);
            }
            Console.WriteLine("{0} lines found.", files.Count().ToString());
        }
    }
}