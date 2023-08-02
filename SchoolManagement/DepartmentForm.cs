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
    public partial class DepartmentForm : Form
    {
        TimeSheetDepartment timeSheetDepartment;
        public DepartmentForm(TimeSheetDepartment timeSheetDepartment)
        {
            InitializeComponent();
            this.timeSheetDepartment = timeSheetDepartment;
            LoadToGrid();
            // LoadToGrid(true);

            //Disable Update Button
            updateDepartmentButton.Enabled = false;
            saveDepartmentButton.Enabled = false;
        }

        private void addNewDepartmentButton_Click(object sender, EventArgs e)
        {
            idDepartmentTextBox.Clear();
            nameDepartmentTextBox.Clear();
            managerDepartmentTextBox.Clear();
            priceDepartmentTextBox.Clear();
            idDepartmentTextBox.Focus();
            saveDepartmentButton.Enabled = true;
        }

        private void saveDepartmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var dpt = new Department()
                {
                    Id = idDepartmentTextBox.Text.Trim(),
                    DptName = nameDepartmentTextBox.Text.Trim(),
                    DptManager = managerDepartmentTextBox.Text.Trim(),
                    DptPrice = priceDepartmentTextBox.Text.Trim()
                };
                timeSheetDepartment.AddDepartment(dpt);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addNewDepartmentButton.Enabled = true;
                saveDepartmentButton.Enabled = false;
            }
        }
        private void LoadToGrid()
        {
            dpt_DataGridView.DataSource = timeSheetDepartment.GetAllDepartment();
            dpt_DataGridView.Refresh(); //show lastest data
        }
        private void LoadToGrid(bool isSimpleVersion)
        {

            dpt_DataGridView.DataSource = timeSheetDepartment.GetAllDepartment(isSimpleVersion);
            dpt_DataGridView.Refresh(); //show lastest data
        }

        private void updateDepartmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheetDepartment.UpdateDepartment(idDepartmentTextBox.Text, nameDepartmentTextBox.Text, managerDepartmentTextBox.Text,
                                                     priceDepartmentTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addNewDepartmentButton.Enabled = true;
                saveDepartmentButton.Enabled = true;
                updateDepartmentButton.Enabled = false;
            }
        }

        private void dpt_DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(dpt_DataGridView.SelectedRows != null && dpt_DataGridView.SelectedRows.Count > 0)
            {
                idDepartmentTextBox.Text = dpt_DataGridView.SelectedCells[0].Value.ToString();
                nameDepartmentTextBox.Text = dpt_DataGridView.SelectedCells[1].Value.ToString();
                managerDepartmentTextBox.Text = dpt_DataGridView.SelectedCells[2].Value.ToString();
                priceDepartmentTextBox.Text = dpt_DataGridView.SelectedCells[3].Value.ToString();
                addNewDepartmentButton.Enabled = false;
                saveDepartmentButton.Enabled = false;
                updateDepartmentButton.Enabled = true;
            }
        }
    }
}
