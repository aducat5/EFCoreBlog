using EFCoreBlog.BLL.Interfaces;
using EFCoreBlog.BLL.Security;
using EFCoreBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCoreBlog.BLL.Repos
{
    class UserRepo : ICRUD<User>
    {
        EFCoreBlogDB db = new EFCoreBlogDB();
        public bool Delete(User Entity, out string state)
        {
            if (EntityValidation.ValidateUserEntity(Entity, out state))
            {
                Entity.IsDeleted = true;
                bool sonuc = db.SaveChanges() > 1;
                if (sonuc)
                {
                    state = "User deleted successfully";
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }    
        }

        public List<User> GetAll()
        {
            List<User> allUsers = db.Users.ToList();
            return allUsers;
        }

        public User GetByID(int ID)
        {
            if (ID > 0)
            {
                try
                {
                    User user = db.Users.Find(ID);
                    return user;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public bool Insert(User Entity, out string state)
        {
            if (EntityValidation.ValidateUserEntity(Entity, out state))
            {
                db.Users.Add(Entity);
                bool sonuc = db.SaveChanges() > 0;
                if (sonuc)
                {
                    state = "User added successfully";
                    return true;
                }
                else
                {
                    state = "There was a problem adding user to db";
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        

        public bool Update(User Entity, out string state)
        {
            if (EntityValidation.ValidateUserEntity(Entity, out state))
            {
                db.Entry(db.Users.Find(Entity.UserID)).CurrentValues.SetValues(Entity);
                bool sonuc = db.SaveChanges() > 1;
                if (sonuc)
                {
                    state = "User updated successfully";
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


    }
}
