using ChallengeApp;

Employee emploee1 = new Employee("Michał", "Nowak", 30);
Employee emploee2 = new Employee("Natalia", "Kowalska", 27);
Employee emploee3 = new Employee("Mariusz", "Malinowski", 34);


emploee1.AddScore(5);
emploee1.AddScore(10);
emploee1.AddScore(9);
emploee1.AddScore(2);
emploee1.AddScore(3);

emploee2.AddScore(4);
emploee2.AddScore(6);
emploee2.AddScore(7);
emploee2.AddScore(1);
emploee2.AddScore(8);

emploee3.AddScore(3);
emploee3.AddScore(2);
emploee3.AddScore(1);
emploee3.AddScore(6);
emploee3.AddScore(10);

List<Employee> employees = new List<Employee>()
{
    emploee1, emploee2, emploee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine(employeeWithMaxResult.Info);