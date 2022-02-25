using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class ContactPerson
    {
        List<Person> persons=new List<Person>();

        public bool add(string firstName, string lastName, string address, string city, string state, string phoneNumber, string email)
        {
            Person pers = new Person(firstName,lastName,address,city,state,phoneNumber,email);
            Person result = find(firstName);

            if (result == null)
            {
                persons.Add(pers);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool remove(string firstName)
        {
            Person pers = find(firstName);
            if(pers!=null)
            {
               persons.Remove(pers);
                return true;

            }
            else
            {
                return false;
            }
        }

        public Person find(string FirstName)
        {
            Person pers = persons.Find((a) => a.FirstName == FirstName);
            return pers;
        }

        public void list(Action<Person> action)
        {
            persons.ForEach(action);
        }

        public bool isEmpty()
        {
            return (persons.Count == 0);
        }
    }
}
