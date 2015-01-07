using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tzunami_test.DAL;

namespace tzunami_test.DAL
{
    public class UsersFactory 
    {
        public static IUsersRepository _users;
        public static IUsersRepository Users
        {
            get
            {
                if (_users != null)
                {
                    return _users;
                }
                else
                {
                    UsersRepository rep = new UsersRepository(new List<Models.BaseUser>());
                    _users = rep;
                    return _users;
                }
            }
            set
            {
                if (value != null)
                {
                    _users = value;
                }
            }
        }
    }
}