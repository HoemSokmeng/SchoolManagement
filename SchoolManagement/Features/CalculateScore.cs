using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagement.Features
{
    public class CalculateScore
    {
        public TimeSheetDbContext DbContext { get;}
        
        public CalculateScore()
        {
            DbContext = new TimeSheetDbContext();
        }
        public void AddScoreStudent(ScoreStudent sStudent)
        {
           
            if (string.IsNullOrEmpty(sStudent.Id) ||
              string.IsNullOrEmpty(sStudent.Name) ||
              string.IsNullOrEmpty(sStudent.Python.ToString()) ||
              string.IsNullOrEmpty(sStudent.Java.ToString()) ||
              string.IsNullOrEmpty(sStudent.CShap.ToString()) ||
              string.IsNullOrEmpty(sStudent.BigData.ToString()) ||
              string.IsNullOrEmpty(sStudent.English.ToString()))
            {
                throw new ArgumentException("Please provide all teacher data!");
            }
            else
            {
                DbContext.ScoreStudents.Add(sStudent);
                DbContext.SaveChanges();
            }
        }
        
        public void UpdateScoreStudent(string Id,string Python, string Java, string Cshap, string BigData, string English)
        {
            if (string.IsNullOrEmpty(Python) || string.IsNullOrEmpty(Java) || string.IsNullOrEmpty(Cshap) 
                || string.IsNullOrEmpty(BigData) || string.IsNullOrEmpty(English))
            {
                throw new ArgumentException("Please provide all teacher data");
            }
            var stdScore = DbContext.ScoreStudents.Find(new string(Id));
            if (stdScore == null)
            {
                throw new ArgumentException("Teacher not found!");
            }
            //update the Score
            Double python = Double.Parse(Python);
            Double java = Double.Parse(Java);
            Double cshap = Double.Parse(Cshap);
            Double bigData = Double.Parse(BigData);
            Double english = Double.Parse(English);

            stdScore.Total = python + java + cshap + bigData + english;
            stdScore.average = stdScore.Total / 5;
            stdScore.Grade = $"{stdScore.average switch
            {
                >= 90 => stdScore.Grade = "A",
                >= 80 => stdScore.Grade = "B",
                >= 70 => stdScore.Grade = "C",
                >= 60 => stdScore.Grade = "D",
                >= 50 => stdScore.Grade = "E",
                _ => stdScore.Grade = "F",
            }}";

            stdScore.Python = python;
            stdScore.Java = java;
            stdScore.CShap = cshap;
            stdScore.BigData = bigData;
            stdScore.English = english;
            DbContext.SaveChanges();
        }
        public List<ScoreStudent> GetAllScoreStudent()
        {
            return DbContext.ScoreStudents.Select(sStudent => new ScoreStudent()
            {
                Id = sStudent.Id,
                Name = sStudent.Name,
                Python = sStudent.Python,
                Java = sStudent.Java,
                CShap = sStudent.CShap,
                BigData = sStudent.BigData,
                English = sStudent.English,
                Total = sStudent.Total,
                average = sStudent.average,
                Grade = sStudent.Grade
            }).ToList();
        }

        public List<ScoreStudent> GetAllScoreStudent(bool isSimpleVersion)
        {
            return DbContext.ScoreStudents.ToList();
        }
    }
}
