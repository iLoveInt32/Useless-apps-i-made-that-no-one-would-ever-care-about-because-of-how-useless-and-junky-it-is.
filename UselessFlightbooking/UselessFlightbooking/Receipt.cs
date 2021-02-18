using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UselessFlightbooking
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            BookFlight FlightBooking = new BookFlight();
            Firstname.Text = BookFlight.firstname;
            Lastname.Text = BookFlight.lastname;
            Destination.Text = BookFlight.todes;
            Departure.Text = BookFlight.fromdes;
            VDate1.Text = BookFlight.VacIssue;
            VDate2.Text = BookFlight.VacLast;
            TravlDoc.Text = BookFlight.tvldoc;
            if (BookFlight.Passport == true)
            {
                Docno.Text = "Passport no:";
                Docn.Text = BookFlight.docnum;
                Dociss.Text = "Passport Issued:";
                Doci.Text = BookFlight.docisd;
                Docexp.Text = "Passport Expiry:";
                Doce.Text = BookFlight.docexp;
            } 
            else
            {
                Docno.Text = "Id Card no:";
                Docn.Text = BookFlight.docnum;
                Dociss.Text = "Id Card Issued:";
                Doci.Text = BookFlight.docisd;
                Docexp.Text = "Id Card Expiry:";
                Doce.Text = BookFlight.docexp;
            }
            BagWeight.Text = BookFlight.bagwght;
        }
    }
}
