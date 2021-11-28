using System;
using System.Collections.Generic;
using System.Text;

namespace Day24AddressBookSystem
{
    class UC3
    {
        public static List<Contacts> addressBook = new List<Contacts>();
        public static void AddContact()
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
      
        
        public static void EditContact()
        {
            Console.WriteLine("Enter the first name of the person whom you want to edit the details");
            string editKey = Console.ReadLine();
            if (addressBook.Count > 0)
            {
                foreach (Contacts contact in addressBook)
                {
                    if (editKey.ToLower() == contact.firstName.ToLower())
                    {
                        Console.WriteLine("Enter the key number for editing the details\n 1. First name\n 2. Last name\n 3. Address\n 4. City\n 5. State\n 6. Zipcode\n 7. Phone number\n 8. Email ID");
                        int key = Convert.ToInt32(Console.ReadLine());
                        switch (key)
                        {
                            case 1:
                                Console.WriteLine("Enter the new First name");
                                contact.firstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the new Last name");
                                contact.lastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter the new address");
                                contact.address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter the new city");
                                contact.city = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter the new state");
                                contact.state = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter the new zip code");
                                contact.ZipCode = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter the new phone");
                                contact.PhoneNunmber = Console.ReadLine();
                                break;
                            case 8:
                                Console.WriteLine("Enter the new E-Mail ID");
                                contact.eMail = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine("Please enter a valid input");
                                EditContact();
                                break;
                        }
                        Console.WriteLine("{0}'s contact has been sucessfully added", editKey);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("contact of the person {0} does not exist", editKey);
                        break;
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

