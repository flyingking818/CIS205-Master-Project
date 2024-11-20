/* 
 Create a program to welcome employees with custom messages.
 Create an Employee class with several public properties (e.g., IdNumber, Name, Email, etc. 
 and a WelcomeMessage() method.
 */

using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

class WelcomeEmployees
{
    static void Main()
    {
        //Instantiate the first employee using the Employee class template
        Employee aWorker = new Employee();

        aWorker.IdNumber = 1234;
        aWorker.Name = "John Doe";
        aWorker.Email = "john@flagler.edu";
        aWorker.Hours = 40;

        aWorker.Salary = aWorker.CalculateSalary(40, 9.75);
        DisplayEmployeeData("First", aWorker);

        //Instantiate the second employee using the same Employee class template
        Employee bWorker = new Employee();
        bWorker.IdNumber = 5678;
        bWorker.Name = "Alice Doe";
        bWorker.Email = "alice@flagler.edu";
        bWorker.Hours = 50;

        bWorker.Salary = bWorker.CalculateSalary(50, 15.5);
        DisplayEmployeeData("Second", bWorker);
    }

    static void DisplayEmployeeData(string order, Employee emp)
    {
        WriteLine("\n{0} employee's message", order);
        emp.WelcomeMessage();
    }

}

class Employee //pascal naming convention, singular form
{
    /* 
     Instance variables (also called fields)
        Data components of a class that differ for each object are stored in instance variables
        Object attributes  - via Getter and Setter 
        Data components of a class
        In this case, idNumber is an instance variable to describe the unique identifier of an employee.
     */

    private int idNumber; //Camel case! :)

    /*
    A property is a member of a class that provides access to a field of a class; 
    properties define how fields will be set and retrieved. 
        - By convention, a property identifier is the same as the field it manipulates, 
        except the first letter is capitalized. The field that supports a property is its backing field. 
    */

    public int IdNumber //formal way to declaring a property, which can incoporate additional business rules.
    {
        get
        {
            return idNumber;
        } //Getter accessor, which allows others to read from this!
        set
        {
            idNumber = value;
        } //Setter accessor, which allow others to set value to this!

    }

    /* 
     Auto-implemented property - also called automatic properties. 
        The set accessor should simply assign a value to the appropriate field.
        The get accessor should simply return the field.
        NO need to declare the field that corresponds to the property!
        Big advantage for simple properties without additional business rules.
     */
    public string Name { get; set; }
    public string Email { get; set; }
    public double Salary { get; set; }
    public bool IsActive { get; set; }
    public double MyPrice { get;  } //This is a READ ONLY property, especially for properties which 
                                    //which are internally set with some logic.

    //Another type of auto properties - rarelly used!
    public string SSN
    {
        get => default;
        set
        {
        }
    }

    public System.DateTime DOB
    {
        get => default;
        set
        {
        }
    }

    //Customized properties - you may implement some rules

    private int hours;
    private bool isOvertime;
    public int Hours //formal way to declaring a property, which can incoporate additional business rules.
    {
        get
        {
            return hours;
        } 
        set
        {
            hours = value;
            //implement overtime business rule 
            if (hours > 40) {
                isOvertime = true;
                //Calculate the price
            }
        } 

    }

    public bool IsOvertime //This is another example of READ ONLY property. Users should not set this.
                           //It's automatically/interally determined by your hours properties (setter)
    {
        get { 
            return isOvertime; 
        }
    }

    //Keep adding a few after class

    // Let's create a method! 

    public void WelcomeMessage()
    {
        //Here, we are using the public property. Question - could we continue to use idNumber field?
        WriteLine("Welcome! Employee #{0}!", IdNumber); //public property is preferred for data access! 
        WriteLine("How can I help you, {0}?", Name);
        WriteLine("Your salary is {0}", Salary.ToString("C"));
        WriteLine("You overtime status: {0}", IsOvertime.ToString());
    }

    public double CalculateSalary(double hours, double hourlyRate)
    {
        double totalPay = 0;

        totalPay = hours * hourlyRate;
        return totalPay;
    }

    }



