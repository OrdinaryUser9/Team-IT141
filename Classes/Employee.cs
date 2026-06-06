using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Classes;

public class Employee: Department
{
    public string Name { get; set; }    

    public string FirstName { get; set; }   

    public int Age { get; set; }

    public double Salary { get; set; }

    public double BonusPay()
    {

        return Salary + (Salary * 20 / 100);
    }
}
