using EFCoreBlog.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreBlog.BLL.Security
{
    static class EntityValidation
    {
        public static bool ValidateUserEntity(User user, out string state)
        {
            if (user != null)
            {
                if (user.UserID > 0)
                {
                    if (string.IsNullOrEmpty(user.Username))
                    {
                        if (string.IsNullOrEmpty(user.Password))
                        {
                            state = "This is a valid user entity";
                            return true;
                        }
                        else
                        {
                            state = "This is not a valid user entity. Password is null or empty";
                            return false;
                        }
                    }
                    else
                    {
                        state = "This is not a valid user entity. Username is null or empty";
                        return false;
                    }
                }
                else
                {
                    state = "This is not a valid user entity. UserID is not greater than zero";
                    return false;
                }
            }
            else
            {
                state = "This is not a valid user entity. Entity is null";
                return false;
            }
        }

        
    }
}
