using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yoceyder.WebUI.Repository.Abstrack
{
    public interface IUnitOfWork : IDisposable
    {
        IParentRepository Parents { get; }
        IChildRepository Children { get; }
        IDonationRepository Donations { get; }
        IScholarshipRepository Scholarships { get; }
        int SaveChanges();
    }
}
