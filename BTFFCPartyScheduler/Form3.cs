﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;
using System.Net; //for networkcredential part of email code
using System.Net.Mail; //for email capabilities

namespace BTFFCPartyScheduler
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string emailRecipient;//target email address to send the emails to

        private void button1_Click(object sender, EventArgs e)
        {           
            using (ZipFile zip = new ZipFile(""))
            {
                emailRecipient = richTextBox1.Text;
                zip.AddDirectory("C:/Program Files/BTFFCPartyProgram/PartyData", "PartyData");   //this is where the files that are put into the new zip file come from         
                zip.Save("C:/Program Files/BTFFCPartyProgram/PartyData.zip"); //this is where the zip file saves to

                string emailSubject = "BTFFC Party Scheduler Program"; //use this to get the teacher name so that it will be included in the subject field of the email          
                MailMessage email = new MailMessage("gdcs480project@gmail.com", emailRecipient, emailSubject, "This is a link to download the Bonne Terre Family Fun Center Party Scheduling Program: https://drive.google.com/open?id=1n4EjyIMyhW9X3ID4WkTFhRo3juaEICi8" + "\n\nClick the link and right click on the folder and click download. After that, right click on the file below it and download it too. The file is a shortcut, \"BTFFCPartyScheduler Shortcut\" and you can place it on your desktop.\nGoing back to the email, the attached file below on the left is a file containing all the party data which has all the dates and other information that has been entered into this program. You will need to open the file and drag the \"PartyData\" file to the C:/Program Files/BTFFCPartyProgram folder. This is the folder you just downloaded. This folder will first need to be placed under the C drive, once you are on the C drive, go to Program Files, once you are in the Program Files folder, copy and paste the \"BTFFCPartyProgram\" folder that you downloaded first. After, place the \"PartyData\" file in the \"BTFFCPartyProgram\" folder. That will allow this new computer to have all the updated party data.\n\nFor computers using an operating system newer than Windows XP, one final thing needs to be done for this program to work properly. You will need to go to the shortcut you put on your desktop (it has the bowling pin icon) and right click it, click \"Open File Location.\" That will take you to the folder you just downloaded and placed in Program Files. Right click the icon that has the bowling pin in this folder (it should already be selected) and click properties. After that, go to the \"Compatibility\" tab and then click the checkbox next to \"Run this program as an administrator\" and then click OK at the bottom of the window. You are done, you can close everything and use the shortcut from your desktop every time you want to open the program. Without that \"Run this program as an administrator\" option being selected, this program will not have the ability to save to the Program Files folder. It will get denied access and crash the program. No action is needed on Windows XP. Windows Vista, Windows 7, Windows 8, Windows 8.1, and Windows 10 all require this extra step."); //originating email address, target email address, email subject field, email body field
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.UseDefaultCredentials = false;
                NetworkCredential nc = new NetworkCredential("gdcs480project@gmail.com", "randomp455w0rd123!"); //username and password to the account that the emails originate from 
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                Attachment attachment = new Attachment("C:/Program Files/BTFFCPartyProgram/PartyData.zip"); //attaching the zip data file to email 
                email.Attachments.Add(attachment);

                try
                {
                    smtp.Send(email); //code to send the email, if it is successful, the message directly below is displayed, else the catch statement goes into effect and that code is executed
                    MessageBox.Show("Email sent successfully.", "Success");
                }
                catch (System.Net.Mail.SmtpException)
                {
                    MessageBox.Show("Email could not be sent. Please check the email address.", "Error");
                }
            }
        }
    }
}

