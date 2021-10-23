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
    public partial class CreateBookingForm : Form
    {
        #region Data Members
        private Booking booking;
        private BookingController bookingController;
        public bool bookingFormClosed = false;
        
        public enum Season
        {
            low = 550,
            mid = 750,
            high = 995
        }
        protected Season price;
        protected Decimal roomPrice;




        #endregion

        #region Constructor

        public CreateBookingForm(BookingController aController)
        {
            InitializeComponent();
            bookingController = aController;
        }

        #endregion

        #region Utility Methods

        private void ClearAll()
        {
            checkInPicker.Text = "";
            checkOutPicker.Text = "";
            numRoomsCombo.Text = "";
            radLow.Checked = false;
            radMed.Checked = false;
            radHigh.Checked = false;
        }

        private void PopulateObject()
        {
            
            booking = new Booking();
          //  booking.getBookingID = idTextBox.Text;
            booking.getCheckIn = checkInPicker.Text;
            booking.getCheckOut = checkOutPicker.Text;
            booking.getNumRooms = numRoomsCombo.Text;
            
            

            
        }

        #endregion


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtGuestID_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxGuest_Enter(object sender, EventArgs e)
        {

        }

        private void lblGuestID_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void v_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateNewGuest_Click(object sender, EventArgs e)
        {

        }

        private void gbxBooking_Enter(object sender, EventArgs e)
        {

        }

        private void txtCheckIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCheckOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumRooms_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitBooking_Click(object sender, EventArgs e)
        {

        }
        #region Radio Buttons
        private void radLow_CheckedChanged(object sender, EventArgs e)
        {
            if (radLow != null)
            {
                /* If the call has been triggered by the radio button (i.e sender) , 
                then check if the radio button is checked and execute the appropriate code */
                if (radLow.Checked)
                {
                    price = CreateBookingForm.Season.low;
                    roomPrice = decimal.Parse(price);
                    
                }
            }
        }

        private void radMed_CheckedChanged(object sender, EventArgs e)
        {
            if (radMed != null)
            {
                /* If the call has been triggered by the radio button (i.e sender) , 
                then check if the radio button is checked and execute the appropriate code */
                if (radMed.Checked)
                {
                    price = CreateBookingForm.Season.mid;
                    roomPrice = decimal.Parse(price);
                    
                }
            }
        }

        private void radHigh_CheckedChanged(object sender, EventArgs e)
        {
            if (radHigh != null)
            {
                /* If the call has been triggered by the radio button (i.e sender) , 
                then check if the radio button is checked and execute the appropriate code */
                if (radHigh.Checked)
                {
                    price = CreateBookingForm.Season.high;
                    roomPrice = decimal.Parse(price);
                    
                }
            }
        }
        #endregion



        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numRoomsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateBookingForm_Load(object sender, EventArgs e)
        {

        }

        private void lblCheckIn_Click(object sender, EventArgs e)
        {

        }

        private void lblNumRooms_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            bookingFormClosed = true;
            Close();
        }
    }
}
