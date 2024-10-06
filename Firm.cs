using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Firm
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Profile { get; set; }
        public string Director { get; set; }
        public int EmployeeCount { get; set; }
        public string Address { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
