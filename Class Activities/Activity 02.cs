using System;

public interface IEmployee
{
    string GetEmployeeName();
    int GetEmployeeID();
    double GetSalary();
}

public interface IDepartment
{
    string GetDepartmentName();
    string GetHOP(); 
}

public class Employee : IEmployee, IDepartment
{
    private string name;
    private int employeeID;
    private double salary;
    private string departmentName;
    private string hopName;
    public Employee(string name, int employeeID, double salary, string departmentName, string hopName)
    {
        this.name = name;
        this.employeeID = employeeID;
        this.salary = salary;
        this.departmentName = departmentName;
        this.hopName = hopName;
    }
    
    public string GetEmployeeName()
    {
        return name;
    }
    public int GetEmployeeID()
    {
        return employeeID;
    }
    public double GetSalary()
    {
        return salary;
    }
    
    public string GetDepartmentName()
    {
        return departmentName;
    }
    public string GetHOP()
    {
        return hopName;
    }
}
class Program
{
    static void Main(string[] args)
    {
        
        Employee employee = new Employee("Ashly", 12345, 50000, "Finance", "Alice Smith");
        
        Console.WriteLine($"Employee Name: {employee.GetEmployeeName()}");
        Console.WriteLine($"Employee ID: {employee.GetEmployeeID()}");
        Console.WriteLine($"Salary: {employee.GetSalary()}");
        Console.WriteLine($"Department: {employee.GetDepartmentName()}");
        Console.WriteLine($"Head of Department: {employee.GetHOP()}");
    }
}