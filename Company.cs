public class Company
{
    private List<Department> departments { get; set; } = new List<Department>();

    public void addDepartment(Department department)
    {
        departments.Add(department);
    }
    public void addEmployeToDepartment(Employee employee, Department department)
    {
        department.addEmployee(employee);
    }
    public string displayAllEmployees()
    {
        string employees = "All Employees" + "\n";
        foreach (var department in departments)
        {
            employees += department.AllEmployeeList();
        }
        return employees;
    }
    public Employee FindEmployeeByName(string name)
    {
        foreach (var department in departments)
        {
            var employee = department.employees.FirstOrDefault(e => e.name == name);
            if (employee != null)
            {
                return employee;
            }
        }
        return null;
    }
}