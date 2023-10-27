using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoceyder.WebUI.Entity;
using Yoceyder.WebUI.Repository.Abstrack;

namespace Yoceyder.WebUI.Repository.Concrete.EntityFramework
{
    public class EfDonationRepository : EfGenericRepository<Donation>, IDonationRepository
    {
        public EfDonationRepository(YoceyderContext context) : base(context)
        {

        }

        public YoceyderContext YoceyderContext
        {
            get { return context as YoceyderContext; }
        }


        public void DeleteDonation(int Donation_Id)
        {
            var Donation = YoceyderContext.Donation.FirstOrDefault(p => p.Yardim_Id == Donation_Id);
            if (Donation != null)
            {
                YoceyderContext.Donation.Remove(Donation);
                context.SaveChanges();
            }
        }

        public Donation GetById(int Donation_Id)
        {
            return YoceyderContext.Donation.FirstOrDefault(p => p.Yardim_Id == Donation_Id);
        }

        public Donation GetByName(string name)
        {
            return YoceyderContext.Donation.Where(i => i.Yardim_Tur == name).FirstOrDefault();
        }

        public void SaveDonation(Donation entity)
        {
            YoceyderContext.Donation.Add(entity);

            context.SaveChanges();
        }

        public void UpdateDonation(Donation entity)
        {
            var donation = GetById(entity.Yardim_Id);

            if (donation != null)
            {
                donation.Yardim_Tur = entity.Yardim_Tur;
                donation.Yardim_Urun = entity.Yardim_Urun;
                donation.Yardim_Miktar = entity.Yardim_Miktar;
                donation.Yardim_Aciklama = entity.Yardim_Aciklama;
                donation.Yardim_Tarih = entity.Yardim_Tarih;
                donation.Yardim_Ysvr_Adisoyadi = entity.Yardim_Ysvr_Adisoyadi;
                donation.Yardim_Ysvr_Telno = entity.Yardim_Ysvr_Telno;

            }
            context.SaveChanges();
        }
    }
}
