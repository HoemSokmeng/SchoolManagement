using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagement.Features
{
    public class TimeSheetDepartment
    {
        public TimeSheetDbContext DbContext { get;}
        public TimeSheetDepartment()
        {
            DbContext = new TimeSheetDbContext();
        }
        public void AddDepartment(Department department)
        {
            if(string.IsNullOrEmpty(department.Id) ||
               string.IsNullOrEmpty(department.DptName) ||
               string.IsNullOrEmpty(department.DptManager) ||
               string.IsNullOrEmpty(department.DptPrice))
            {
                throw new ArgumentException("Please provide all department data!");
            }
            else
            {
                DbContext.Departments.Add(department);
                DbContext.SaveChanges();
            }
        }
        public void UpdateDepartment(string Id, string DptName, string DptManager, string DptPrice)
        {
            if (string.IsNullOrEmpty(DptName) || string.IsNullOrEmpty(DptManager) || string.IsNullOrEmpty(DptPrice))
            {
                throw new ArgumentException("Please provide all Department data");
            }
            var department = DbContext.Departments.Find(Id);
            if (department == null)
            {
                throw new ArgumentException("Department not found!");
            }
            //update the Department
            department.DptName = DptName;
            department.DptManager = DptManager;
            department.DptPrice = DptPrice;
            DbContext.SaveChanges();
        }
        public List<Department> GetAllDepartment()
        {
            return DbContext.Departments.Select(department => new Department()
            {
               Id = department.Id,
               DptName = department.DptName,
               DptManager = department.DptManager,
               DptPrice = department.DptPrice
            }).ToList();
        }
        public List<Department> GetAllDepartment(bool isSimpleVersion)
        {
            return DbContext.Departments.ToList();
        }
    }
}
