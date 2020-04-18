using System;
using System.Collections.Generic;
using System.Text;
using multi.Entidades;

namespace multi.Modelo
{
    public class EmployeeViewModel
    {
        public List<Employee> Employees { get; set; }

        public EmployeeViewModel()
        {
            Employees = new Employee().getEmployee();
        }
    }
}
