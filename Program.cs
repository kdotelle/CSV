// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Linq;
using System.ComponentModel.DataAnnotations;

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

            //var files = Directory.GetFiles(currentDirectory, "*.csv");


            if (File.Exists(inputFile))
            {
                string fullPath = Path.GetFullPath(inputFile);

                Console.WriteLine("File {0} exists", inputFile);
                //array with each line as a string
                string[] csvLines = File.ReadAllLines(fullPath);
                //initialize lists for valid and invalid emails
                List<string> validEmail = new List<string>();
                List<string> invalidEmail = new List<string>();

                //list with email data
                var emails = new List<string>();

                foreach (var line in csvLines)
                {
                    //split the string at the comma
                    string[] rowData = line.Split(',');
                    emails.Add(rowData[2]);
                }

                //all emails added to a list
                foreach (var email in emails)
                {
                    var checkEmail = new EmailAddressAttribute();
                    bool valid;
                    valid = checkEmail.IsValid(email);

                    if (valid == true)
                    {
                        valid = true;
                        validEmail.Add(email);
                    }
                    else
                    {
                        valid = false;
                        invalidEmail.Add(email);
                    }
                    //valid is not catching example@mail b/c there are valid emails w/ that edgecase like example@localhost or user@localserver
                }
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
            else if (!File.Exists(inputFile))
            {
                Console.WriteLine("{0} does not exist in this Directory", inputFile);
            }

        }

    }

}
