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
            this.MaximizeBox = false;
            monthCalendar1.MaxSelectionCount = 1;
        }

        private void monthCalendar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
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
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program written, coded, designed, and created entirely by Garrett DeBlois; November 2017", "Info");
        }
    }
}
