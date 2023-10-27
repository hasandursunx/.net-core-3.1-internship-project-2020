using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoceyder.WebUI.Entity;

namespace Yoceyder.WebUI.Repository.Abstrack
{
    public interface IChildRepository : IGenericRepository<Child>
    {
        Child GetByName(string name);
        Child GetById(int Child_Id);

        void SaveChild(Child entity);

        void UpdateChild(Child entity);

        void DeleteChild(int Child_Id);
    }
}
