using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTFFCPartyScheduler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            monthCalendar1.MaxSelectionCount = 1;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Schedule Party for " + monthCalendar1.SelectionRange.Start.DayOfWeek.ToString() + ", " + monthCalendar1.SelectionRange.Start.ToShortDateString() + "?", "Schedule Party?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form2 f2 = new Form2();
                f2.day = monthCalendar1.SelectionRange.Start.DayOfWeek.ToString();
                f2.date = monthCalendar1.SelectionRange.Start.ToShortDateString();
                f2.Show();
                f2.Text = "Parties for: " + monthCalendar1.SelectionRange.Start.ToShortDateString() + " (" + monthCalendar1.SelectionRange.Start.DayOfWeek.ToString() + ")";
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing (yet)
            }
        }
    }
}
