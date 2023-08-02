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
using SchoolManagement.Features;

namespace SchoolManagement
{
    public partial class StudentAtten : Form
    {
        TimeSheetStudent timeSheetStudent;
        public StudentAtten(TimeSheetStudent timeSheetStudent)
        {
            InitializeComponent();
            this.timeSheetStudent = timeSheetStudent;
        }

        private void timeInStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var log = new AttenStudent() { TimeStamp = DateTime.Now, TimeShift = 0 };
                timeSheetStudent.LogStudent(identityStudentTextBox.Text, log);
                ShowMessage("Time-In successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTimeLabelStudent.Text = DateTime.Now.ToString();
        }

        private void timeOutStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var log = new AttenStudent() { TimeStamp = DateTime.Now, TimeShift = 1 };
                timeSheetStudent.LogStudent(identityStudentTextBox.Text, log);
                ShowMessage("Time-Out successfully!", true);
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
            identityStudentTextBox.Clear();
            identityStudentTextBox.Focus();
        }

    }
}
