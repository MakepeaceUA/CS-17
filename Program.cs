using System;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 4 и 7
            //List<Firm> firms = new List<Firm>
            //    {
            //    new Firm {Name = "IT Firm", Date = new DateTime(2018, 10, 30), Profile = "IT", Director = "White", EmployeeCount = 300, Address = "London",Employees = new List<Employee>
            //    {
            //        new Employee { FullName = "FullName1", Position = "Developer", Phone = "231234567", Email = "FN1@example.com", Salary = 80000 },
            //        new Employee { FullName = "Lionel", Position = "Manager", Phone = "231234577", Email = "di_id@example.com", Salary = 90000 }
            //    }},
            //    new Firm { Name = "Food Firm", Date = new DateTime(2020, 5, 15), Profile = "Marketing", Director = "Black", EmployeeCount = 150, Address = "Berlin", Employees = new List<Employee>
            //    {
            //        new Employee { FullName = "FullName2", Position = "Manager", Phone = "211234567", Email = "FN2@example.com", Salary = 75000 },
            //        new Employee { FullName = "FullName3", Position = "Chef", Phone = "2312355567", Email = "di.FN3@example.com", Salary = 50000 }
            //    }},
            //    new Firm { Name = "Marketing Firm", Date = new DateTime(2015, 9, 10), Profile = "Food Industry", Director = "Greys", EmployeeCount = 100, Address = "Paris", Employees = new List<Employee>
            //    {
            //        new Employee { FullName = " Lionel", Position = "Manager", Phone = "271234567", Email = "lionel@example.com", Salary = 75000 },
            //        new Employee { FullName = "FullName4", Position = "Chef", Phone = "231234567", Email = "FN4@example.com", Salary = 50000 }
            //    } },
            //    new Firm { Name = "Food & White", Date =new DateTime(2019, 1, 31), Profile = "Food Industry", Director = "Black", EmployeeCount = 140, Address = "London", Employees = new List<Employee>
            //    {
            //        new Employee { FullName = "FullName5", Position = "Manager", Phone = "291234567", Email = "di.FN5@example.com", Salary = 75000 },
            //        new Employee { FullName = "Lionel", Position = "Chef", Phone = "231234567", Email = "di.lionel@example.com", Salary = 50000 }
            //    } }
            //    };
            //Console.WriteLine("All employees from IT Firm:");
            //var employees = firms.First(f => f.Name == "IT Firm").Employees;
            //foreach (var e in employees)
            //{
            //    Console.WriteLine($"Full Name: {e.FullName}, Position: {e.Position}, Phone: {e.Phone}, Email: {e.Email}, Salary: {e.Salary}");
            //}
            //Console.WriteLine();

            //Console.WriteLine($"Employees from IT Firm with salary greater than {60000}:");
            //var emp1 = employees.Where(e => e.Salary > 60000);
            //foreach (var e in emp1)
            //{
            //    Console.WriteLine($"Full Name: {e.FullName}, Position: {e.Position}, Salary: {e.Salary}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Employees with position 'Manager':");
            //var emp2 = firms.SelectMany(f => f.Employees)
            //                    .Where(e => e.Position == "Manager");
            //foreach (var e in emp2)
            //{
            //    Console.WriteLine($"Full Name: {e.FullName}, Firm: {firms.First(f => f.Employees.Contains(e)).Name}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Employees with phone starting with '23':");
            //var emp3 = firms.SelectMany(f => f.Employees)
            //                             .Where(e => e.Phone.StartsWith("23"));
            //foreach (var e in emp3)
            //{
            //    Console.WriteLine($"Full Name: {e.FullName}, Phone: {e.Phone}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Employees with email starting with 'di':");
            //var emp4 = firms.SelectMany(f => f.Employees)
            //                             .Where(e => e.Email.StartsWith("di"));
            //foreach (var e in emp4)
            //{
            //    Console.WriteLine($"Full Name: {e.FullName}, Email: {e.Email}");
            //}
            //Console.WriteLine();

            //Console.WriteLine("Employees with the name 'Lionel':");
            //var emp5 = firms.SelectMany(f => f.Employees)
            //                           .Where(e => e.FullName.Contains("Lionel"));
            //foreach (var e in emp5)
            //{
            //    Console.WriteLine($"Full Name: {e.FullName}, Position: {e.Position}, Phone: {e.Phone}, Email: {e.Email}");
            //}

            //Console.WriteLine("All firms:");
            //foreach (var firm in firms)
            //{
            //    Console.Write(($"Name: {firm.Name}, Foundation date: {firm.Date}, Profile: {firm.Profile}, Director: {firm.Director}, Employee Count: {firm.EmployeeCount}, Address: {firm.Address}\n"));
            //}
            //Console.WriteLine();

            //Console.WriteLine("Firms with 'Food' in the name:");
            //var frm = from f
            //                    in firms
            //          where f.Name == "Food"
            //          select f;
            //foreach (var firm in frm)
            //{
            //    Console.Write(($"Name: {firm.Name}, Foundation date: {firm.Date}, Profile: {firm.Profile}, Director: {firm.Director}, Employee Count: {firm.EmployeeCount}, Address: {firm.Address}\n"));
            //}
            //Console.WriteLine();

            //Console.WriteLine("Firms in the marketing industry:");
            //var frm1 = from f
            //                     in firms
            //           where f.Profile == "Marketing"
            //           select f;
            //foreach (var firm in frm1)
            //{
            //    Console.Write(($"Name: {firm.Name}, Foundation date: {firm.Date}, Profile: {firm.Profile}, Director: {firm.Director}, Employee Count: {firm.EmployeeCount}, Address: {firm.Address}\n"));
            //}
            //Console.WriteLine();

            //Console.WriteLine("\nFirms in marketing or IT:");
            //var frm2 = from f
            //                         in firms
            //           where f.Profile == "Marketing" || f.Profile == "IT"
            //           select f;
            //foreach (var firm in frm2)
            //{
            //    Console.Write(($"Name: {firm.Name}, Foundation date: {firm.Date}, Profile: {firm.Profile}, Director: {firm.Director}, Employee Count: {firm.EmployeeCount}, Address: {firm.Address}\n"));
            //}
            //Console.WriteLine();

            //Console.WriteLine("\nFirms with more than 100 employees:");
            //var frm3 = from f
            //                                    in firms
            //           where f.EmployeeCount > 100
            //           select f;
            //foreach (var firm in frm3)
            //{
            //    Console.Write(($"Name: {firm.Name}, Foundation date: {firm.Date}, Profile: {firm.Profile}, Director: {firm.Director}, Employee Count: {firm.EmployeeCount}, Address: {firm.Address}\n"));
            //}
            //Console.WriteLine();

            //Console.WriteLine("\nFirms with 100 to 300 employees:");
            //var frm4 = from f
            //                                 in firms
            //           where f.EmployeeCount >= 100 && f.EmployeeCount <= 300
            //           select f;
            //foreach (var firm in frm4)
            //{
            //    Console.Write(($"Name: {firm.Name}, Foundation date: {firm.Date}, Profile: {firm.Profile}, Director: {firm.Director}, Employee Count: {firm.EmployeeCount}, Address: {firm.Address}\n"));
            //}
            //Console.WriteLine();

            //Console.WriteLine("Firms located in London:");
            //var frm5 = from f
            //                    in firms
            //           where f.Address == "London"
            //           select f;
            //foreach (var firm in frm5)
            //{
            //    Console.Write(($"Name: {firm.Name}, Foundation date: {firm.Date}, Profile: {firm.Profile}, Director: {firm.Director}, Employee Count: {firm.EmployeeCount}, Address: {firm.Address}\n"));
            //}
            //Console.WriteLine();

            //Console.WriteLine("Firms with a director named White:");
            //var frm6 = from f
            //                             in firms
            //           where f.Director.Contains("White")
            //           select f;
            //foreach (var firm in frm6)
            //{
            //    Console.Write(($"Name: {firm.Name}, Foundation date: {firm.Date}, Profile: {firm.Profile}, Director: {firm.Director}, Employee Count: {firm.EmployeeCount}, Address: {firm.Address}\n"));
            //}
            //Console.WriteLine();

            //Console.WriteLine("Firms founded more than two years ago:");
            //var frm7 = from f
            //                                      in firms
            //           where (DateTime.Now - f.Date).TotalDays > 365 * 2
            //           select f;
            //foreach (var firm in frm7)
            //{
            //    Console.Write(($"Name: {firm.Name}, Foundation date: {firm.Date}, Profile: {firm.Profile}, Director: {firm.Director}, Employee Count: {firm.EmployeeCount}, Address: {firm.Address}\n"));
            //}
            //Console.WriteLine();

            //Console.WriteLine("\nFirms founded exactly 123 days ago:");
            //var frm8 = from f
            //                             in firms
            //           where (DateTime.Now - f.Date).TotalDays >= 123
            //           select f;
            //foreach (var firm in frm8)
            //{
            //    Console.Write(($"Name: {firm.Name}, Foundation date: {firm.Date}, Profile: {firm.Profile}, Director: {firm.Director}, Employee Count: {firm.EmployeeCount}, Address: {firm.Address}\n"));
            //}
            //Console.WriteLine();
            //Console.WriteLine("\nFirms with a director named Black and 'White' in the name:");
            //var frm9 = from f
            //                                           in firms
            //           where f.Director.Contains("Black") && f.Name.Contains("White")
            //           select f;
            //foreach (var firm in frm9)
            //{
            //    Console.Write(($"Name: {firm.Name}, Foundation date: {firm.Date}, Profile: {firm.Profile}, Director: {firm.Director}, Employee Count: {firm.EmployeeCount}, Address: {firm.Address}\n"));
            //}


            //Задание 5
            //int[] numbers = { 121,15, 75, 81 };
            //Array.Sort(numbers, (x, y) =>
            //    x.ToString().ToCharArray().Sum(c => int.Parse(c.ToString())) -
            //    y.ToString().ToCharArray().Sum(c => int.Parse(c.ToString())));

            //Console.WriteLine("Сортировка по возрастанию суммы цифр:");
            //foreach (var num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}
            //Console.WriteLine();
            //Array.Sort(numbers, (x, y) =>
            //    y.ToString().ToCharArray().Sum(c => int.Parse(c.ToString())) -
            //    x.ToString().ToCharArray().Sum(c => int.Parse(c.ToString())));

            //Console.WriteLine("Сортування по уменьшению суммы цифр:");
            //foreach (var num in numbers)
            //{
            //    Console.Write($"{num} ");
            //}

        }
    }
}