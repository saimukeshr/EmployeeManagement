using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Models
{
    
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        public string Status { get; set; }
        public string Department { get; set; }
        public string Level { get; set; }
        public string EmployeeID { get; set; }
        public string Password { get; set; }    
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
}
