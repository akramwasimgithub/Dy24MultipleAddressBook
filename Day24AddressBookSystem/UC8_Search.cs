using System;
using System.Collections.Generic;
using System.Text;

namespace Day24AddressBookSystem
{
    class UC8_Search
    {
       
        public static Dictionary<string, List<Contacts>> mySystem = new Dictionary<string, List<Contacts>>();
        public static List<Contacts> addressBook;

        public static void addAddressBook()
        {
            Console.WriteLine("How many addressbooks do you want to create?");
            int count = Convert.ToInt32(Console.ReadLine());
            while (count > 0)
            {
                Console.WriteLine("Do you want to add the contact in the existing addressbook or new addressbook\n Enter the number accordingly\n 1. New addressbook\n 2. Existing addressbook");
                int key = Convert.ToInt32(Console.ReadLine());
                if (key == 1)
                {
                    AddressBookNewNameValidator();
                    count--;
                }
                else if (key == 2)
                {
                    AddressBookExistingNameValidator();
                }
            }
        }

        public static void AddressBookNewNameValidator()
        {
            Console.WriteLine("Enter the new addressbook name\n");
            string addressBookName = Console.ReadLine();
            if (mySystem.ContainsKey(addressBookName))
            {
                Console.WriteLine("Please enter a new addressbook name. The name entered already exist");
                AddressBookNewNameValidator();
            }
            else
            {
                mySystem[addressBookName] = new List<Contacts>();
                AddContact(addressBookName);
            }
        }
        public static void AddressBookExistingNameValidator()
        {
            Console.WriteLine("Enter the Existing addressbook name\n");
            string addressBookName = Console.ReadLine();
            if (!mySystem.ContainsKey(addressBookName))
            {
                Console.WriteLine("Please enter a new addressbook name. The name entered already exist");
                AddressBookExistingNameValidator();
            }
            else
            {
                AddContact(addressBookName);
            }
        }
        public static void AddContact(string addressBookName)
        {
            Console.WriteLine("How many person's contact details do you want to add?");
            int personNum = Convert.ToInt32(Console.ReadLine());
            while (personNum > 0)
            {
                Contacts person = new Contacts();
            firstName:
                Console.WriteLine("Enter your First name");
                string firstName = Console.ReadLine();
                if (NameDuplicationCheck(addressBookName, firstName))
                {
                    person.firstName = firstName;
                }
                else
                {
                    Console.WriteLine("The name {0} already  exist in the current address book. please enter a new name", firstName);
                    goto firstName;
                }

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

                mySystem[addressBookName].Add(person);
                Console.WriteLine("{0}'s contact succesfully added", person.firstName);

                personNum--;
            }
        }

        public static bool NameDuplicationCheck(string addressBookName, string firstName)
        {
            int flag = 0;
            if (mySystem[addressBookName].Count > 0)
            {
                foreach (Contacts contact in mySystem[addressBookName])
                {
                    if (!(contact.firstName == firstName))
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag = 0;
                        break;
                    }
                }
            }
            else
            {
                return true;
            }
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void ContactsDisplay()
        {
            Console.WriteLine("Enter the name of the addressbook that you wants to use for displaying contacts");
            string addressBookName = Console.ReadLine();
            if (mySystem[addressBookName].Count > 0)
            {
                Console.WriteLine("Enter the name of the person to get all the contact details");
                string nameKey = Console.ReadLine();
                int check = 0;
                foreach (Contacts contact in mySystem[addressBookName])
                {
                    if (nameKey.ToLower() == contact.firstName.ToLower())
                    {
                        check = 1;
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
                }
                if (check == 0)
                {
                    Console.WriteLine("contact of the person {0} does not exist", nameKey);
                }
            }
            else
            {
                Console.WriteLine("Your address book is empty");
            }
        }

        
       

        public static void PersonSearch()
        {
            Console.WriteLine("Enter the city that you want to search");
            string cityKey = Console.ReadLine();
            Console.WriteLine("Enter the state that you want to search");
            string stateKey = Console.ReadLine();
            foreach (string addressBookName in mySystem.Keys)
            {
                foreach (Contacts contact in mySystem[addressBookName])
                {
                    if (cityKey.ToLower() == contact.city || stateKey.ToLower() == contact.state)
                    {
                        Console.WriteLine("In address book {0}, {1} is staying in {2} city and {3} state", addressBookName, contact.firstName, contact.city, contact.state);
                    }
                }
            }
        }
    }
}
