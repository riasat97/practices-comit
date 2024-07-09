
// Company App
// Basic Level:
// Create an Employee class with properties Name and Salary. Add a method to display the employee details.
// Intermediate Level:
// Extend the Employee class to include a Department class.
// Create a relationship between Employee and Department.
// Add a method in Department to list all employees in the department.
// Advanced Level:
// Implement a Company class that contains multiple Department objects.
// Add methods in Company to add employees to departments and display all employees. Implement a search method in Company to find employees by name.
// Bonus:
// Explain the Object-Oriented Programming (OOP) principles applied in the following employee and salary management exercise, providing examples of how these principles are implemented in the code.

namespace CompanyApp;
class Program
{
    static void Main(string[] args)
    {
        //basic level
        Employee emp1 = new Employee("riasat", 2000);
        Employee emp2 = new Employee("raihan", 3000);
        Console.WriteLine(emp1.displayEmployeeDetails());
        Console.WriteLine(emp2.displayEmployeeDetails());
        //intermediate level
        Department dept1 = new Department("IT");
        Department dept2 = new Department("Administration");
        dept1.addEmployee(emp1);
        dept1.addEmployee(emp2);
        Console.WriteLine(dept1.DepartmentWiseEmployeeList());
        //advance level
        Company cmp = new Company();
        cmp.addDepartment(dept1);
        cmp.addDepartment(dept2);
        cmp.addEmployeToDepartment(new Employee("noor", 4000), dept2);

        Console.WriteLine(cmp.displayAllEmployees());

        Employee foundEmployee = cmp.FindEmployeeByName("noor");
        if (foundEmployee != null)
        {
            Console.WriteLine("Employee found:");
            Console.WriteLine(foundEmployee.displayEmployeeDetails());
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }


    }
}
