using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoceyder.WebUI.Repository.Abstrack;

namespace Yoceyder.WebUI.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly YoceyderContext dbcontext;

        public EfUnitOfWork(YoceyderContext _dbcontext)
        {
            dbcontext = _dbcontext ?? throw new ArgumentNullException("dbcontext boş olamaz");
        }
        private IParentRepository _parents;
        private IChildRepository _children;
        private IDonationRepository _Donations;
        private IScholarshipRepository _Scholarships;

        public IParentRepository Parents
        {
            get
            {
                return _parents ?? (_parents = new EfParentRepository(dbcontext));
            }
        }

        public IChildRepository Children
        {
            get
            {
                return _children ?? (_children = new EfChildRepository(dbcontext));
            }
        }

        public IDonationRepository Donations
        {
            get
            {
                return _Donations ?? (_Donations = new EfDonationRepository(dbcontext));
            }
        }

        public IScholarshipRepository Scholarships
        {
            get
            {
                return _Scholarships ?? (_Scholarships = new EfScholarshipRepository(dbcontext));
            }
        }


        public int SaveChanges()
        {
            try
            {
                return dbcontext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            dbcontext.Dispose();
        }


    }
}
