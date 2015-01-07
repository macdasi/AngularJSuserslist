using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace tzunami_test.Models
{
    public class BaseUser : IBaseUser
    {
        public long ID { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string EMail { get; set; }

        protected UserType _Type;
        public string Type { get { return _Type.ToString(); 
        }
            set {
                _Type = (UserType)Enum.Parse(typeof(UserType), value, true);
            }
        }
    }
}