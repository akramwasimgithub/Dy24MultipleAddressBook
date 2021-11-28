using System;
using System.Collections.Generic;
using System.Text;

namespace Day24AddressBookSystem
{
    class AddressBook
    {
        public static List<Contacts> addressBook = new List<Contacts>();
        public static void AddContact()
        {
            Console.WriteLine("How many contacts do you want to add?");
            int contactsNum = Convert.ToInt32(Console.ReadLine());
            while (contactsNum > 0)
            {
                Contacts person = new Contacts();

                Console.WriteLine("Enter your First name");
                person.firstName = Console.ReadLine();
                Console.WriteLine("Enter your Last name");
                person.lastName = Console.ReadLine();
                Console.WriteLine("Enter your address");
                person.address = Console.ReadLine();
                Console.WriteLine("Enter your city");
                person.city = Console.ReadLine();
                Console.WriteLine("Enter your State");
                person.state = Console.ReadLine();
                Console.WriteLine("Enter your Zip code");
                person.ZipCode = Console.ReadLine();
                Console.WriteLine("Enter your Phone number");
                person.PhoneNunmber = Console.ReadLine();
                Console.WriteLine("Enter your Email ID");
                person.eMail = Console.ReadLine();

                addressBook.Add(person);
                Console.WriteLine("{0}'s contact succesfully added", person.firstName);
                contactsNum--;
            }
        }
        public static void ContactsDisplay()
        {
            if (addressBook.Count > 0)
            {
                Console.WriteLine("Enter the name of the person to get all the contact details");
                string nameKey = Console.ReadLine();
                foreach (Contacts contact in addressBook)
                {
                    if (nameKey.ToLower() == contact.firstName.ToLower())
                    {
                        Console.WriteLine("First name-->{0}", contact.firstName);
                        Console.WriteLine("Last name-->{0}", contact.lastName);
                        Console.WriteLine("Address-->{0}", contact.address);
                        Console.WriteLine("City-->{0}", contact.city);
                        Console.WriteLine("State-->{0}", contact.state);
                        Console.WriteLine("Zip code-->{0}", contact.ZipCode);
                        Console.WriteLine("Phone number-->{0}", contact.PhoneNunmber);
                        Console.WriteLine("E-Mail ID-->{0}", contact.eMail);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("contact of the person {0} does not exist", nameKey);
                    }
                }
            }
            else
            {
                Console.WriteLine("Your address book is empty");
            }
        }
    }
}
