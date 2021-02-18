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
    public partial class BookFlight : Form
    {
        public static Boolean Passport, IdCard;
        public static string firstname, lastname, todes, fromdes, VacIssue, VacLast, tvldoc, docnum, docisd, docexp, bagwght;

        

        public BookFlight()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bagweightud.Increment = 5;
            Bagweightud.ReadOnly = true;
            MainCalendar.MaxSelectionCount = 31;
            MainCalendar.ShowToday = true;
        }
        private void Passportrb_CheckedChanged(object sender, EventArgs e)
        {
            if (Passportrb.Checked)
            {
                Docnumlb.Text = "Passport Number:";
                Docissdatelb.Text = "Passport Issued Date:";
                Docexpdatelb.Text = "Passport Expiry Date:";
                Passport = true;
                IdCard = false;
            }
        }

        private void DateIssueddtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime IssuedDate = DateIssueddtp.Value;

            var Expiry = IssuedDate.AddDays(7);
            DateExpireddtp.MinDate = Expiry;
        }

        private void Idrb_CheckedChanged(object sender, EventArgs e)
        {
            if (Idrb.Checked)
            {
                Docnumlb.Text = "ID card Number:";
                Docissdatelb.Text = "ID card Issued Date:";
                Docexpdatelb.Text = "ID card Expiry Date:";
                Passport = false;
                IdCard = true;
            }
        }

        private void Bookbtn_Click(object sender, EventArgs e)
        {
            firstname = Firstnametb.Text;
            lastname = Lastnametb.Text;
            todes = Totb.Text;
            fromdes = Fromtb.Text;
            VacIssue = MainCalendar.SelectionStart.ToString("G");
            VacLast = MainCalendar.SelectionEnd.ToString("G");
            if (Passport == true)
            {
                tvldoc = Passportrb.Text;
            } 
            else
            {
                tvldoc = Idrb.Text;
            }
            docnum = Docnumtb.Text;
            docisd = DateIssueddtp.Text;
            docexp = DateExpireddtp.Text;
            bagwght = Bagweightud.Value.ToString();

            Receipt Showreceipt = new Receipt();
            Showreceipt.Show();
        }
    }
}
