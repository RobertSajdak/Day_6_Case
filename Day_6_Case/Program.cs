using Day_6_Case;

Employee employee1 = new Employee("Robert", "Kiyosaki", 49);
Employee employee2 = new Employee("Paula", "Edison", 38);
Employee employee3 = new Employee("Roksana", "McGregor", 29);


employee1.AddGrades(3);
employee1.AddGrades(5);
employee1.AddGrades(2);

employee2.AddGrades(4);
employee2.AddGrades(1);
employee2.AddGrades(7);

employee3.AddGrades(1);
employee3.AddGrades(100);
employee3.AddGrades(2);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = 0;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if (employee1.Result > maxResult)
    {
        maxResult = employee1.Result;
        employeeWithMaxResult = employee1;
    }
    else if (employee2.Result > maxResult)
    {
        maxResult = employee2.Result;
        employeeWithMaxResult = employee2;
    }
    else if (employee3.Result > maxResult)
    {
        maxResult = employee3.Result;
        employeeWithMaxResult = employee3;
    }
}

Console.WriteLine($"\nPracownikiem z najwyższą sumą ocen wynoszącą {employeeWithMaxResult.Result} jest:\nimię: {employeeWithMaxResult.Name} \nnazwisko: {employeeWithMaxResult.Surname} \nwiek: {employeeWithMaxResult.Age}");
