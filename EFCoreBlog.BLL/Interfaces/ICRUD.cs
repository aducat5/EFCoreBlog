using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreBlog.BLL.Interfaces
{
    interface ICRUD<T>
    {
        List<T> GetAll();
        T GetByID(int ID);
        bool Insert(T Entity, out string state);
        bool Update(T Entity, out string state);
        bool Delete(T Entity, out string state);
        
    }
}
