using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Lesson5
{
    class Repository
    {
        public ObservableCollection<Employee> EmployeeDb { get; set; }
        public ObservableCollection<Department> DepartmentDb { get; set; }
        static Random rnd = new Random();

        public Repository(int CountDb, int CountEmp)
        {
            EmployeeDb = new ObservableCollection<Employee>();
            DepartmentDb = new ObservableCollection<Department>();
            

            for(int i = 0; i < CountDb; i++)
            {
                DepartmentDb.Add(new Department($"Департамент {i}", (i)));
            }

            for (int i = 0; i < CountEmp; i++)
            {
                EmployeeDb.Add(new Employee($"Фамилия {i}", rnd.Next(DepartmentDb.Count)));
            }

            foreach(var a in EmployeeDb)
            {
                Console.WriteLine(a);
            }

            foreach (var a in DepartmentDb)
            {
                Console.WriteLine(a);
            }
        }
    }
}
