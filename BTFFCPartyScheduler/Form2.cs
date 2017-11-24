using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net; //for networkcredential part of email code
using System.Net.Mail; //for email capabilities
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //for Streamreader and Streamwriter

namespace BTFFCPartyScheduler
{
    public partial class Form2 : Form
    {
        bool getInitialData = true; //use this to pull the information from the text files when this form is opened for the first time
        public string day; //getting the day of the week from the calendar selection
        public string date; //getting the date of the week from the calendar selection
        public string finalDate; //used for getting the date
        public string filePath; //used for getting setting the file path       
        public string lastName1; // used for printing the peron's last name from textbox1     
        public string lastName2;
        public string lastName3;
        public string lastName4;
        public string lastName5;
        public string lastName6;
        public string lastName7;
        public string lastName8;
        public string lastName9;
        public string lastName10;
        public string lastName11;
        public string lastName12;
        public string lastName13;
        public string lastName14;
        public string lastName15;
        public string lastName16;
        public string lastName17;
        public string lastName18;
        public string lastName19;
        public string lastName20;
        List<string> nameSplit1 = new List<string>();//used for printing
        List<string> nameSplit2 = new List<string>();
        List<string> nameSplit3 = new List<string>();
        List<string> nameSplit4 = new List<string>();
        List<string> nameSplit5 = new List<string>();
        List<string> nameSplit6 = new List<string>();
        List<string> nameSplit7 = new List<string>();
        List<string> nameSplit8 = new List<string>();
        List<string> nameSplit9 = new List<string>();
        List<string> nameSplit10 = new List<string>();
        List<string> nameSplit11 = new List<string>();
        List<string> nameSplit12 = new List<string>();
        List<string> nameSplit13 = new List<string>();
        List<string> nameSplit14 = new List<string>();
        List<string> nameSplit15 = new List<string>();
        List<string> nameSplit16 = new List<string>();
        List<string> nameSplit17 = new List<string>();
        List<string> nameSplit18 = new List<string>();
        List<string> nameSplit19 = new List<string>();
        List<string> nameSplit20 = new List<string>();

        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            U1Taken.Visible = false;
            U2Taken.Visible = false;
            U3Taken.Visible = false;
            U4Taken.Visible = false;
            U5Taken.Visible = false;
            U6Taken.Visible = false;
            U7Taken.Visible = false;
            U8Taken.Visible = false;
            U9Taken.Visible = false;
            U10Taken.Visible = false;
            U11Taken.Visible = false;
            U12Taken.Visible = false;
            G1Taken.Visible = false;
            G2Taken.Visible = false;
            G3Taken.Visible = false;
            G4Taken.Visible = false;
            G5Taken.Visible = false;
            G6Taken.Visible = false;
            R1Taken.Visible = false;
            R2Taken.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label21.Text = day;
            label22.Text = date;
            timer1.Start();
            timer2.Start();
            //these combo boxes are for the package type and for the time
            comboBox1.Items.AddRange(new string[] { "A", "B" });
            comboBox2.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox3.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox4.Items.AddRange(new string[] { "A", "B" });
            comboBox5.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox6.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox7.Items.AddRange(new string[] { "A", "B" });
            comboBox8.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox9.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox10.Items.AddRange(new string[] { "A", "B" });
            comboBox11.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox12.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox13.Items.AddRange(new string[] { "A", "B" });
            comboBox14.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox15.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox16.Items.AddRange(new string[] { "A", "B" });
            comboBox17.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox18.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox19.Items.AddRange(new string[] { "A", "B" });
            comboBox20.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox21.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox22.Items.AddRange(new string[] { "A", "B" });
            comboBox23.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox24.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox25.Items.AddRange(new string[] { "A", "B" });
            comboBox26.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox27.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox28.Items.AddRange(new string[] { "A", "B" });
            comboBox29.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox30.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox31.Items.AddRange(new string[] { "A", "B" });
            comboBox32.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox33.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox34.Items.AddRange(new string[] { "A", "B" });
            comboBox35.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox36.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox37.Items.AddRange(new string[] { "A", "B" });
            comboBox38.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox39.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox40.Items.AddRange(new string[] { "A", "B" });
            comboBox41.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox42.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox43.Items.AddRange(new string[] { "A", "B" });
            comboBox44.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox45.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox46.Items.AddRange(new string[] { "A", "B" });
            comboBox47.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox48.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox49.Items.AddRange(new string[] { "A", "B" });
            comboBox50.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox51.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox52.Items.AddRange(new string[] { "A", "B" });
            comboBox53.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox54.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox55.Items.AddRange(new string[] { "A", "B" });
            comboBox56.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox57.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
            comboBox58.Items.AddRange(new string[] { "A", "B" });
            comboBox59.Items.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox60.Items.AddRange(new string[] { "00", "5", "10", "15", "20", "25", "30", "35", "40", "45", "50", "55" });
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //check boxes to copy text
        {
            if (richTextBox2.Text != richTextBox1.Text)
            {
                richTextBox2.Text = richTextBox1.Text;
            }
            else
            {
                richTextBox2.Text = "";
            }
            if (comboBox1.SelectedItem != comboBox4.SelectedItem) //to copy the package type
            {
                comboBox4.SelectedItem = comboBox1.SelectedItem;
            }
            else
            {
                comboBox4.SelectedItem = null;
            }
            if (comboBox2.SelectedItem != comboBox5.SelectedItem) //hour combobox
            {
                comboBox5.SelectedItem = comboBox2.SelectedItem;
            }
            else
            {
                comboBox5.SelectedItem = null;
            }
            if (comboBox3.SelectedItem != comboBox6.SelectedItem) //minute combobox
            {
                comboBox6.SelectedItem = comboBox3.SelectedItem;
            }
            else
            {
                comboBox6.SelectedItem = null;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox3.Text != richTextBox2.Text)
            {
                richTextBox3.Text = richTextBox2.Text;
            }
            else
            {
                richTextBox3.Text = "";
            }
            if (comboBox4.SelectedItem != comboBox7.SelectedItem)
            {
                comboBox7.SelectedItem = comboBox4.SelectedItem;
            }
            else
            {
                comboBox7.SelectedItem = null;
            }
            if (comboBox5.SelectedItem != comboBox8.SelectedItem)
            {
                comboBox8.SelectedItem = comboBox5.SelectedItem;
            }
            else
            {
                comboBox8.SelectedItem = null;
            }
            if (comboBox6.SelectedItem != comboBox9.SelectedItem)
            {
                comboBox9.SelectedItem = comboBox6.SelectedItem;
            }
            else
            {
                comboBox9.SelectedItem = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox4.Text != richTextBox3.Text)
            {
                richTextBox4.Text = richTextBox3.Text;
            }
            else
            {
                richTextBox4.Text = "";
            }
            if (comboBox7.SelectedItem != comboBox10.SelectedItem)
            {
                comboBox10.SelectedItem = comboBox7.SelectedItem;
            }
            else
            {
                comboBox10.SelectedItem = null;
            }
            if (comboBox8.SelectedItem != comboBox11.SelectedItem)
            {
                comboBox11.SelectedItem = comboBox8.SelectedItem;
            }
            else
            {
                comboBox11.SelectedItem = null;
            }
            if (comboBox9.SelectedItem != comboBox12.SelectedItem)
            {
                comboBox12.SelectedItem = comboBox9.SelectedItem;
            }
            else
            {
                comboBox12.SelectedItem = null;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox5.Text != richTextBox4.Text)
            {
                richTextBox5.Text = richTextBox4.Text;
            }
            else
            {
                richTextBox5.Text = "";
            }
            if (comboBox10.SelectedItem != comboBox13.SelectedItem)
            {
                comboBox13.SelectedItem = comboBox10.SelectedItem;
            }
            else
            {
                comboBox13.SelectedItem = null;
            }
            if (comboBox11.SelectedItem != comboBox14.SelectedItem)
            {
                comboBox14.SelectedItem = comboBox11.SelectedItem;
            }
            else
            {
                comboBox14.SelectedItem = null;
            }
            if (comboBox12.SelectedItem != comboBox15.SelectedItem)
            {
                comboBox15.SelectedItem = comboBox12.SelectedItem;
            }
            else
            {
                comboBox15.SelectedItem = null;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox6.Text != richTextBox5.Text)
            {
                richTextBox6.Text = richTextBox5.Text;
            }
            else
            {
                richTextBox6.Text = "";
            }
            if (comboBox13.SelectedItem != comboBox16.SelectedItem)
            {
                comboBox16.SelectedItem = comboBox13.SelectedItem;
            }
            else
            {
                comboBox16.SelectedItem = null;
            }
            if (comboBox14.SelectedItem != comboBox17.SelectedItem)
            {
                comboBox17.SelectedItem = comboBox14.SelectedItem;
            }
            else
            {
                comboBox17.SelectedItem = null;
            }
            if (comboBox15.SelectedItem != comboBox18.SelectedItem)
            {
                comboBox18.SelectedItem = comboBox15.SelectedItem;
            }
            else
            {
                comboBox18.SelectedItem = null;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox7.Text != richTextBox6.Text)
            {
                richTextBox7.Text = richTextBox6.Text;
            }
            else
            {
                richTextBox7.Text = "";
            }
            if (comboBox16.SelectedItem != comboBox19.SelectedItem)
            {
                comboBox19.SelectedItem = comboBox16.SelectedItem;
            }
            else
            {
                comboBox19.SelectedItem = null;
            }
            if (comboBox17.SelectedItem != comboBox20.SelectedItem)
            {
                comboBox20.SelectedItem = comboBox17.SelectedItem;
            }
            else
            {
                comboBox20.SelectedItem = null;
            }
            if (comboBox18.SelectedItem != comboBox21.SelectedItem)
            {
                comboBox21.SelectedItem = comboBox18.SelectedItem;
            }
            else
            {
                comboBox21.SelectedItem = null;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox8.Text != richTextBox7.Text)
            {
                richTextBox8.Text = richTextBox7.Text;
            }
            else
            {
                richTextBox8.Text = "";
            }
            if (comboBox19.SelectedItem != comboBox22.SelectedItem)
            {
                comboBox22.SelectedItem = comboBox19.SelectedItem;
            }
            else
            {
                comboBox22.SelectedItem = null;
            }
            if (comboBox20.SelectedItem != comboBox23.SelectedItem)
            {
                comboBox23.SelectedItem = comboBox20.SelectedItem;
            }
            else
            {
                comboBox23.SelectedItem = null;
            }
            if (comboBox21.SelectedItem != comboBox24.SelectedItem)
            {
                comboBox24.SelectedItem = comboBox21.SelectedItem;
            }
            else
            {
                comboBox24.SelectedItem = null;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox9.Text != richTextBox8.Text)
            {
                richTextBox9.Text = richTextBox8.Text;
            }
            else
            {
                richTextBox9.Text = "";
            }
            if (comboBox22.SelectedItem != comboBox25.SelectedItem)
            {
                comboBox25.SelectedItem = comboBox22.SelectedItem;
            }
            else
            {
                comboBox25.SelectedItem = null;
            }
            if (comboBox23.SelectedItem != comboBox26.SelectedItem)
            {
                comboBox26.SelectedItem = comboBox23.SelectedItem;
            }
            else
            {
                comboBox26.SelectedItem = null;
            }
            if (comboBox24.SelectedItem != comboBox27.SelectedItem)
            {
                comboBox27.SelectedItem = comboBox24.SelectedItem;
            }
            else
            {
                comboBox27.SelectedItem = null;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox10.Text != richTextBox9.Text)
            {
                richTextBox10.Text = richTextBox9.Text;
            }
            else
            {
                richTextBox10.Text = "";
            }
            if (comboBox25.SelectedItem != comboBox28.SelectedItem)
            {
                comboBox28.SelectedItem = comboBox25.SelectedItem;
            }
            else
            {
                comboBox28.SelectedItem = null;
            }
            if (comboBox26.SelectedItem != comboBox29.SelectedItem)
            {
                comboBox29.SelectedItem = comboBox26.SelectedItem;
            }
            else
            {
                comboBox29.SelectedItem = null;
            }
            if (comboBox27.SelectedItem != comboBox30.SelectedItem)
            {
                comboBox30.SelectedItem = comboBox27.SelectedItem;
            }
            else
            {
                comboBox30.SelectedItem = null;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox11.Text != richTextBox10.Text)
            {
                richTextBox11.Text = richTextBox10.Text;
            }
            else
            {
                richTextBox11.Text = "";
            }
            if (comboBox28.SelectedItem != comboBox31.SelectedItem)
            {
                comboBox31.SelectedItem = comboBox28.SelectedItem;
            }
            else
            {
                comboBox31.SelectedItem = null;
            }
            if (comboBox29.SelectedItem != comboBox32.SelectedItem)
            {
                comboBox32.SelectedItem = comboBox29.SelectedItem;
            }
            else
            {
                comboBox32.SelectedItem = null;
            }
            if (comboBox30.SelectedItem != comboBox33.SelectedItem)
            {
                comboBox33.SelectedItem = comboBox30.SelectedItem;
            }
            else
            {
                comboBox33.SelectedItem = null;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox12.Text != richTextBox11.Text)
            {
                richTextBox12.Text = richTextBox11.Text;
            }
            else
            {
                richTextBox12.Text = "";
            }
            if (comboBox31.SelectedItem != comboBox34.SelectedItem)
            {
                comboBox34.SelectedItem = comboBox31.SelectedItem;
            }
            else
            {
                comboBox34.SelectedItem = null;
            }
            if (comboBox32.SelectedItem != comboBox35.SelectedItem)
            {
                comboBox35.SelectedItem = comboBox32.SelectedItem;
            }
            else
            {
                comboBox35.SelectedItem = null;
            }
            if (comboBox33.SelectedItem != comboBox36.SelectedItem)
            {
                comboBox36.SelectedItem = comboBox33.SelectedItem;
            }
            else
            {
                comboBox36.SelectedItem = null;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox13.Text != richTextBox12.Text)
            {
                richTextBox13.Text = richTextBox12.Text;
            }
            else
            {
                richTextBox13.Text = "";
            }
            if (comboBox34.SelectedItem != comboBox37.SelectedItem)
            {
                comboBox37.SelectedItem = comboBox34.SelectedItem;
            }
            else
            {
                comboBox37.SelectedItem = null;
            }
            if (comboBox35.SelectedItem != comboBox38.SelectedItem)
            {
                comboBox38.SelectedItem = comboBox35.SelectedItem;
            }
            else
            {
                comboBox38.SelectedItem = null;
            }
            if (comboBox36.SelectedItem != comboBox39.SelectedItem)
            {
                comboBox39.SelectedItem = comboBox36.SelectedItem;
            }
            else
            {
                comboBox39.SelectedItem = null;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox14.Text != richTextBox13.Text)
            {
                richTextBox14.Text = richTextBox13.Text;
            }
            else
            {
                richTextBox14.Text = "";
            }
            if (comboBox37.SelectedItem != comboBox40.SelectedItem)
            {
                comboBox40.SelectedItem = comboBox37.SelectedItem;
            }
            else
            {
                comboBox40.SelectedItem = null;
            }
            if (comboBox38.SelectedItem != comboBox41.SelectedItem)
            {
                comboBox41.SelectedItem = comboBox38.SelectedItem;
            }
            else
            {
                comboBox41.SelectedItem = null;
            }
            if (comboBox39.SelectedItem != comboBox42.SelectedItem)
            {
                comboBox42.SelectedItem = comboBox39.SelectedItem;
            }
            else
            {
                comboBox42.SelectedItem = null;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox15.Text != richTextBox14.Text)
            {
                richTextBox15.Text = richTextBox14.Text;
            }
            else
            {
                richTextBox15.Text = "";
            }
            if (comboBox40.SelectedItem != comboBox43.SelectedItem)
            {
                comboBox43.SelectedItem = comboBox40.SelectedItem;
            }
            else
            {
                comboBox43.SelectedItem = null;
            }
            if (comboBox41.SelectedItem != comboBox44.SelectedItem)
            {
                comboBox44.SelectedItem = comboBox41.SelectedItem;
            }
            else
            {
                comboBox44.SelectedItem = null;
            }
            if (comboBox42.SelectedItem != comboBox45.SelectedItem)
            {
                comboBox45.SelectedItem = comboBox42.SelectedItem;
            }
            else
            {
                comboBox45.SelectedItem = null;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox16.Text != richTextBox15.Text)
            {
                richTextBox16.Text = richTextBox15.Text;
            }
            else
            {
                richTextBox16.Text = "";
            }
            if (comboBox43.SelectedItem != comboBox46.SelectedItem)
            {
                comboBox46.SelectedItem = comboBox43.SelectedItem;
            }
            else
            {
                comboBox46.SelectedItem = null;
            }
            if (comboBox44.SelectedItem != comboBox47.SelectedItem)
            {
                comboBox47.SelectedItem = comboBox44.SelectedItem;
            }
            else
            {
                comboBox47.SelectedItem = null;
            }
            if (comboBox45.SelectedItem != comboBox48.SelectedItem)
            {
                comboBox48.SelectedItem = comboBox45.SelectedItem;
            }
            else
            {
                comboBox48.SelectedItem = null;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox17.Text != richTextBox16.Text)
            {
                richTextBox17.Text = richTextBox16.Text;
            }
            else
            {
                richTextBox17.Text = "";
            }
            if (comboBox46.SelectedItem != comboBox49.SelectedItem)
            {
                comboBox49.SelectedItem = comboBox46.SelectedItem;
            }
            else
            {
                comboBox49.SelectedItem = null;
            }
            if (comboBox47.SelectedItem != comboBox50.SelectedItem)
            {
                comboBox50.SelectedItem = comboBox47.SelectedItem;
            }
            else
            {
                comboBox50.SelectedItem = null;
            }
            if (comboBox48.SelectedItem != comboBox51.SelectedItem)
            {
                comboBox51.SelectedItem = comboBox48.SelectedItem;
            }
            else
            {
                comboBox51.SelectedItem = null;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox18.Text != richTextBox17.Text)
            {
                richTextBox18.Text = richTextBox17.Text;
            }
            else
            {
                richTextBox18.Text = "";
            }
            if (comboBox49.SelectedItem != comboBox58.SelectedItem)
            {
                comboBox58.SelectedItem = comboBox49.SelectedItem;
            }
            else
            {
                comboBox58.SelectedItem = null;
            }
            if (comboBox50.SelectedItem != comboBox59.SelectedItem)
            {
                comboBox59.SelectedItem = comboBox50.SelectedItem;
            }
            else
            {
                comboBox59.SelectedItem = null;
            }
            if (comboBox51.SelectedItem != comboBox60.SelectedItem)
            {
                comboBox60.SelectedItem = comboBox51.SelectedItem;
            }
            else
            {
                comboBox60.SelectedItem = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //gets whether or not the text box has text or is empty or only has white spaces
            bool box1HasText = string.IsNullOrWhiteSpace(richTextBox1.Text);
            bool box2HasText = string.IsNullOrWhiteSpace(richTextBox2.Text);
            bool box3HasText = string.IsNullOrWhiteSpace(richTextBox3.Text);
            bool box4HasText = string.IsNullOrWhiteSpace(richTextBox4.Text);
            bool box5HasText = string.IsNullOrWhiteSpace(richTextBox5.Text);
            bool box6HasText = string.IsNullOrWhiteSpace(richTextBox6.Text);
            bool box7HasText = string.IsNullOrWhiteSpace(richTextBox7.Text);
            bool box8HasText = string.IsNullOrWhiteSpace(richTextBox8.Text);
            bool box9HasText = string.IsNullOrWhiteSpace(richTextBox9.Text);
            bool box10HasText = string.IsNullOrWhiteSpace(richTextBox10.Text);
            bool box11HasText = string.IsNullOrWhiteSpace(richTextBox11.Text);
            bool box12HasText = string.IsNullOrWhiteSpace(richTextBox12.Text);
            bool box13HasText = string.IsNullOrWhiteSpace(richTextBox13.Text);
            bool box14HasText = string.IsNullOrWhiteSpace(richTextBox14.Text);
            bool box15HasText = string.IsNullOrWhiteSpace(richTextBox15.Text);
            bool box16HasText = string.IsNullOrWhiteSpace(richTextBox16.Text);
            bool box17HasText = string.IsNullOrWhiteSpace(richTextBox17.Text);
            bool box18HasText = string.IsNullOrWhiteSpace(richTextBox18.Text);
            bool box19HasText = string.IsNullOrWhiteSpace(richTextBox19.Text);
            bool box20HasText = string.IsNullOrWhiteSpace(richTextBox20.Text);

            //hides the areas on the picture which have already been taken
            if (box1HasText == false)
            {
                U1Taken.Visible = true;
            }
            if (box2HasText == false)
            {
                U2Taken.Visible = true;
            }
            if (box3HasText == false)
            {
                U3Taken.Visible = true;
            }
            if (box4HasText == false)
            {
                U4Taken.Visible = true;
            }
            if (box5HasText == false)
            {
                U5Taken.Visible = true;
            }
            if (box6HasText == false)
            {
                U6Taken.Visible = true;
            }
            if (box7HasText == false)
            {
                U7Taken.Visible = true;
            }
            if (box8HasText == false)
            {
                U8Taken.Visible = true;
            }
            if (box9HasText == false)
            {
                U9Taken.Visible = true;
            }
            if (box10HasText == false)
            {
                U10Taken.Visible = true;
            }
            if (box11HasText == false)
            {
                U11Taken.Visible = true;
            }
            if (box12HasText == false)
            {
                U12Taken.Visible = true;
            }
            if (box13HasText == false)
            {
                G1Taken.Visible = true;
            }
            if (box14HasText == false)
            {
                G2Taken.Visible = true;
            }
            if (box15HasText == false)
            {
                G3Taken.Visible = true;
            }
            if (box16HasText == false)
            {
                G4Taken.Visible = true;
            }
            if (box17HasText == false)
            {
                G5Taken.Visible = true;
            }
            if (box18HasText == false)
            {
                G6Taken.Visible = true;
            }
            if (box19HasText == false)
            {
                R1Taken.Visible = true;
            }
            if (box20HasText == false)
            {
                R2Taken.Visible = true;
            }

            //reverse (to show boxes again if user deletes text from textbox)
            if (box1HasText == true)
            {
                U1Taken.Visible = false;
            }
            if (box2HasText == true)
            {
                U2Taken.Visible = false;
            }
            if (box3HasText == true)
            {
                U3Taken.Visible = false;
            }
            if (box4HasText == true)
            {
                U4Taken.Visible = false;
            }
            if (box5HasText == true)
            {
                U5Taken.Visible = false;
            }
            if (box6HasText == true)
            {
                U6Taken.Visible = false;
            }
            if (box7HasText == true)
            {
                U7Taken.Visible = false;
            }
            if (box8HasText == true)
            {
                U8Taken.Visible = false;
            }
            if (box9HasText == true)
            {
                U9Taken.Visible = false;
            }
            if (box10HasText == true)
            {
                U10Taken.Visible = false;
            }
            if (box11HasText == true)
            {
                U11Taken.Visible = false;
            }
            if (box12HasText == true)
            {
                U12Taken.Visible = false;
            }
            if (box13HasText == true)
            {
                G1Taken.Visible = false;
            }
            if (box14HasText == true)
            {
                G2Taken.Visible = false;
            }
            if (box15HasText == true)
            {
                G3Taken.Visible = false;
            }
            if (box16HasText == true)
            {
                G4Taken.Visible = false;
            }
            if (box17HasText == true)
            {
                G5Taken.Visible = false;
            }
            if (box18HasText == true)
            {
                G6Taken.Visible = false;
            }
            if (box19HasText == true)
            {
                R1Taken.Visible = false;
            }
            if (box20HasText == true)
            {
                R2Taken.Visible = false;
            }
        }

        static void lineRewriter(string newText, string fileName, int line_to_edit) //using this function to write to a specific line in the text file
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            finalDate = date.Replace('/', '-');  //replace the "/" with "-" because the first symbol is not allowed in the name of items in Windows
            filePath = "C:/Program Files/BTFFCPartyProgram/PartyData/" + finalDate + ".txt"; //path to my text files that i plan to save to            

            //save to the text files here, naming the text files based on the date selected, seperating each text box by a new line

            if (File.Exists(filePath))   // if exists then read from the file and put into the textboxes
            {
                if (getInitialData == true) //if this is true then this form needs to read from the text file to get the textbox data
                {
                    string GetLine(string fileName, int line)
                    {
                        using (var sr = new StreamReader(fileName))
                        {
                            for (int i = 1; i < line; i++)
                                sr.ReadLine();
                            return sr.ReadLine();
                        }
                    }

                    richTextBox1.Text = GetLine(filePath, 1);
                    richTextBox2.Text = GetLine(filePath, 2);
                    richTextBox3.Text = GetLine(filePath, 3);
                    richTextBox4.Text = GetLine(filePath, 4);
                    richTextBox5.Text = GetLine(filePath, 5);
                    richTextBox6.Text = GetLine(filePath, 6);
                    richTextBox7.Text = GetLine(filePath, 7);
                    richTextBox8.Text = GetLine(filePath, 8);
                    richTextBox9.Text = GetLine(filePath, 9);
                    richTextBox10.Text = GetLine(filePath, 10);
                    richTextBox11.Text = GetLine(filePath, 11);
                    richTextBox12.Text = GetLine(filePath, 12);
                    richTextBox13.Text = GetLine(filePath, 13);
                    richTextBox14.Text = GetLine(filePath, 14);
                    richTextBox15.Text = GetLine(filePath, 15);
                    richTextBox16.Text = GetLine(filePath, 16);
                    richTextBox17.Text = GetLine(filePath, 17);
                    richTextBox18.Text = GetLine(filePath, 18);
                    richTextBox19.Text = GetLine(filePath, 19);
                    richTextBox20.Text = GetLine(filePath, 20);
                    getInitialData = false;
                }

                lineRewriter(richTextBox1.Text, filePath, 1);
                lineRewriter(richTextBox2.Text, filePath, 2);
                lineRewriter(richTextBox3.Text, filePath, 3);
                lineRewriter(richTextBox4.Text, filePath, 4);
                lineRewriter(richTextBox5.Text, filePath, 5);
                lineRewriter(richTextBox6.Text, filePath, 6);
                lineRewriter(richTextBox7.Text, filePath, 7);
                lineRewriter(richTextBox8.Text, filePath, 8);
                lineRewriter(richTextBox9.Text, filePath, 9);
                lineRewriter(richTextBox10.Text, filePath, 10);
                lineRewriter(richTextBox11.Text, filePath, 11);
                lineRewriter(richTextBox12.Text, filePath, 12);
                lineRewriter(richTextBox13.Text, filePath, 13);
                lineRewriter(richTextBox14.Text, filePath, 14);
                lineRewriter(richTextBox15.Text, filePath, 15);
                lineRewriter(richTextBox16.Text, filePath, 16);
                lineRewriter(richTextBox17.Text, filePath, 17);
                lineRewriter(richTextBox18.Text, filePath, 18);
                lineRewriter(richTextBox19.Text, filePath, 19);
                lineRewriter(richTextBox20.Text, filePath, 20);
            }
            else
            {
                StreamWriter write = new StreamWriter(filePath); //this creates the new file if it doesn't already exist, requires admin permission to write to this folder -> need to run program as administrator
                write.Close();
                for (int i = 0; i < 25; i++)
                {
                    File.AppendAllText(filePath, Environment.NewLine); //add the lines to the textfile so that the array index is not out of range
                }
            }
        }

        //this section of code below is to make the user unable to use the enter key on any of the text boxes.
        //the enter key interferes with how I read the information from the text files since I treat each new line in the text file as a new text box on the form
        // pressing the enter key would mess that up and cut off any text after the enter key was pressed

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            "); // Users can't press enter because new lines are how I separate the next text box from the previous text box when reading from the text files that I use to save this program in. With this code, I use the enter key to enter a lot of spaces that take them to the next line in the application's text box and not interfere with my previous code to distinguish between the text boxes.
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("                                                            ");
                e.SuppressKeyPress = true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, e.PageBounds);
        }

        Bitmap bmp;

        private void button1_Click(object sender, EventArgs e) //code for print this page button
        {
            printDocument1.DefaultPageSettings.Landscape = true; ; //changing the picture to print in landscape
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            ((Form)printPreviewDialog1).Text = "Form Print Preview " + date;
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized; //maximize the print preview form
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) //preview party table button
        {
            bool box1HasText = string.IsNullOrWhiteSpace(richTextBox1.Text); //if it has text, then false
            if (box1HasText == false)
            {
                try //see if there is a last name
                {
                    nameSplit1 = richTextBox1.Text.Split(' ').ToList<string>();
                    lastName1 = nameSplit1[1].ToUpper(); //takes last name and puts it in all caps                   
                    printPreviewDialog2.Document = printDocument2;
                    ((Form)printPreviewDialog2).Text = "Table U1 Print Preview " + date; //change the title of the print preview form
                    ((Form)printPreviewDialog2).WindowState = FormWindowState.Maximized; //maximize the print preview form
                    if (printPreviewDialog2.ShowDialog() == DialogResult.OK)
                    {
                        printDocument2.Print();
                    }
                }
                catch //if there is no last name, throw this error
                {
                    MessageBox.Show("Please enter a last name into box U1", "Error");
                }
            }
            bool box2HasText = string.IsNullOrWhiteSpace(richTextBox2.Text); //if it has text, then false
            if (box2HasText == false)
            {
                try
                {
                    nameSplit2 = richTextBox2.Text.Split(' ').ToList<string>();
                    lastName2 = nameSplit2[1].ToUpper();
                    printPreviewDialog3.Document = printDocument3;
                    ((Form)printPreviewDialog3).Text = "Table U2 Print Preview " + date;
                    ((Form)printPreviewDialog3).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog3.ShowDialog() == DialogResult.OK)
                    {
                        printDocument3.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U2", "Error");
                }
            }
            bool box3HasText = string.IsNullOrWhiteSpace(richTextBox3.Text); //if it has text, then false
            if (box3HasText == false)
            {
                try
                {
                    nameSplit3 = richTextBox3.Text.Split(' ').ToList<string>();
                    lastName3 = nameSplit3[1].ToUpper();
                    printPreviewDialog4.Document = printDocument4;
                    ((Form)printPreviewDialog4).Text = "Table U3 Print Preview " + date;
                    ((Form)printPreviewDialog4).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog4.ShowDialog() == DialogResult.OK)
                    {
                        printDocument4.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U3", "Error");
                }
            }
            bool box4HasText = string.IsNullOrWhiteSpace(richTextBox4.Text); //if it has text, then false
            if (box4HasText == false)
            {
                try
                {
                    nameSplit4 = richTextBox4.Text.Split(' ').ToList<string>();
                    lastName4 = nameSplit4[1].ToUpper();
                    printPreviewDialog5.Document = printDocument5;
                    ((Form)printPreviewDialog5).Text = "Table U4 Print Preview " + date;
                    ((Form)printPreviewDialog5).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog5.ShowDialog() == DialogResult.OK)
                    {
                        printDocument5.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U4", "Error");
                }
            }
            bool box5HasText = string.IsNullOrWhiteSpace(richTextBox5.Text); //if it has text, then false
            if (box5HasText == false)
            {
                try
                {
                    nameSplit5 = richTextBox5.Text.Split(' ').ToList<string>();
                    lastName5 = nameSplit5[1].ToUpper();
                    printPreviewDialog6.Document = printDocument6;
                    ((Form)printPreviewDialog6).Text = "Table U5 Print Preview " + date;
                    ((Form)printPreviewDialog6).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog6.ShowDialog() == DialogResult.OK)
                    {
                        printDocument6.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U5", "Error");
                }
            }
            bool box6HasText = string.IsNullOrWhiteSpace(richTextBox6.Text); //if it has text, then false
            if (box6HasText == false)
            {
                try
                {
                    nameSplit6 = richTextBox6.Text.Split(' ').ToList<string>();
                    lastName6 = nameSplit6[1].ToUpper();
                    printPreviewDialog7.Document = printDocument7;
                    ((Form)printPreviewDialog7).Text = "Table U6 Print Preview " + date;
                    ((Form)printPreviewDialog7).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog7.ShowDialog() == DialogResult.OK)
                    {
                        printDocument7.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U6", "Error");
                }
            }
            bool box7HasText = string.IsNullOrWhiteSpace(richTextBox7.Text); //if it has text, then false
            if (box7HasText == false)
            {
                try
                {
                    nameSplit7 = richTextBox7.Text.Split(' ').ToList<string>();
                    lastName7 = nameSplit7[1].ToUpper();
                    printPreviewDialog8.Document = printDocument8;
                    ((Form)printPreviewDialog8).Text = "Table U7 Print Preview " + date;
                    ((Form)printPreviewDialog8).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog8.ShowDialog() == DialogResult.OK)
                    {
                        printDocument8.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U7", "Error");
                }
            }
            bool box8HasText = string.IsNullOrWhiteSpace(richTextBox8.Text); //if it has text, then false
            if (box8HasText == false)
            {
                try
                {
                    nameSplit8 = richTextBox8.Text.Split(' ').ToList<string>();
                    lastName8 = nameSplit8[1].ToUpper();
                    printPreviewDialog9.Document = printDocument9;
                    ((Form)printPreviewDialog9).Text = "Table U8 Print Preview " + date;
                    ((Form)printPreviewDialog9).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog9.ShowDialog() == DialogResult.OK)
                    {
                        printDocument9.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U8", "Error");
                }
            }
            bool box9HasText = string.IsNullOrWhiteSpace(richTextBox9.Text); //if it has text, then false
            if (box9HasText == false)
            {
                try
                {
                    nameSplit9 = richTextBox9.Text.Split(' ').ToList<string>();
                    lastName9 = nameSplit9[1].ToUpper();
                    printPreviewDialog10.Document = printDocument10;
                    ((Form)printPreviewDialog10).Text = "Table U9 Print Preview " + date;
                    ((Form)printPreviewDialog10).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog10.ShowDialog() == DialogResult.OK)
                    {
                        printDocument10.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U9", "Error");
                }
            }
            bool box10HasText = string.IsNullOrWhiteSpace(richTextBox10.Text); //if it has text, then false
            if (box10HasText == false)
            {
                try
                {
                    nameSplit10 = richTextBox10.Text.Split(' ').ToList<string>();
                    lastName10 = nameSplit10[1].ToUpper();
                    printPreviewDialog11.Document = printDocument11;
                    ((Form)printPreviewDialog11).Text = "Table U10 Print Preview " + date;
                    ((Form)printPreviewDialog11).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog11.ShowDialog() == DialogResult.OK)
                    {
                        printDocument11.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U10", "Error");
                }
            }
            bool box11HasText = string.IsNullOrWhiteSpace(richTextBox11.Text); //if it has text, then false
            if (box11HasText == false)
            {
                try
                {
                    nameSplit11 = richTextBox11.Text.Split(' ').ToList<string>();
                    lastName11 = nameSplit11[1].ToUpper();
                    printPreviewDialog12.Document = printDocument12;
                    ((Form)printPreviewDialog12).Text = "Table U11 Print Preview " + date;
                    ((Form)printPreviewDialog12).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog12.ShowDialog() == DialogResult.OK)
                    {
                        printDocument12.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U11", "Error");
                }
            }
            bool box12HasText = string.IsNullOrWhiteSpace(richTextBox12.Text); //if it has text, then false
            if (box12HasText == false)
            {
                try
                {
                    nameSplit12 = richTextBox12.Text.Split(' ').ToList<string>();
                    lastName12 = nameSplit12[1].ToUpper();
                    printPreviewDialog13.Document = printDocument13;
                    ((Form)printPreviewDialog13).Text = "Table U12 Print Preview " + date;
                    ((Form)printPreviewDialog13).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog13.ShowDialog() == DialogResult.OK)
                    {
                        printDocument13.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U12", "Error");
                }
            }
            bool box13HasText = string.IsNullOrWhiteSpace(richTextBox13.Text); //if it has text, then false
            if (box13HasText == false)
            {
                try
                {
                    nameSplit13 = richTextBox13.Text.Split(' ').ToList<string>();
                    lastName13 = nameSplit13[1].ToUpper();
                    printPreviewDialog14.Document = printDocument14;
                    ((Form)printPreviewDialog14).Text = "Table G1 Print Preview " + date;
                    ((Form)printPreviewDialog14).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog14.ShowDialog() == DialogResult.OK)
                    {
                        printDocument14.Print();//the next few pages will need to print twice
                        printDocument14.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box G1", "Error");
                }
            }
            bool box14HasText = string.IsNullOrWhiteSpace(richTextBox14.Text); //if it has text, then false
            if (box14HasText == false)
            {
                try
                {
                    nameSplit14 = richTextBox14.Text.Split(' ').ToList<string>();
                    lastName14 = nameSplit14[1].ToUpper();
                    printPreviewDialog15.Document = printDocument15;
                    ((Form)printPreviewDialog15).Text = "Table G2 Print Preview " + date;
                    ((Form)printPreviewDialog15).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog15.ShowDialog() == DialogResult.OK)
                    {
                        printDocument15.Print();
                        printDocument15.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box G2", "Error");
                }
            }
            bool box15HasText = string.IsNullOrWhiteSpace(richTextBox15.Text); //if it has text, then false
            if (box15HasText == false)
            {
                try
                {
                    nameSplit15 = richTextBox15.Text.Split(' ').ToList<string>();
                    lastName15 = nameSplit15[1].ToUpper();
                    printPreviewDialog16.Document = printDocument16;
                    ((Form)printPreviewDialog16).Text = "Table G3 Print Preview " + date;
                    ((Form)printPreviewDialog16).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog16.ShowDialog() == DialogResult.OK)
                    {
                        printDocument16.Print();
                        printDocument16.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box G3", "Error");
                }
            }
            bool box16HasText = string.IsNullOrWhiteSpace(richTextBox16.Text); //if it has text, then false
            if (box16HasText == false)
            {
                try
                {
                    nameSplit16 = richTextBox16.Text.Split(' ').ToList<string>();
                    lastName16 = nameSplit16[1].ToUpper();
                    printPreviewDialog17.Document = printDocument17;
                    ((Form)printPreviewDialog17).Text = "Table G4 Print Preview " + date;
                    ((Form)printPreviewDialog17).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog17.ShowDialog() == DialogResult.OK)
                    {
                        printDocument17.Print();
                        printDocument17.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box G4", "Error");
                }
            }
            bool box17HasText = string.IsNullOrWhiteSpace(richTextBox17.Text); //if it has text, then false
            if (box17HasText == false)
            {
                try
                {
                    nameSplit17 = richTextBox17.Text.Split(' ').ToList<string>();
                    lastName17 = nameSplit17[1].ToUpper();
                    printPreviewDialog18.Document = printDocument18;
                    ((Form)printPreviewDialog18).Text = "Table G5 Print Preview " + date;
                    ((Form)printPreviewDialog18).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog18.ShowDialog() == DialogResult.OK)
                    {
                        printDocument18.Print();
                        printDocument18.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box G5", "Error");
                }
            }
            bool box18HasText = string.IsNullOrWhiteSpace(richTextBox18.Text); //if it has text, then false
            if (box18HasText == false)
            {
                try
                {
                    nameSplit18 = richTextBox18.Text.Split(' ').ToList<string>();
                    lastName18 = nameSplit18[1].ToUpper();
                    printPreviewDialog19.Document = printDocument19;
                    ((Form)printPreviewDialog19).Text = "Table G6 Print Preview " + date;
                    ((Form)printPreviewDialog19).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog19.ShowDialog() == DialogResult.OK)
                    {
                        printDocument19.Print();
                        printDocument19.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box G6", "Error");
                }
            }
            bool box19HasText = string.IsNullOrWhiteSpace(richTextBox19.Text); //if it has text, then false
            if (box19HasText == false)
            {
                try
                {
                    nameSplit19 = richTextBox19.Text.Split(' ').ToList<string>();
                    lastName19 = nameSplit19[1].ToUpper();
                    printPreviewDialog20.Document = printDocument20;
                    ((Form)printPreviewDialog20).Text = "Table R1 Print Preview " + date;
                    ((Form)printPreviewDialog20).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog20.ShowDialog() == DialogResult.OK)
                    {
                        printDocument20.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box R1", "Error");
                }
            }
            bool box20HasText = string.IsNullOrWhiteSpace(richTextBox20.Text); //if it has text, then false
            if (box20HasText == false)
            {
                try
                {
                    nameSplit20 = richTextBox20.Text.Split(' ').ToList<string>();
                    lastName20 = nameSplit20[1].ToUpper();
                    printPreviewDialog21.Document = printDocument21;
                    ((Form)printPreviewDialog21).Text = "Table R2 Print Preview " + date;
                    ((Form)printPreviewDialog21).WindowState = FormWindowState.Maximized;
                    if (printPreviewDialog21.ShowDialog() == DialogResult.OK)
                    {
                        printDocument21.Print();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box R2", "Error");
                }
            }
        }

        Font font1 = new Font("Times New Roman", 110, FontStyle.Bold);
        Font font2 = new Font("Times New Roman", 50, FontStyle.Bold);
        Font font3 = new Font("Times New Roman", 64, FontStyle.Bold);

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName1, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName1, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName2, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName2, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 850);
        }

        private void printDocument4_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName3, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName3, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument5_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName4, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName4, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument6_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName5, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName5, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument7_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName6, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName6, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument8_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName7, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName7, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument9_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName8, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName8, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument10_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName9, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName9, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument11_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName10, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName10, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument12_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName11, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName11, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument13_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName12, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName12, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument14_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName13, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName13, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument15_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName14, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName14, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument16_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName15, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName15, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument17_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName16, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName16, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument18_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName17, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName17, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument19_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName18, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName18, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument20_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName19, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName19, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void printDocument21_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Reserved", font1, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString("Reserved", font1).Width / 2, 75);
            e.Graphics.DrawString(lastName20, font2, Brushes.Black, e.PageBounds.Width / 2 - e.Graphics.MeasureString(lastName20, font2).Width / 2, 500);
            e.Graphics.DrawString(date, font3, Brushes.Black, 425, 900);
        }

        private void button3_Click(object sender, EventArgs e) //print all party table papers button
        {
            bool box1HasText = string.IsNullOrWhiteSpace(richTextBox1.Text); //if it has text, then false
            if (box1HasText == false)
            {
                try //see if there is a last name
                {
                    nameSplit1 = richTextBox1.Text.Split(' ').ToList<string>();
                    lastName1 = nameSplit1[1].ToUpper(); //makes the last name all caps
                    printPreviewDialog2.Document = printDocument2;
                    printDocument2.Print();

                }
                catch //if there is no last name, throw this error
                {
                    MessageBox.Show("Please enter a last name into box U1", "Error");
                }
            }
            bool box2HasText = string.IsNullOrWhiteSpace(richTextBox2.Text); //if it has text, then false
            if (box2HasText == false)
            {
                try
                {
                    nameSplit2 = richTextBox2.Text.Split(' ').ToList<string>();
                    lastName2 = nameSplit2[1].ToUpper();
                    printPreviewDialog3.Document = printDocument3;
                    printDocument3.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U2", "Error");
                }
            }
            bool box3HasText = string.IsNullOrWhiteSpace(richTextBox3.Text); //if it has text, then false
            if (box3HasText == false)
            {
                try
                {
                    nameSplit3 = richTextBox3.Text.Split(' ').ToList<string>();
                    lastName3 = nameSplit3[1].ToUpper();
                    printPreviewDialog4.Document = printDocument4;
                    printDocument4.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U3", "Error");
                }
            }
            bool box4HasText = string.IsNullOrWhiteSpace(richTextBox4.Text); //if it has text, then false
            if (box4HasText == false)
            {
                try
                {
                    nameSplit4 = richTextBox4.Text.Split(' ').ToList<string>();
                    lastName4 = nameSplit4[1].ToUpper();
                    printPreviewDialog5.Document = printDocument5;
                    printDocument5.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U4", "Error");
                }
            }
            bool box5HasText = string.IsNullOrWhiteSpace(richTextBox5.Text); //if it has text, then false
            if (box5HasText == false)
            {
                try
                {
                    nameSplit5 = richTextBox5.Text.Split(' ').ToList<string>();
                    lastName5 = nameSplit5[1].ToUpper();
                    printPreviewDialog6.Document = printDocument6;
                    printDocument6.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U5", "Error");
                }
            }
            bool box6HasText = string.IsNullOrWhiteSpace(richTextBox6.Text); //if it has text, then false
            if (box6HasText == false)
            {
                try
                {
                    nameSplit6 = richTextBox6.Text.Split(' ').ToList<string>();
                    lastName6 = nameSplit6[1].ToUpper();
                    printPreviewDialog7.Document = printDocument7;
                    printDocument7.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U6", "Error");
                }
            }
            bool box7HasText = string.IsNullOrWhiteSpace(richTextBox7.Text); //if it has text, then false
            if (box7HasText == false)
            {
                try
                {
                    nameSplit7 = richTextBox7.Text.Split(' ').ToList<string>();
                    lastName7 = nameSplit7[1].ToUpper();
                    printPreviewDialog8.Document = printDocument8;
                    printDocument8.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U7", "Error");
                }
            }
            bool box8HasText = string.IsNullOrWhiteSpace(richTextBox8.Text); //if it has text, then false
            if (box8HasText == false)
            {
                try
                {
                    nameSplit8 = richTextBox8.Text.Split(' ').ToList<string>();
                    lastName8 = nameSplit8[1].ToUpper();
                    printPreviewDialog9.Document = printDocument9;
                    printDocument9.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U8", "Error");
                }
            }
            bool box9HasText = string.IsNullOrWhiteSpace(richTextBox9.Text); //if it has text, then false
            if (box9HasText == false)
            {
                try
                {
                    nameSplit9 = richTextBox9.Text.Split(' ').ToList<string>();
                    lastName9 = nameSplit9[1].ToUpper();
                    printPreviewDialog10.Document = printDocument10;
                    printDocument10.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U9", "Error");
                }
            }
            bool box10HasText = string.IsNullOrWhiteSpace(richTextBox10.Text); //if it has text, then false
            if (box10HasText == false)
            {
                try
                {
                    nameSplit10 = richTextBox10.Text.Split(' ').ToList<string>();
                    lastName10 = nameSplit10[1].ToUpper();
                    printPreviewDialog11.Document = printDocument11;
                    printDocument11.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U10", "Error");
                }
            }
            bool box11HasText = string.IsNullOrWhiteSpace(richTextBox11.Text); //if it has text, then false
            if (box11HasText == false)
            {
                try
                {
                    nameSplit11 = richTextBox11.Text.Split(' ').ToList<string>();
                    lastName11 = nameSplit11[1].ToUpper();
                    printPreviewDialog12.Document = printDocument12;
                    printDocument12.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U11", "Error");
                }
            }
            bool box12HasText = string.IsNullOrWhiteSpace(richTextBox12.Text); //if it has text, then false
            if (box12HasText == false)
            {
                try
                {
                    nameSplit12 = richTextBox12.Text.Split(' ').ToList<string>();
                    lastName12 = nameSplit12[1].ToUpper();
                    printPreviewDialog13.Document = printDocument13;
                    printDocument13.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box U12", "Error");
                }
            }
            bool box13HasText = string.IsNullOrWhiteSpace(richTextBox13.Text); //if it has text, then false
            if (box13HasText == false)
            {
                try
                {
                    nameSplit13 = richTextBox13.Text.Split(' ').ToList<string>();
                    lastName13 = nameSplit13[1].ToUpper();
                    printPreviewDialog14.Document = printDocument14;
                    printDocument14.Print();
                    printDocument14.Print();//the next few pages will need to print twice
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box G1", "Error");
                }
            }
            bool box14HasText = string.IsNullOrWhiteSpace(richTextBox14.Text); //if it has text, then false
            if (box14HasText == false)
            {
                try
                {
                    nameSplit14 = richTextBox14.Text.Split(' ').ToList<string>();
                    lastName14 = nameSplit14[1].ToUpper();
                    printPreviewDialog15.Document = printDocument15;
                    printDocument15.Print();
                    printDocument15.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box G2", "Error");
                }
            }
            bool box15HasText = string.IsNullOrWhiteSpace(richTextBox15.Text); //if it has text, then false
            if (box15HasText == false)
            {
                try
                {
                    nameSplit15 = richTextBox15.Text.Split(' ').ToList<string>();
                    lastName15 = nameSplit15[1].ToUpper();
                    printPreviewDialog16.Document = printDocument16;
                    printDocument16.Print();
                    printDocument16.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box G3", "Error");
                }
            }
            bool box16HasText = string.IsNullOrWhiteSpace(richTextBox16.Text); //if it has text, then false
            if (box16HasText == false)
            {
                try
                {
                    nameSplit16 = richTextBox16.Text.Split(' ').ToList<string>();
                    lastName16 = nameSplit16[1].ToUpper();
                    printPreviewDialog17.Document = printDocument17;
                    printDocument17.Print();
                    printDocument17.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box G4", "Error");
                }
            }
            bool box17HasText = string.IsNullOrWhiteSpace(richTextBox17.Text); //if it has text, then false
            if (box17HasText == false)
            {
                try
                {
                    nameSplit17 = richTextBox17.Text.Split(' ').ToList<string>();
                    lastName17 = nameSplit17[1].ToUpper();
                    printPreviewDialog18.Document = printDocument18;
                    printDocument18.Print();
                    printDocument18.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box G5", "Error");
                }
            }
            bool box18HasText = string.IsNullOrWhiteSpace(richTextBox18.Text); //if it has text, then false
            if (box18HasText == false)
            {
                try
                {
                    nameSplit18 = richTextBox18.Text.Split(' ').ToList<string>();
                    lastName18 = nameSplit18[1].ToUpper();
                    printPreviewDialog19.Document = printDocument19;
                    printDocument19.Print();
                    printDocument19.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box G6", "Error");
                }
            }
            bool box19HasText = string.IsNullOrWhiteSpace(richTextBox19.Text); //if it has text, then false
            if (box19HasText == false)
            {
                try
                {
                    nameSplit19 = richTextBox19.Text.Split(' ').ToList<string>();
                    lastName19 = nameSplit19[1].ToUpper();
                    printPreviewDialog20.Document = printDocument20;
                    printDocument20.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box R1", "Error");
                }
            }
            bool box20HasText = string.IsNullOrWhiteSpace(richTextBox20.Text); //if it has text, then false
            if (box20HasText == false)
            {
                try
                {
                    nameSplit20 = richTextBox20.Text.Split(' ').ToList<string>();
                    lastName20 = nameSplit20[1].ToUpper();
                    printPreviewDialog21.Document = printDocument21;
                    printDocument21.Print();
                }
                catch
                {
                    MessageBox.Show("Please enter a last name into box R2", "Error");
                }
            }
        }
    }
}

