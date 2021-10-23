using Phumla_Kamnandi_30.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_30.Presentation
{
    public partial class CreateGuestForm : Form
    {
        GuestController guestController;
        public bool guestFormClosed = false;
        private Guest guest;
        public CreateGuestForm(GuestController aContoller)
        {
            InitializeComponent();
            guestController = aContoller;

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
