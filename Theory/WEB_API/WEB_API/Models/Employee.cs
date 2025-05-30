using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_API.Models
{
	public class Employee
	{
		public int empid { get; set; }
		public string name { get; set; }
		public string address { get; set; }
		public int salary { get; set; }

        public Employee()
        {
            
        }

        public Employee(int empid, string name, string address, int salary)
        {
            this.empid = empid;
            this.name = name;
            this.address = address;
            this.salary = salary;
        }

		public override bool Equals(object obj)
		{
			Employee e = (Employee)obj;
			return (this.empid == e.empid);
		}
	}
}