using BusinesssCampagneMail.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinesssCampagneMail.DAO.interfaces
{
    interface ICampagneDAO
    {
        bool Add(Campagne o);
        bool Delete(int id);
        bool Update(Campagne o);
        List<Campagne> GetAll();
        Campagne GetOne(int id);
    }
}
