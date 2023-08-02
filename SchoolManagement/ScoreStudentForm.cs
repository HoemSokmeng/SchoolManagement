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
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace SchoolManagement
{
    public partial class ScoreStudentForm : Form
    {
        CalculateScore calculateScore;
        public ScoreStudentForm(CalculateScore calculateScore)
        {
            InitializeComponent();
            this.calculateScore = calculateScore;
            LoadToGrid();
            // LoadToGrid(true);

            //Disable Update Button
            updateScoreButton.Enabled = false;
            saveScoreButton.Enabled = false;
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            idScoreStudentTextBox.Clear();
            nameScoreStudentTextBox.Clear();
            pythonTextBox.Clear();
            javaTextBox.Clear();
            cshapTextBox.Clear();
            bigDataTextBox.Clear();
            englishTextBox.Clear();
            idScoreStudentTextBox.Focus();
            saveScoreButton.Enabled = true;
        }

        private void saveScoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                var Sstd = new ScoreStudent()
                {
                    Id = idScoreStudentTextBox.Text.Trim(),
                    Name = nameScoreStudentTextBox.Text.Trim(),
                    Python = Double.Parse(pythonTextBox.Text.Trim()),
                    Java = Double.Parse(javaTextBox.Text.Trim()),
                    CShap = Double.Parse(cshapTextBox.Text.Trim()),
                    BigData = Double.Parse(bigDataTextBox.Text.Trim()),
                    English = Double.Parse(englishTextBox.Text.Trim()),
                };

                Double Python = Double.Parse(pythonTextBox.Text.Trim());
                Double Java = Double.Parse(javaTextBox.Text.Trim());
                Double Cshap = Double.Parse(javaTextBox.Text.Trim());
                Double BigData = Double.Parse(bigDataTextBox.Text.Trim());
                Double Enlish = Double.Parse(englishTextBox.Text.Trim());

                Sstd.Total = Python + Java + Cshap + BigData + Enlish;
                Sstd.average = Sstd.Total / 5;

                Sstd.Grade =$"{Sstd.average switch
                {
                    >= 90 => Sstd.Grade = "A",
                    >= 80 => Sstd.Grade = "B",
                    >= 70 => Sstd.Grade = "C",
                    >= 60 => Sstd.Grade = "D",
                    >= 50 => Sstd.Grade = "E",
                    _ => Sstd.Grade = "F",
                }}";

                string lTotal = Sstd.Total.ToString();
                string lAverage = Sstd.average.ToString();
                string lGrage = Sstd.Grade.ToString();
                totalLable.Text = lTotal;
                lableAverage.Text = lAverage;
                gradeLable.Text = lGrage;
                calculateScore.AddScoreStudent(Sstd);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addNewButton.Enabled = true;
                saveScoreButton.Enabled = false;
            }
        }

        private void updateScoreButton_Click(object sender, EventArgs e)
        {
            try
            {
                calculateScore.UpdateScoreStudent(idScoreStudentTextBox.Text, pythonTextBox.Text, javaTextBox.Text,
                    cshapTextBox.Text, bigDataTextBox.Text, englishTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addNewButton.Enabled = true;
                saveScoreButton.Enabled = true;
                updateScoreButton.Enabled = false;
            }
        }
        private void LoadToGrid()
        {
            scoreStudentDataGridView.DataSource = calculateScore.GetAllScoreStudent();
            scoreStudentDataGridView.Refresh(); //show lastest data
        }
        private void LoadToGrid(bool isSimpleVersion)
        {
            scoreStudentDataGridView.DataSource = calculateScore.GetAllScoreStudent(isSimpleVersion);
            scoreStudentDataGridView.Refresh(); //show lastest data
        }

        private void closeScoreButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure wish to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void scoreStudentDataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (scoreStudentDataGridView.SelectedRows != null && scoreStudentDataGridView.SelectedRows.Count > 0)
            {
                idScoreStudentTextBox.Text = scoreStudentDataGridView.SelectedCells[0].Value.ToString();
                nameScoreStudentTextBox.Text = scoreStudentDataGridView.SelectedCells[1].Value.ToString();
                pythonTextBox.Text = scoreStudentDataGridView.SelectedCells[2].Value.ToString();
                javaTextBox.Text = scoreStudentDataGridView.SelectedCells[3].Value.ToString();
                cshapTextBox.Text = scoreStudentDataGridView.SelectedCells[4].Value.ToString();
                bigDataTextBox.Text = scoreStudentDataGridView.SelectedCells[5].Value.ToString();
                englishTextBox.Text = scoreStudentDataGridView.SelectedCells[6].Value.ToString();
                totalLable.Text = scoreStudentDataGridView.SelectedCells[7].Value.ToString();
                lableAverage.Text = scoreStudentDataGridView.SelectedCells[8].Value.ToString();
                gradeLable.Text = scoreStudentDataGridView.SelectedCells[9].Value.ToString();
                addNewButton.Enabled = false;
                saveScoreButton.Enabled = false;
                updateScoreButton.Enabled = true;
            }
        }
    }
}
