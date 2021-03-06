using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Person
    {
		public String FirstName {get; set;}
		public String LastName {get; set;}
		public Int32 Age {get; set;}
		public Gender Sex {get; set;}
		
		public override String ToString()
		{
			return String.Format("Hello, my name is {0} {1} and I am {2} years old. I am a {3}.",
				this.FirstName,
				this.LastName,
				this.Age,
				Sex == Gender.Male ? "Male" : "Female");
		}
		
		public void IncrementAge()
		{
			this.Age++;
		}
    }
}