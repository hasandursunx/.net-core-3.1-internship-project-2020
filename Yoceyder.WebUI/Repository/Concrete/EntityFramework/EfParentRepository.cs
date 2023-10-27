using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoceyder.WebUI.Entity;
using Yoceyder.WebUI.Models;
using Yoceyder.WebUI.Repository.Abstrack;

namespace Yoceyder.WebUI.Repository.Concrete.EntityFramework
{
    public class EfParentRepository : EfGenericRepository<Parent>, IParentRepository
    {
        public EfParentRepository(YoceyderContext context) : base(context)
        {

        }

        public YoceyderContext YoceyderContext
        {
            get { return context as YoceyderContext; }
        }

        public void DeleteParent(int Parent_Id)
        {
            var parent = YoceyderContext.Parents.FirstOrDefault(p => p.Vasi_Id == Parent_Id);
            if (parent != null)
            {
                YoceyderContext.Parents.Remove(parent);
                context.SaveChanges();
            }
        }

        public Parent GetById(int Vasi_Id)
        {
           
            return YoceyderContext.Parents.FirstOrDefault(p => p.Vasi_Id == Vasi_Id);
        }

        public Parent GetByName(string name)
        {
            return YoceyderContext.Parents.Where(i => i.Vasi_AdiSoyadi == name).FirstOrDefault();
        }


        public void SaveParent(Parent entity)
        {
           YoceyderContext.Parents.Add(entity);

            context.SaveChanges();
        }

        public void UpdateParent(Parent entity)
        {
            var parent = GetById(entity.Vasi_Id);

            if (parent != null)
            {
                parent.Vasi_Dosya = entity.Vasi_Dosya;
                parent.Vasi_Tc = entity.Vasi_Tc;
                parent.Vasi_AdiSoyadi = entity.Vasi_AdiSoyadi;
                parent.Vasi_Telefon = entity.Vasi_Telefon;
                parent.Vasi_Il = entity.Vasi_Il;
                parent.Vasi_Ilce = entity.Vasi_Ilce;
                parent.Vasi_Adres = entity.Vasi_Adres;
                parent.Vasi_Iban = entity.Vasi_Iban;
                parent.Vasi_Evdurumu = entity.Vasi_Evdurumu;
                parent.Vasi_Kiramiktari = entity.Vasi_Kiramiktari;
                parent.Vasi_Maas = entity.Vasi_Maas;
                parent.Vasi_Maasmiktari = entity.Vasi_Maasmiktari;
                parent.Vasi_Cocuksayisi = entity.Vasi_Cocuksayisi;
                parent.Vasi_Kayittarihi = entity.Vasi_Kayittarihi;
                parent.Vasi_Guncellemetarihi = entity.Vasi_Guncellemetarihi;
                parent.Vasi_Resimyolu = entity.Vasi_Resimyolu;

            }
            context.SaveChanges();
        }
    }
}
