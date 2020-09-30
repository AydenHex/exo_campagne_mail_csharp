using System;

using BusinesssCampagneMail.Service;
using BusinesssCampagneMail.Models;
using System.Collections.Generic;

namespace BusinesssCampagneMail
{
    class Program
    {
        static void Main(string[] args)
        {
            MailImporter mailImporter = MailImporter.Instance;

            List<Mail> test = mailImporter.GetMailsFromText(@"C:\Users\royer\Documents\test.txt", 1);
            Console.WriteLine(test.Count);
            List<Mail> test2 = mailImporter.GetMailsFromCSV(@"C:\Users\royer\Documents\Classeur1.csv", 1) ;
            test.AddRange(test2);
            Console.WriteLine(test.Count);
        }
    }
}
