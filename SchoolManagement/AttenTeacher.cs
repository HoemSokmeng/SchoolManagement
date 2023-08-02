using SchoolManagement.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Entities;

namespace SchoolManagement
{
    public partial class AttenTeacher : Form
    {
        TimeSheet timeSheet;
        public AttenTeacher(TimeSheet timeSheet)
        {
            InitializeComponent();
            this.timeSheet = timeSheet;
        }

        private void timeInButton_Click(object sender, EventArgs e)
        {
            try
            {
                var atten = new Log() { TimeStamp = DateTime.Now, TimeShift = 0 };
                timeSheet.LogTeacher(idTeacherTextBox.Text, atten);
                ShowMessage("Time-in Successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString();
        }

        private void timeOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                var atten = new Log() { TimeStamp = DateTime.Now, TimeShift = 1 };
                timeSheet.LogTeacher(idTeacherTextBox.Text, atten);
                ShowMessage("Time-Out Successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }

        }
        private void ShowMessage(string message, bool show)
        {
            if (show)
            {
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            idTeacherTextBox.Clear();
            idTeacherTextBox.Focus();
        }

    }
}
