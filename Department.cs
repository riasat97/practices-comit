public class Department
{
    private string title { get; set; }
    public List<Employee> employees { get; private set; } = new List<Employee>();

    public Department(string title)
    {
        this.title = title;
    }
    public string displayDepartmentDetails()
    {
        return $"Department: {title}";
    }
    public void addEmployee(Employee employee)
    {
        employees.Add(employee);
    }
    public string DepartmentWiseEmployeeList()
    {
        string details = displayDepartmentDetails() + "\n";
        foreach (var employee in employees)
        {
            details += employee.displayEmployeeDetails() + "\n";
        }
        return details;
    }

    public string AllEmployeeList()
    {
        string details = "";
        foreach (var employee in employees)
        {
            details += employee.displayEmployeeDetails() + "\n";
        }
        return details;
    }
}