using System;
namespace GroupProject
{
	internal class Employee
	{
		//properties
		public string Name { get; set; }
		public double Wage { get; set; }

		//constructor
		public Employee (string name, double wage)
        {
			Name = name;
			Wage = wage;
        }

		public void Working()
        {
            Console.WriteLine("Employee is programming a sick ass app.");
        }

	}
}

