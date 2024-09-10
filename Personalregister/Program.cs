// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to Employee Register! ");
EmployeeRegister register = new EmployeeRegister();


while (true)
{
    Console.WriteLine(" Enter Employee name OR  q  to quti : ");

    string name = Console.ReadLine();
    if (name.ToLower() == "q") break;
    Console.WriteLine("  Enter  Employee salary : ");
    if (decimal.TryParse(Console.ReadLine(), out decimal salary))
    {
        Employee employee = new Employee(name, salary);
        register.addEmployee(employee);
    }
    else
    {
        Console.WriteLine("Invalid salary input. Please try again.");
    }


}
register.DisplayRegister();




public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public void ShowEmployeeInfo()
    {
        Console.WriteLine($"Name: {Name} , Salary: {Salary}  Kr");
    }

}

public class EmployeeRegister
{
    private List<Employee> employees = new List<Employee>();

    public void addEmployee(Employee employee)
    {
        employees.Add (employee);
    }


    public void DisplayRegister()
    {
        Console.WriteLine("Employee Register:");

        foreach (Employee emp in employees)
        {
            emp.ShowEmployeeInfo();      
        }


    }


}




