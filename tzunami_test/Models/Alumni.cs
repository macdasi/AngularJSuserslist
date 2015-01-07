using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tzunami_test.Models
{
    public class Alumni : BaseUser
    {
        public Alumni()
        {
            this._Type = UserType.Alumni;
        }
    }
}