using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoceyder.WebUI.Entity;

namespace Yoceyder.WebUI.Repository.Abstrack
{
    public interface IScholarshipRepository : IGenericRepository<Scholarship>
    {
        Scholarship GetByName(string name);
        Scholarship GetById(int Scholarship_Id);

        void SaveScholarship(Scholarship entity);

        void UpdateScholarship(Scholarship entity);

        void DeleteScholarship(int Scholarship_Id);
    }
}
