using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tzunami_test.Models
{
    public class Lecturer : BaseUser
    {
        public Lecturer(){
            this._Type = UserType.Lecturer;
        }
    }
}