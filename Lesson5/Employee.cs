using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public int DepartmentId { get; set; }

        public Employee(string Name, int Id)
        {
            EmployeeName = Name;
            this.DepartmentId = Id;
        }

        public override string ToString()
        {
            return $"{EmployeeName, 15} {DepartmentId, 2}";
        }
    }
}
