﻿using System;
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
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (richTextBox2.Text != richTextBox1.Text)
            {
                richTextBox2.Text = richTextBox1.Text;
            }
            else
            {
                richTextBox2.Text = "";
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
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void richTextBox20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}

