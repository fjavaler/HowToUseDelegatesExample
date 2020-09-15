using System;
using System.Collections.Generic;

namespace HowToUseDelegatesExample
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //create a list of employees
      var empList = new List<Employee>
      {
        new Employee() { ID = 101, Name = "Mary", Salary = 50000, Experience = 5 },
        new Employee() { ID = 102, Name = "Mike", Salary = 40000, Experience = 4 },
        new Employee() { ID = 103, Name = "John", Salary = 60000, Experience = 6 },
        new Employee() { ID = 104, Name = "Todd", Salary = 30000, Experience = 3 }
      };

      //declare and initialize the delegate
      IsPromotable isPromotable = new IsPromotable(Promote);

      //pass the list and delegate into the PromoEmployee method.
      Console.WriteLine(">Using Promote method:");
      Employee.PromoteEmployee(empList, isPromotable);

      Console.WriteLine("\n>Using lambda expression:");
      //alternately, you can use a lambda expression to replace line 24. If being used, Promote method below may be deleted.
      Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
    }

    /// <summary>
    /// The delegate method.
    /// </summary>
    /// <param name="empl">An employee.</param>
    /// <returns>True or false.</returns>
    private static bool Promote(Employee empl)
    {
      if (empl.Experience >= 5)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
