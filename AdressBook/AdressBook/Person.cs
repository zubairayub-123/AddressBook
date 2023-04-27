using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string ContactNumber { get; set; }

        public Person(string firstName, string lastName, string adress, string contactNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Adress = adress;
            this.ContactNumber = contactNumber;
        }
    }
}
