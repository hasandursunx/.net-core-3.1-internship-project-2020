using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yoceyder.WebUI.Entity;
using Yoceyder.WebUI.Models;

namespace Yoceyder.WebUI.Repository.Abstrack
{
    public interface IParentRepository : IGenericRepository<Parent>
    {
        Parent GetByName(string name);
        Parent GetById(int Parent_Id);

        void SaveParent(Parent entity);

        void UpdateParent(Parent entity);

        void DeleteParent(int Parent_Id);
   
    }
}
