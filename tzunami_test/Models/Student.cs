using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tzunami_test.Models
{
    public class Student :BaseUser
    {
        public Student()
        {
            this._Type = UserType.Student;
        }
    }
}