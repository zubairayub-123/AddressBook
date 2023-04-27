using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    class AdressBook
    {
        private List<Person> adressBookList = new List<Person>();
        public List<Person> AdressBookList
        {
            get { return adressBookList; }
            set { this.adressBookList = value; }
        }
        public List<Person> FavGroup = new List<Person>();
        public List<Person> GenGroup = new List<Person>();

        public AdressBook()
        {
            AdressBookList = new List<Person>();
           
        }

        public void export()
        {
            
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();
            string og = @"C:\Users\Administrator\source\repos\AdressBook\" + fileName;

            try
            {
               // FileStream aFile = new FileStream(og, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(og);
                foreach (Person p in AdressBookList)
                {
                    writer.WriteLine(p.FirstName + ":" + p.Adress);
                }
                writer.Close();
                Console.WriteLine("The file has been successfully created");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            /*foreach(var con in contacts)
            {
                Console.WriteLine(con.Name + " "+ con.PhoneNumber);
            }*/
        }







        // Create instance of Person-class and call AddPersonToList-method
        public void CreateUser()
        {
            Console.WriteLine("Enter firstName:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter lastName:");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter adress:");
            var adress = Console.ReadLine();

            Console.WriteLine("Enter Contact Number:");
            var contactNumber = Console.ReadLine();

            



            Person person = new Person(firstName, lastName, adress, contactNumber);
            AddPersonToList(person);
            

        }

        public void Group()
        {
            Console.WriteLine("In Which Group you want to add 1- Fav, 2-General");
            var ans = Console.ReadLine();
            Console.WriteLine("Enter which User to be added to group");
            string name2 = Console.ReadLine();
            Person name11 = AdressBookList.Find(f => f.FirstName == name2 || f.ContactNumber == name2);

            if (ans == "1") 
            {
                 FavGroup.Add(name11);
            }
            else if(ans == "2") 
            {
                GenGroup.Add(name11);
            }
            

        }
        public void ShowAllPersonsInFavGroup()
        {
            foreach (var person in FavGroup)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, Adress: {2},Contact Number: {3}", person.FirstName, person.LastName, person.Adress,person.ContactNumber);
            }
        }
        public void ShowAllPersonsInGenGroup()
        {
            foreach (var person in GenGroup)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, Adress: {2},Contact Number: {3}", person.FirstName, person.LastName, person.Adress, person.ContactNumber);
            }
        }

        // Add new person to AdressBookList
        private void AddPersonToList(Person person) => AdressBookList.Add(person);

        public void SearchPersonFromList()
        {
            Console.WriteLine("Enter first name to search ");
           string  name = Console.ReadLine();
            Person name1 = AdressBookList.Find(f => f.FirstName == name || f.ContactNumber == name);

          if(name1 == null) 
            {
                Console.WriteLine("not found");
            }
            else
            {
                Console.WriteLine("First Name {0}, Last Name {1}, Address{2}",name1.FirstName,name1.LastName,name1.Adress);
            } 
        }

        //Remove user from list where first and last name match
        public void RemovePersonFromList()
        {
            Console.WriteLine("Enter firstName of the user you want to remove");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter lastname of the user you want to remove");
            var lastName = Console.ReadLine();

            AdressBookList.RemoveAll(item => item.FirstName == firstName && item.LastName == lastName);
           
        }

        //Show all Persons in AdressBookList
        public void ShowAllPersonsInList()
        {
            foreach (var person in AdressBookList)
            {
                Console.WriteLine("FirstName: {0}, LastName: {1}, Adress: {2}", person.FirstName, person.LastName, person.Adress);
            }
        }

        public void UpdateUserInformation()
        {
            Console.WriteLine("Which information do you want to update?");
            Console.WriteLine("#1: Firstname, #2: Lastname, 3# Adress");
            var userOption = Console.ReadLine();

            Console.WriteLine("Enter firstname on existing user to be updated");
            var oldFirstName = Console.ReadLine();
            UpdateUserFunction(userOption, oldFirstName);
        }

        private void UpdateUserFunction(string userOption, string oldFirstName)
        {
            var personsWithMatchingFirstName = AdressBookList.Where(person => person.FirstName == oldFirstName);
            string newValue;

            if (userOption == "1")
            {
                Console.WriteLine("Enter a new first Name");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.FirstName = newValue;
                   
                }
            }
            else if (userOption == "2")
            {
                Console.WriteLine("Enter a new last name");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.LastName = newValue;
                   
                }
            }
            else if (userOption == "3")
            {
                Console.WriteLine("Enter a new adress");
                newValue = Console.ReadLine();

                foreach (var person in personsWithMatchingFirstName)
                {
                    person.Adress = newValue;
                    
                }
            }
        }
    }
}
