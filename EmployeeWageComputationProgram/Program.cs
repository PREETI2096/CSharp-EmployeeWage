﻿namespace EmployeeWageComputationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeWage emp = new EmployeeWage();
            emp.ComputeEmpWage();
        }
    }
}