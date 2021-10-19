using Phumla_Kamnandi_30.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_30.Business_layer
{

    class Employee :Person
    {
        #region data members

        private string empID;
        private Role roleType;
        private string description;
        #endregion
        
        
        #region Constuctor
        public Employee(string employeeID) 
        {
            empID = employeeID;
        }

        #endregion

        #region Property Methods
        public string ID
        {
            get { return empID; }
            set { empID = value ;  }
        } 
        #endregion
    }
}
