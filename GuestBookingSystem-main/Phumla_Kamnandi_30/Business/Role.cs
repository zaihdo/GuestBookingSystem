using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phumla_Kamnandi_30.Business
{
    public class Role
    {

        #region Data Member
        public enum RoleType
        {

            NoRole = 0,
            Receptionist = 1
        }
        protected RoleType roleVal;
        protected string description;

        #endregion

        #region Property Methods
        public RoleType getRoleValue
        {
            get { return roleVal; }
            set { roleVal = value; }
        }
        public string getDescription
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region Constructor

        public Role()
        {
            roleVal = Role.RoleType.NoRole;
            description = "No role";
        }
        #endregion

        #region Methods

        public virtual decimal Payment()
        {
            /*Include an overridable method Payment() which is to return the salary.
            * For now the method will return 0;       */
            return 0;
        }

        public virtual decimal Payment(decimal percentage)
        {
            /*Include another overridable method Payment() which takes in an argument
             and returns the salary. */
            return 0;
        }

        #endregion
    }
}
