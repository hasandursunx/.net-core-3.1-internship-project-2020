using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoceyder.WebUI.Entity;

namespace Yoceyder.WebUI.Repository.Abstrack
{
    public interface IDonationRepository : IGenericRepository<Donation>
    {
        Donation GetByName(string name);
        Donation GetById(int Donation_Id);

        void SaveDonation(Donation entity);

        void UpdateDonation(Donation entity);

        void DeleteDonation(int Donation_Id);
    }
}
