using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Classes;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string LogoPng { get; set; }
    public int Budget { get; set; }

    public void BudceniHesabla()
    {
        Console.WriteLine("Budce: " + Budget);
    }

}
