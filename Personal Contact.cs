using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager9012402
{
    class Personal_Contact:Contact
    {
        private string contactHomeTel; // field
        public string ContactHomeTel //property
        {
            get { return contactHomeTel; } //get method
            set { contactHomeTel = value; } //set method
        }
    }
}
