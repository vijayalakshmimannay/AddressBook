using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace addressbook
{
    public class Person
    {
        List<contacts> person = new List<contacts>();
        Dictionary<string, List<contacts>> group = new Dictionary<string, List<contacts>>();
        Dictionary<string, List<string>> byCity = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> ByState = new Dictionary<string, List<string>>();





        contacts contact;

        public void createcontacts()
        {
            contact = new contacts();
            bool ststus = true;
            while (ststus)
            {

                Console.WriteLine("Enter First Name: ");
                contact.firstname = Console.ReadLine();
                if (person.Any(p => p.firstname.Equals(contact.firstname)))
                {

                    Console.WriteLine("Name already exit in adress book:");
                }
                else
                {
                    ststus = false;
                }

            }

            Console.WriteLine("Enter Last Name: ");
            contact.lastname = Console.ReadLine();

            Console.WriteLine("Enter Phone Number: ");
            contact.phoneNo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Address: ");
            contact.address = Console.ReadLine();

            Console.WriteLine("Enter City: ");
            contact.city = Console.ReadLine();

            Console.WriteLine("Enter Zip: ");
            contact.zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter State: ");
            contact.state = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            contact.email = Console.ReadLine();

            person.Add(contact);

        }

        public void displaycontacts()
        {
            if (group.Count == 0)
            {
                Console.WriteLine("Address book is empty.");
                return;
            }

            Console.WriteLine("1.Total Contacts\n2.Group");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("List of contacts:\n");
                    foreach (string key in group.Keys)
                    {
                        List<contacts> contacts = group[key];
                        foreach (var contact in contacts)
                        {
                            Console.WriteLine("\nFirst Name: " + contact.firstname + "\nLast Name: " + contact.lastname + "\nAddress: " + contact.address + "\nCity: " + contact.city + "\nState: " + contact.state + "\nZip Code: " + contact.zip + "\nContact No.: " + contact.phoneNo + "\nEmail address: " + contact.email + "----------------------------------------------\n");
                        }
                    }
                    break;
                case 2:
                    foreach (string key in group.Keys)
                    {
                        Console.WriteLine(key);

                    }
                    break;
            }
        }

        public void editcontacts()
        {
            Console.WriteLine("Enter Name of person to edit details: ");
            string name = Console.ReadLine();

            foreach (var contact in program.person)
            {
                if (contact.firstname.Equals(name))
                {
                    Console.WriteLine("which field you want to edit:\n1.full name\n2.last name\n3.address\n4.city\n5.state\n6.zip\n7.phoneNo\n8.email\n");
                    Console.WriteLine("Enter your choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter first name to update:");
                            contact.firstname = Convert.ToString(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Enter last name to update:");
                            contact.lastname = Convert.ToString(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Enter address to update:");
                            contact.address = Convert.ToString(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Enter city to update:");
                            contact.city = Convert.ToString(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Enter state to update:");
                            contact.state = Convert.ToString(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter phone No to update:");
                            contact.phoneNo = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter email to update:");
                            contact.email = Convert.ToString(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter first name to update:");
                            contact.firstname = Convert.ToString(Console.ReadLine());
                            break;
                    }
                }
            }
        }
        public void deletecontacts()
        {
            Console.WriteLine("Enter the Name of person to delete details: ");
            string inp_name = Console.ReadLine();

            foreach (var contact in program.person)
            {
                if (contact.firstname.Equals(inp_name))
                {
                    Console.WriteLine("which field you want to edit:\n1.full name\n2.last name\n3.address\n4.city\n5.state\n6.zip\n7.phoneNo\n8.email\n");
                    Console.WriteLine("Enter your choice:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter first name to delete:");
                            contact.firstname = Convert.ToString(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Enter last name to delete:");
                            contact.lastname = Convert.ToString(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Enter address to delete:");
                            contact.address = Convert.ToString(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Enter city to delete:");
                            contact.city = Convert.ToString(Console.ReadLine());
                            break;
                        case 5:
                            Console.WriteLine("Enter state to delete:");
                            contact.state = Convert.ToString(Console.ReadLine());
                            break;
                        case 6:
                            Console.WriteLine("Enter phone No to delete:");
                            contact.phoneNo = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Enter email to delete:");
                            contact.email = Convert.ToString(Console.ReadLine());
                            break;
                        case 8:
                            Console.WriteLine("Enter first name to delete:");
                            contact.firstname = Convert.ToString(Console.ReadLine());
                            break;
                    }
                }

            }
        }
        public void addmulticontacts()
        {
            Console.WriteLine("How many contacts you want to add: ");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                createcontacts();
                n--;
            }
        }
        public void multiaddressbook()
        {
            Dictionary<string, List<contacts>> group = new Dictionary<string, List<contacts>>();
            Console.WriteLine("Howmany number of address books you want to add? ");
            int numberofbooks = Convert.ToInt32(Console.ReadLine());
            while (numberofbooks > 0)
            {
                Console.WriteLine("Enter name of the owner of this address book: ");
                string gname = Console.ReadLine();
                Person person = new Person();
                person.addmulticontacts();
                group.Add(gname, program.person);
                numberofbooks--;
            }
        }
        public void SearchByCityorState()
        {
            multiaddressbook();
            Console.WriteLine("1. search contacts by city\n2.search contacts by state");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter a city Name to be search: ");
                        string searchByCity = Console.ReadLine();
                        foreach (var contact in group.Keys)
                        {
                            Console.WriteLine("Group Name is :" + contact + " ");
                            foreach (var list in group[contact].FindAll(p => p.city.Equals(searchByCity)))
                            {
                                Console.WriteLine("first name: " + list.firstname);
                                Console.WriteLine("last name: " + list.lastname);
                                Console.WriteLine("address: " + list.address);
                                Console.WriteLine("city: " + list.city);
                                Console.WriteLine("state: " + list.state);
                                Console.WriteLine("zip Code: " + list.zip);
                                Console.WriteLine("contact No: " + list.phoneNo);
                                Console.WriteLine("email address: " + list.email);
                            }

                        }
                        break;

                    }
                case 2:
                    {
                        Console.WriteLine("Enter a state Name to be search: ");
                        string searchByState = Console.ReadLine();
                        foreach (var contact in group.Keys)
                        {
                            Console.WriteLine("Group Name is :" + contact + " ");
                            foreach (var list in group[contact].FindAll(p => p.state.Equals(searchByState)))
                            {
                                Console.WriteLine("first name: " + list.firstname);
                                Console.WriteLine("last name: " + list.lastname);
                                Console.WriteLine("address: " + list.address);
                                Console.WriteLine("city: " + list.city);
                                Console.WriteLine("state: " + list.state);
                                Console.WriteLine("zip Code: " + list.zip);
                                Console.WriteLine("contact No: " + list.phoneNo);
                                Console.WriteLine("email address: " + list.email);
                            }

                        }
                        break;

                    }


            }

        }
        public void displayByCityOrState()
        {
            foreach (var key in group.Keys)
            {
                foreach (var item in group[key])
                {

                    if (byCity.ContainsKey(item.city))
                        byCity[item.city].Add(item.firstname + " " + item.lastname);
                    else
                        byCity.Add(item.city, new List<string>() { item.firstname + " " + item.lastname });
                    if (ByState.ContainsKey(item.state))
                        ByState[item.state].Add(item.firstname + " " + item.lastname);
                    else
                        ByState.Add(item.state, new List<string>() { item.firstname + " " + item.lastname });
                }
            }
            Console.WriteLine("Contacts by city:");
            foreach (var key in byCity.Keys)
            {
                Console.WriteLine("Contacts from city:" + key);
                byCity[key].ForEach(x => Console.WriteLine(x));

            }
            Console.WriteLine("Contacts by state:");
            foreach (var key in ByState.Keys)
            {
                Console.WriteLine("Contacts from state: " + key);
                ByState[key].ForEach(x => Console.WriteLine(x));
            }

        }
        public void getCount()
        {
            foreach (var key in group.Keys)
            {
                foreach (var item in group[key])
                {

                    if (byCity.ContainsKey(item.city))
                        byCity[item.city].Add(item.firstname + " " + item.lastname);
                    else
                        byCity.Add(item.city, new List<string>() { item.firstname + " " + item.lastname });
                    if (ByState.ContainsKey(item.state))
                        ByState[item.state].Add(item.firstname + " " + item.lastname);
                    else
                        ByState.Add(item.state, new List<string>() { item.firstname + " " + item.lastname });
                }
            }
            Console.WriteLine("No. of contacts by city.");
            foreach (var key in byCity.Keys)
            {
                Func<int, int> count = x =>
                {
                    foreach (var value in byCity[key])
                        x += 1;
                    return x;
                };
                Console.WriteLine("No. of contacts in city " + key + " are " + count(0));
            }
            Console.WriteLine("No. of contacts by state.");
            foreach (var key in ByState.Keys)
            {
                Func<int, int> count = x =>
                {
                    foreach (var value in ByState[key])
                        x += 1;
                    return x;
                };
                Console.WriteLine("No. of contacts in state " + key + " are " + count(0));
            }

        }
        public void WriteTextFile()
        {
            string file = @"C:\BridgeLabz\.Net_Fellowship\AddressBook\AddressBook\contacts.txt";
            using StreamWriter writer = File.AppendText(file);
            {
                Console.WriteLine("First Name, LastName, Address, City, State, Zip Code, Phone Number, Email-(Use Comma Separator)");
                writer.WriteLine(Console.ReadLine());
                writer.Close();
            }
        }
        public void ReadTextFile()
        {
            string file = @"C:\BridgeLabz\.Net_Fellowship\AddressBook\AddressBook\contacts.txt";
            string[] reader = File.ReadAllLines(file);
            string[] array = { "First Name", "LastName", "Address", "City", "State", "Zip Code", "Phone Number", "Email" };

            for (int i = 0; i < reader.Length; i++)
            {
                string[] details = reader[i].Split(",");
                for (int j = 0; j < details.Length; j++)
                {
                    Console.WriteLine(array[j] + ": " + details[j]);
                }
                Console.WriteLine();
            }
        }
        public void WriteCSVFile()
        {
            string path = @"C:\BridgeLabz\.Net_Fellowship\AddressBook\AddressBook\contacts.csv";
            StringBuilder creater = new StringBuilder();
            Console.WriteLine("First Name, LastName, Address, City, State, Zip Code, Phone Number, Email--Use Comma Separator");
            creater.AppendLine(Console.ReadLine());
            File.AppendAllText(path, creater.ToString());
        }
        public void ReadCSVFile()
        {
            string path = @"C:\BridgeLabz\.Net_Fellowship\AddressBook\AddressBook\contacts.csv";
            string[] file = File.ReadAllLines(path);

            string[] array = { "First Name", "LastName", "Address", "City", "State", "Zip Code", "Phone Number", "Email" };
            foreach (string line in file)
            {
                string[] data = line.Split(",");
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine(array[i] + ": " + data[i]);
                }
                Console.WriteLine();
            }

        }
    }
}