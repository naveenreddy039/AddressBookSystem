using AddressBook;
using System;

namespace AddressBookSystem
{
    
    class Program
    {
        ContactPerson book =new ContactPerson();

        static void Main(string[] args)
        {
            string selection="";
            Program program = new Program();

            program.displayMenu();
            while(!selection.ToUpper().Equals("Q"))
            {
                Console.WriteLine("Selection:");
                selection=Console.ReadLine();
                program.perfromAction(selection);
            }
        }
        void displayMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("=========");
            Console.WriteLine("A - Add an Address");
            Console.WriteLine("D - Delete an Address");
            Console.WriteLine("E - Edit an Address");
            Console.WriteLine("L - List All Addresses");
            Console.WriteLine("Q - Quit");
        }
        void perfromAction(string selection)
        {
            string FirstName = "";
            string LastName = "";
            string Address = "";
            string City = "";
            string State = "";
            
            string PhoneNumber ="";
            string Email = "";
            
            switch(selection.ToUpper())
            {
                
                case "A":
                    Console.WriteLine("Enter FirstName: ");
                    FirstName = Console.ReadLine();
                    Console.WriteLine("Enter LastName: ");
                    LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    Address = Console.ReadLine();
                    Console.WriteLine("Enter City: ");
                    City = Console.ReadLine();
                    Console.WriteLine("Enter State: ");
                    State = Console.ReadLine();
                    Console.WriteLine("Enter PhoneNumber: ");
                    PhoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter Email: ");
                    Email = Console.ReadLine();
                    if (book.add(FirstName, LastName, Address, City, State, PhoneNumber, Email))
                    {
                        Console.WriteLine("Address successfully added!");
                    }
                    else
                    {
                        Console.WriteLine("An address is already on file for {0}.", FirstName);
                    }
                    break;
                case "D":
                    Console.WriteLine("Enter Name to Delete: ");
                    FirstName = Console.ReadLine();
                    if (book.remove(FirstName))
                    {
                        Console.WriteLine("Address successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Address for {0} could not be found.", FirstName);
                    }
                    break;
                case "E":
                    Console.WriteLine("Enter FirstName to Edit: ");
                    FirstName = Console.ReadLine();
                    Person addr = book.find(FirstName);
                    if (addr == null)
                    {
                        Console.WriteLine("Address for {0} count not be found.", FirstName);
                    }
                    else
                    {
                        Console.WriteLine("Enter new Address: ");
                        addr.Address = Console.ReadLine();
                        Console.WriteLine("Address updated for {0}-{7}", FirstName, LastName, Address, City, State, PhoneNumber, Email);
                    }
                    break;
                case "L":
                    if (book.isEmpty())
                    {
                        Console.WriteLine("There are no entries.");
                    }
                    else
                    {
                        Console.WriteLine("Addresses:");
                        book.list((a) => Console.WriteLine("{0} - {1}", a.FirstName, a.LastName,a.Address,a.City,a.State,a.PhoneNumber,a.Email));
                    }
                    break;
            }
        }
    }
}
