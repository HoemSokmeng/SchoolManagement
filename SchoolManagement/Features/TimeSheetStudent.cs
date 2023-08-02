using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagement.Features
{
    public class TimeSheetStudent
    {
        public TimeSheetDbContext DbContext { get; }
        public TimeSheetStudent()
        {
            DbContext = new TimeSheetDbContext();
        }
        public void AddStudent(Student student)
        {
            if (string.IsNullOrEmpty(student.Id) ||
               string.IsNullOrEmpty(student.Name) ||
               string.IsNullOrEmpty(student.Sex) ||
               string.IsNullOrEmpty(student.Department))
            {
                throw new ArgumentException("Please provide all teacher data!");
            }
            else
            {
                DbContext.Students.Add(student);
                DbContext.SaveChanges();
            }
        }
        public void UpdateStudent(string IdentityId, string Name, string Sex, string Department)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Sex) || string.IsNullOrEmpty(Department))
            {
                throw new ArgumentException("Please provide all student data");
            }
            var student = DbContext.Students.Find(IdentityId);
            if (student == null)
            {
                throw new ArgumentException("Student not found!");
            }
            //update the Student
            student.Name = Name;
            student.Sex = Sex;
            student.Department = Department;
            DbContext.SaveChanges();
        }
        public void LogStudent(string id, AttenStudent loInfo)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Id No empty!");
            }
            var student = DbContext.Students.Include(n => n.Attens).FirstOrDefault(student => student.Id == id.Trim());

            if (student == null)
            {
                throw new ArgumentException($"Id {id} not found in Teacher list.");
            }
            student.Attens!.Add(loInfo);
            DbContext.SaveChanges();
        }
        public List<StudentView> GetAllStudent()
        {
            return DbContext.Students.Select(stu => new StudentView()
            {
                IdentityId = stu.Id,
                Name = stu.Name,
                Sex = stu.Sex,
                Department = stu.Department
            }).ToList();
        }
        public List<Student> GetAllStudent(bool isSimpleVersion)
        {
            return DbContext.Students.ToList();
        }
    }
}
