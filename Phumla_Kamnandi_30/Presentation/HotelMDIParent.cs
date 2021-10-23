using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phumla_Kamnandi_30.Business;

namespace Phumla_Kamnandi_30.Presentation
{
    public partial class HotelMDIParent : Form
    {
        #region Variable declaration
        private int childFormNumber = 0;
        CreateBookingForm bookingForm;
        //EmployeeListingForm employeeListForm;
        BookingController bookingController;
        CreateGuestForm guestForm;
        GuestController guestController;
        

        #endregion

        public HotelMDIParent()
        {
            InitializeComponent();
        }
        #region ToolstripMenus
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        #endregion
        #region Create a New ChildForm  

        private void CreateNewBookingForm()
        {
            bookingForm = new CreateBookingForm(bookingController);
            bookingForm.MdiParent = this;
            bookingForm.StartPosition = FormStartPosition.CenterParent;
        }

        private void CreateNewGuestForm()
        {
            guestForm = new CreateGuestForm(guestController);
            guestForm.MdiParent = this;
            guestForm.StartPosition = FormStartPosition.CenterParent;
        }

        /*private void CreateNewEmployeeListForm()
        {

            employeeListForm = new EmployeeListingForm(employeeController);
            employeeListForm.MdiParent = this;
            employeeListForm.StartPosition = FormStartPosition.CenterParent;
        }*/



        #endregion
    }
}
