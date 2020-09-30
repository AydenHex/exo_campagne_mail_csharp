using BusinesssCampagneMail.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinesssCampagneMail.DAO.interfaces
{
    interface IMailDAO
    {
        bool Add(Mail o);
        bool Delete(int id);
        bool Update(Mail o);
        List<Mail> GetAll();
        Mail GetOne(int id);
    }
}
