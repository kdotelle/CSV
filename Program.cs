// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Linq;
using System.ComponentModel.DataAnnotations;
//using Microsoft.VisualBasic.FileIO;
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
            var inputFile = Console.ReadLine() + ".csv";
            Console.WriteLine("Searching for file: {0}", inputFile);

            //from documentation
            string currentDirectory = Directory.GetCurrentDirectory();

            var files = Directory.GetFiles(currentDirectory, "*.csv");

            // var files = from retrievedFile in Directory.EnumerateFiles(currentDirectory, "*.csv", SearchOption.AllDirectories)

            //             from line in File.ReadLines(retrievedFile)
            //             where line.Contains(inputFile)
            //             select new
            //             {
            //                 File = retrievedFile,
            //                 Line = line
            //             };

            if (File.Exists(inputFile))
            {
                string fullPath = Path.GetFullPath(inputFile);
                Console.WriteLine(fullPath);
                Console.WriteLine("File {0} exists", inputFile);
                Console.WriteLine(File.ReadAllText(inputFile));
            }
            else if (!File.Exists(inputFile))
            {
                Console.WriteLine("{0} does not exist in this Directory", inputFile);
            }




            //initialize lists for valid and invalid emails
            List<string> validEmail = new List<string>();
            List<string> invalidEmail = new List<string>();

            //validEmail.Add() and invalidEmail.Add() to add to list

            foreach (var f in files)
            {
                //parse csv
                //if file exists iterate thru each row to conf email is accurate



                //EmailAddress Attribute validates an email address
                var email = new EmailAddressAttribute();
                bool valid;
                valid = email.IsValid("test@gmail.com"); //change this to email from csv file

                if (new EmailAddressAttribute().IsValid("someone@somewhere.com"))
                    valid = true;
            }
            //print lists of valid and invalid email lists
            Console.WriteLine("Valid Email List:");
            foreach (string email in validEmail)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine("Invalid Email List:");
            foreach (string email in invalidEmail)
            {
                Console.WriteLine(email);
            }
        }

    }

}
