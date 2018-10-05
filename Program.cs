using System;
using System.Collections.Generic;

public class Employee {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public DateTime StartingDate { get; set; }
}
public class Company {
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created

        The constructor will set the value of the public properties
    */
    public Company (string CompanyName, DateTime DateCreated) {
        this.Name = CompanyName;
        this.CreatedOn = DateCreated;
    }

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; }
    public DateTime CreatedOn { get; }

    // Create a public property for holding a list of current employees
    public List<Employee> EmployeeList = new List<Employee> ();
}

class Program {
    static void Main (string[] args) {
        // Create an instance of a company. Name it whatever you like.
        Company ACME = new Company ("ACME", DateTime.Now);
        Company CentralPerk = new Company ("CentralPerk", DateTime.Now);

        // Create three employees
        Employee Chandler = new Employee ();
        Chandler.FirstName = "Chandler";
        Chandler.LastName = "Bing";
        Chandler.Title = "CTO";
        Chandler.StartingDate = new DateTime (2017, 1, 18);

        Employee Joey = new Employee ();
        Joey.FirstName = "Joey";
        Joey.LastName = "Tribbiani";
        Joey.Title = "CEO";
        Joey.StartingDate = new DateTime (1999, 5, 5);

        Employee Rachel = new Employee ();
        Rachel.FirstName = "Rachel";
        Rachel.LastName = "Green";
        Rachel.Title = "Fashion Consultant";
        Rachel.StartingDate = new DateTime (2002, 12, 25);

        // Assign the employees to the company
        ACME.EmployeeList.Add (Chandler);
        ACME.EmployeeList.Add (Joey);
        CentralPerk.EmployeeList.Add (Rachel);

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */
        foreach (Employee Employee in ACME.EmployeeList) {
            Console.WriteLine ($"{Employee.FirstName} {Employee.LastName} has been the {Employee.Title} of {ACME.Name} since {Employee.StartingDate}");
        }
        foreach (Employee Employee in CentralPerk.EmployeeList) {
            Console.WriteLine ($"{Employee.FirstName} {Employee.LastName} has been the {Employee.Title} of {CentralPerk.Name} since {Employee.StartingDate}");
        }
    }
}