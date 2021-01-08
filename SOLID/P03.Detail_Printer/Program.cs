using System;
using System.Collections.Generic;
using P03.Detail_Printer;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            IList<IPrintable> employees = new List<IPrintable>();
            employees.Add(new Manager("Milena", new List<string>{ }));
            employees.Add(new Employee("Ivan Ivanov"));
            DetailsPrinter printer = new DetailsPrinter(employees);
            printer.PrintDetails();
        }
    }
}
