using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_30
{
    public class Person
    {
        //Create an abstract Person base class with an ID, Name and Phone. 
        //Include a default and a parametrised constructor. 
        //Add a ToString method to this class to allow you to display the details of a person.
        //This base class will enable you to easily expand the system to include customer bookings at a later stage.   

        #region data members
        private string Id, name, Phone, address;
        #endregion

        #region Properties
        public string getID
        {
            get { return Id; }
            set { Id = value; }
        }

        public string getName
        {
            get { return name; }
            set { name = value; }
        }
        public string getPhone
        {
            get { return Phone; }
            set { Phone = value; }
        }

        public string getAddress
        {
            get { return address; }
            set { address = value; }
        }
        #endregion

        #region Construtor
        public Person()
        {
            Id = "";
            name = "";
            Phone = "";
            address = "";
        }

        public Person(string pID, string pName, string pPhone, string pAddress)
        {
            Id = pID;
            name = pName;
            Phone = pPhone;
            address = pAddress;
        }
        #endregion

        #region ToStringMethod
        public override string ToString()
        {
            return name + '\n' + Phone;
        }

        #endregion
    }
}

