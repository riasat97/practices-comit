public class Employee
{
    public string name { get; private set; }
    private int salary { get; set; }

    public Employee(string name, int salary)
    {
        this.name = name;
        this.salary = salary;
    }
    public string displayEmployeeDetails()
    {
        return $"Name: {name} Salary: {salary}";
    }
}