using Phumla_Kamnandi_30.Business_layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Phumla_Kamnandi_30.Business.Role;

namespace Phumla_Kamnandi_30.Business
{
    public class Receptionist : Role
    {
        #region Data Member
        //encapsulation
        private string employeeID;
        #endregion

        #region Property Methods
        public string getEmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        #endregion

        #region Constructor
        public Receptionist() : base()
        {
            getRoleValue = RoleType.Receptionist;
            description = "Runner";
            
        }
        #endregion
    }
}
