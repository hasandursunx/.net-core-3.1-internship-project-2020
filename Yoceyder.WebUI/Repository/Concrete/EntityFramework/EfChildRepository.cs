using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Yoceyder.WebUI.Entity;
using Yoceyder.WebUI.Repository.Abstrack;

namespace Yoceyder.WebUI.Repository.Concrete.EntityFramework
{
    public class EfChildRepository : EfGenericRepository<Child>,IChildRepository
    {
        public EfChildRepository(YoceyderContext context) : base(context)
        {

        }
        public YoceyderContext YoceyderContext
        {
            get { return context as YoceyderContext; }
        }

        public void DeleteChild(int Child_Id)
        {
            var child = YoceyderContext.Children.FirstOrDefault(p => p.Cocuk_Id == Child_Id);
            if (child != null)
            {
                YoceyderContext.Children.Remove(child);
                context.SaveChanges();
            }
        }

        public Child GetById(int Child_Id)
        {
            return YoceyderContext.Children.FirstOrDefault(p => p.Cocuk_Id == Child_Id);
        }

        public Child GetByName(string name)
        {
            return YoceyderContext.Children.Where(i => i.Cocuk_AdiSoyadi == name).FirstOrDefault();
        }

        public void SaveChild(Child entity)
        {
            YoceyderContext.Children.Add(entity);

            context.SaveChanges();
        }

        public void UpdateChild(Child entity)
        {
            var child = GetById(entity.Cocuk_Id);

            if (child != null)
            {
                child.Cocuk_Tc = entity.Cocuk_Tc;
                child.Cocuk_AdiSoyadi = entity.Cocuk_AdiSoyadi;
                child.Cocuk_Cinsiyet = entity.Cocuk_Cinsiyet;
                child.Cocuk_DogumTarihi = entity.Cocuk_DogumTarihi;
                child.Cocuk_OgrenimDurumu = entity.Cocuk_OgrenimDurumu;
                child.Cocuk_OkulAdi = entity.Cocuk_OkulAdi;
                child.Cocuk_Sinif = entity.Cocuk_Sinif;
                child.Cocuk_VasiYakinlik = entity.Cocuk_VasiYakinlik;
                child.Cocuk_KaldigiYer = entity.Cocuk_KaldigiYer;
                child.Cocuk_AnneAdi = entity.Cocuk_AnneAdi;
                child.Cocuk_BabaAdi = entity.Cocuk_BabaAdi;
                child.Cocuk_AnneDurum = entity.Cocuk_AnneDurum;
                child.Cocuk_BabaDurum = entity.Cocuk_BabaDurum;
            }
            context.SaveChanges();
        }
    }
}
