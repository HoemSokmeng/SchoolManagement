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
    public partial class StudentForm : Form
    {
        TimeSheetStudent timeSheetStudent;
        public StudentForm(TimeSheetStudent timeSheetStudent)
        {
            InitializeComponent();
            this.timeSheetStudent = timeSheetStudent;
            LoadToGrid();
            // LoadToGrid(true);

            //Disable Update Button
            updateStudentButton.Enabled = false;
            saveStudentButton.Enabled = false;
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            identityStudentTextBox.Clear();
            nameStudentTextBox.Clear();
            sexStudentTextBox.Clear();
            departmentStudentTextBox.Clear();
            identityStudentTextBox.Focus();
            saveStudentButton.Enabled = true;

        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var std = new Student()
                {
                    Id = identityStudentTextBox.Text.Trim(),
                    Name = nameStudentTextBox.Text.Trim(),
                    Sex = sexStudentTextBox.Text.Trim(),
                    Department = departmentStudentTextBox.Text.Trim()
                };
                timeSheetStudent.AddStudent(std);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addStudentButton.Enabled = true;
                saveStudentButton.Enabled = false;
            }
        }
        private void LoadToGrid()
        {
            dataGridView1.DataSource = timeSheetStudent.GetAllStudent();
            dataGridView1.Refresh(); //show lastest data
        }
        private void LoadToGrid(bool isSimpleVersion)
        {
            dataGridView1.DataSource = timeSheetStudent.GetAllStudent(isSimpleVersion);
            dataGridView1.Refresh(); //show lastest data
        }

        private void updataStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheetStudent.UpdateStudent(identityStudentTextBox.Text, nameStudentTextBox.Text, sexStudentTextBox.Text,
                    departmentStudentTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addStudentButton.Enabled = true;
                saveStudentButton.Enabled = true;
                updateStudentButton.Enabled = false;
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                identityStudentTextBox.Text = dataGridView1.SelectedCells[0].Value.ToString();
                nameStudentTextBox.Text = dataGridView1.SelectedCells[1].Value.ToString();
                sexStudentTextBox.Text = dataGridView1.SelectedCells[2].Value.ToString();
                departmentStudentTextBox.Text = dataGridView1.SelectedCells[3].Value.ToString();
                addStudentButton.Enabled = false;
                saveStudentButton.Enabled = false;
                updateStudentButton.Enabled = true;
            }

        }
    }
}
