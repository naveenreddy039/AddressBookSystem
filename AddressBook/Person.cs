using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
       
        public string PhoneNumber { get; set; }
        public String Email { get; set; }

        public Person(string firstName, string lastName, string address, string city, string state, string phoneNumber, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
     
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }
    }
}
