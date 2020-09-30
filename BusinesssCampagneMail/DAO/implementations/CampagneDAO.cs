using BusinesssCampagneMail.DAO.interfaces;
using BusinesssCampagneMail.Database;
using BusinesssCampagneMail.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinesssCampagneMail.DAO.implementations
{
    public class CampagneDAO : ICampagneDAO
    {
        private EfContext context;
        public CampagneDAO()
        {
            context = new EfContext();
        }

        public bool Add(Campagne o)
        {
            context.Campagnes.Add(o) ;
            return context.SaveChanges() != 0 ? true : false;
        }

        public bool Delete(int id)
        {
            Campagne campagne;
            campagne = this.GetOne(id);
            context.Campagnes.Remove(campagne);
            return context.SaveChanges() != 0 ? true : false;
        }

        public List<Campagne> GetAll()
        {
            return context.Campagnes
                .Include(campagne => campagne.mails)
                .ToList<Campagne>();
        }

        public Campagne GetOne(int id)
        {
            return context.Campagnes
                .Where(campagne => campagne.id.Equals(id))
                .Include(campagne => campagne.mails)
                .FirstOrDefault();
        }

        public bool Update(Campagne o)
        {
            context.Campagnes.Update(o);
            return context.SaveChanges() != 0 ? true : false;
        }
    }
}
