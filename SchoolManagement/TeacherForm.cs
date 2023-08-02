using SchoolManagement.Entities;
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

namespace SchoolManagement
{
    public partial class TeacherForm : Form
    {
        TimeSheet timeSheet;
        public TeacherForm(TimeSheet timeSheet)
        {
            InitializeComponent();
            this.timeSheet = timeSheet;
            LoadToGrid();
            // LoadToGrid(true);

            //Disable Update Button
            updateTeacherButton.Enabled = false;
            saveTeacherButton.Enabled = false;
        }
        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            idTeacherTextBox.Clear();
            nameTeacherTextBox.Clear();
            subjectTextBox.Clear();
            salaryTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            idTeacherTextBox.Focus();
            saveTeacherButton.Enabled = true;

        }

        private void saveTeacherButton_Click(object sender, EventArgs e)
        {
            try
            {
                var tch = new Teacher()
                {
                    Id = idTeacherTextBox.Text.Trim(),
                    Name = nameTeacherTextBox.Text.Trim(),
                    Subject = subjectTextBox.Text.Trim(),
                    Saray = salaryTextBox.Text.Trim(),
                    UserAccount = new UeserAccount()
                    {
                        UserName = usernameTextBox.Text.Trim(),
                        Password = passwordTextBox.Text.Trim()
                    }
                };
                timeSheet.AddTeacher(tch);
                LoadToGrid(); //Update the gridview
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addTeacherButton.Enabled = true;
                saveTeacherButton.Enabled = false;
            }

        }
        private void LoadToGrid()
        {
            dataGridView2.DataSource = timeSheet.GetAllTeacher();
            dataGridView2.Refresh(); //show lastest data
        }
        private void LoadToGrid(bool isSimpleVersion)
        {
            dataGridView2.DataSource = timeSheet.GetAllTeacher(isSimpleVersion);
            dataGridView2.Refresh(); //show lastest data
        }


        private void updateTeacherButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheet.UpdateTeacher(idTeacherTextBox.Text, nameTeacherTextBox.Text, subjectTextBox.Text, salaryTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addTeacherButton.Enabled = true;
                saveTeacherButton.Enabled = true;
                updateTeacherButton.Enabled = false;
            }


        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows != null && dataGridView2.SelectedRows.Count > 0)
            {
                idTeacherTextBox.Text = dataGridView2.SelectedCells[0].Value.ToString();
                nameTeacherTextBox.Text = dataGridView2.SelectedCells[1].Value.ToString();
                subjectTextBox.Text = dataGridView2.SelectedCells[2].Value.ToString();
                salaryTextBox.Text = dataGridView2.SelectedCells[3].Value.ToString();
                addTeacherButton.Enabled = false;
                saveTeacherButton.Enabled = false;
                updateTeacherButton.Enabled = true;
            }

        }
    }
}
