using System;


namespace Methgods_Advanced
{
    class Employee
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public string Package { get; set; }

    }
    class AboutEmployee
    {
        public static Employee GetEmployee()
        {
            Employee employee = new Employee();
            employee.Name = "Swapna";
            employee.Experience = 2;
            employee.Package = "8LPA";
            return employee;
        }

        public static Employee GetUpdateEmployee(Employee employee)
        {
            employee.Name = employee.Name + " " + "Narupalle";
            return employee;
        }
    }
    class Program
    {
        static void Main()
        {
            var singleEmployee = AboutEmployee.GetEmployee();
            Console.WriteLine($"single employee: {singleEmployee.Name}, {singleEmployee.Experience}, {singleEmployee.Package}");

            var updatedEmployee = AboutEmployee.GetUpdateEmployee(singleEmployee);
            Console.WriteLine($"Updated Employee name is: {updatedEmployee.Name}");
        }

    
    }
}
