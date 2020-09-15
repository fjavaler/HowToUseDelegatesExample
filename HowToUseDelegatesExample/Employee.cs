using System;
using System.Collections.Generic;

namespace HowToUseDelegatesExample
{
  //delegate.
  internal delegate bool IsPromotable(Employee empl);

  /// <summary>
  /// Employee class.
  /// </summary>
  internal class Employee
  {
    //Employee properties.
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    /// <summary>
    /// This method uses the IsPromotable delegate as a "stand in" for an implemented method.
    /// Actual implementation of delegate method is done in Program.cs.
    /// </summary>
    /// <param name="employeeList">A list of employees.</param>
    /// <param name="IsEligibleToPromote">delegate method used as "stand in."</param>
    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
      foreach (Employee employee in employeeList)
      {
        if (IsEligibleToPromote(employee))
        {
          Console.WriteLine(employee.Name + " promoted.");
        }
      }
    }
  }
}