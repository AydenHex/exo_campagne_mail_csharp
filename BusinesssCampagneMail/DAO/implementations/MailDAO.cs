using BusinesssCampagneMail.DAO.interfaces;
using BusinesssCampagneMail.Database;
using BusinesssCampagneMail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinesssCampagneMail.DAO.implementations
{
    class MailDAO : IMailDAO
    {
        private EfContext context;

        public MailDAO()
        {
            this.context = new EfContext();
        }

        public bool Add(Mail o)
        {
            context.Mails.Add(o);
            return context.SaveChanges() != 0 ? true : false;
        }

        public bool Delete(int id)
        {
            Mail mail = this.GetOne(id);
            context.Mails.Remove(mail);
            return context.SaveChanges() != 0 ? true : false;
        }

        public List<Mail> GetAll()
        {
            return context.Mails
                .ToList();
        }

        public Mail GetOne(int id)
        {
            return context.Mails
                .Where(mail => mail.id.Equals(id))
                .FirstOrDefault();
        }

        public bool Update(Mail o)
        {
            context.Mails.Update(o);
            return context.SaveChanges() != 0 ? true : false;
        }
    }
}
