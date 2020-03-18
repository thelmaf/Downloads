using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager9012402
{
    public class Contact
    {
        private int contactID; // field
        public int ContactID //property
        {
            get { return contactID; } //get method
            set { contactID = value; } //set method
        }

        private string firstName; // field
        public string FirstName //property
        {
            get { return firstName; } //get method
            set { firstName = value; } //set method
        }

        private string lastName; // field
        public string LastName //property
        {
            get { return lastName; } //get method
            set { lastName = value; } //set method
        }

        private string emailAddress; // field
        public string EmailAddress //property
        {
            get { return emailAddress; } //get method
            set { emailAddress = value; } //set method
        }

        private string homeAddress; // field
        public string HomeAddress //property
        {
            get { return homeAddress; } //get method
            set { homeAddress = value; } //set method
        }

        private int homeTel; // field
        public int HomeTel //property
        {
            get { return homeTel; } //get method
            set { homeTel = value; } //set method
        }

    }
}

