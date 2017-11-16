using System;
using System.Collections.Generic;
using System.Text;
using Test.Entity;

namespace Test
{
    public class EmployeeTestBuilder
    {
        public static Employee _employee;
        public EmployeeTestBuilder()
        {
            _employee = new Employee();
        }

        public EmployeeTestBuilder Default()
        {
            _employee.Name = "John";
            _employee.BirthDate = new DateTime();
            _employee.GrossSalary = 1000;

            return this;
        }

        public EmployeeTestBuilder WithName(string name)
        {
            _employee.Name = name;
            return this;
        }

        public EmployeeTestBuilder HasAge(int age)
        {
            _employee.BirthDate = new DateTime(DateTime.Now.Year - age, DateTime.Now.Month, DateTime.Now.Day);
            return this;
        }

        public EmployeeTestBuilder HasGrossSalaryOf(double salary)
        {
            _employee.GrossSalary = salary;
            return this;
        }

        public Employee Build()
        {
            return _employee;
        }
    }
}
