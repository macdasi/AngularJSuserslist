using System;
namespace tzunami_test.Models
{
    interface IBaseUser
    {
        string EMail { get; set; }
        string FirstName { get; set; }
        long ID { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }

        string Type { get; set; }
    }
}
