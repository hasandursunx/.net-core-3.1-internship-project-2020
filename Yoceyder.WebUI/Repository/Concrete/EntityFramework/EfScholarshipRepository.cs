using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Yoceyder.WebUI.Entity;
using Yoceyder.WebUI.Repository.Abstrack;

namespace Yoceyder.WebUI.Repository.Concrete.EntityFramework
{
    public class EfScholarshipRepository : EfGenericRepository<Scholarship>, IScholarshipRepository
    {
        public EfScholarshipRepository(YoceyderContext context) : base(context)
        {

        }

        public YoceyderContext YoceyderContext
        {
            get { return context as YoceyderContext; }
        }

        public void DeleteScholarship(int Scholarship_Id)
        {
            var Scholarship = YoceyderContext.Scholarships.FirstOrDefault(p => p.Burs_Id == Scholarship_Id);
            if (Scholarship != null)
            {
                YoceyderContext.Scholarships.Remove(Scholarship);
                context.SaveChanges();
            }
        }

        public Scholarship GetById(int Scholarship_Id)
        {
            return YoceyderContext.Scholarships.FirstOrDefault(p => p.Burs_Id == Scholarship_Id);
        }

        public Scholarship GetByName(string name)
        {
            return YoceyderContext.Scholarships.Where(i => i.Burs_BsvrAdiSoyadi == name).FirstOrDefault();
        }

        public void SaveScholarship(Scholarship entity)
        {
            YoceyderContext.Scholarships.Add(entity);

            context.SaveChanges();
        }

        public void UpdateScholarship(Scholarship entity)
        {
            var scholarship = GetById(entity.Burs_Id);

            if (scholarship != null)
            {
                scholarship.Burs_BankaAdi = entity.Burs_BankaAdi;
                scholarship.Burs_BsvrTelefon = entity.Burs_BsvrTelefon;
                scholarship.Burs_BsvrAdiSoyadi = entity.Burs_BsvrAdiSoyadi;
                scholarship.Burs_Iban = entity.Burs_Iban;
                scholarship.Burs_IbanSahibi = entity.Burs_IbanSahibi;
                scholarship.Burs_Miktar = entity.Burs_Miktar;
                scholarship.Burs_Sure = entity.Burs_Sure;

            }
            context.SaveChanges();
        }
    }
}
