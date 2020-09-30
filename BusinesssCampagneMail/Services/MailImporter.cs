using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
using BusinesssCampagneMail.Models;

namespace BusinesssCampagneMail.Service
{
    public sealed class MailImporter
    {
        private static MailImporter instance = null;
        private static readonly object padlock = new object();
        public static MailImporter Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MailImporter();
                    }
                    return instance;
                }
            }
        }


        public List<Mail> GetMailsFromText(string pathFile, int campagneID)
        {
            List<Mail> mails = new List<Mail>();
            // Si le fichier n'existe pas
            if (!File.Exists(pathFile))
            {
                throw new Exception("The file doesn't exist");
            }

            // Start to read file
            string[] lines = System.IO.File.ReadAllLines(pathFile);

            foreach(var line in lines)
            {
                string[] mailData = line.Split(',');
                mailData[2] = mailData[2].Trim();
                
                if (!this.CheckMailData(mailData))
                {
                    continue;
                }
                // On ajoute le mail à la liste
                mails.Add(new Mail(mailData, campagneID));
            }
            return mails;
        }

        public List<Mail> GetMailsFromCSV(string pathFile, int campagneId)
        {
            // Init mail list and streamer for CSV file
            List<Mail> mails = new List<Mail>();
            var reader = new StreamReader(File.OpenRead(pathFile));

            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
                values[2] = values[2].Trim();

                if (!this.CheckMailData(values))
                {
                    continue;
                }
                mails.Add(new Mail(values, campagneId));
            }

            return mails;
        }

        private bool CheckMailData(string[] mailData)
        {
            if (mailData.Length != 3)
            {
                // Si on a pas les trois champs nécessaire, on passe à l'itération suivante
                Console.WriteLine("Cette ligne ne contiens pas les informations nécessaires (nom, prenom, email)");
                return false;
            }

            if (!this.CheckMail(mailData[2]))
            {
                return false;
            }
            

            return true;
        }

        public bool CheckMail(string mail)
        {
            // Trim mail
            mail = mail.Trim();
            if (!Regex.IsMatch(mail, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return false;
            }
            return true;
        }
    }
}
