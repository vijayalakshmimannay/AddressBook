namespace Addressbook
{
    internal class person
    {
        public static void creatcontact()
        {

            Contacts contact = new Contacts();
            Console.WriteLine("Enter first name: ");
            contact.fName = Console.ReadLine();

            Console.WriteLine("Enter lastname name: ");
            contact.lName = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            contact.address = Console.ReadLine();

            Console.WriteLine("Enter phone Number: ");
            contact.phoneNo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter city: ");
            contact.city = Console.ReadLine();


            Console.WriteLine("Enter zip: ");
            contact.zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter state: ");
            contact.state = Console.ReadLine();

            Console.WriteLine("Enter email: ");
            contact.email = Console.ReadLine();

            program.person.Add(contact);
        }
    }
}