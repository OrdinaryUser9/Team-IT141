using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Classes;

public class Department: Company
{
    public int ID { get; set; }
    public string Name {  get; set; }
    public void ShowName()
    {
        Console.WriteLine(Name);
    }
    public int PhoneNumber {  get; set; }
    public string LeaderName {  get; set; }
    public Department()
    {
        Console.WriteLine("Ctor yarandi");
    }
}
