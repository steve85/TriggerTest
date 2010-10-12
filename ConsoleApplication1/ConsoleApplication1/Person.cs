using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Person
    {
		public String Name {get; set;}
		public Int32 Age {get; set;}
		
		public override String ToString()
		{
			return String.Format("Hello, my name is {0} and I am {1} years old.",
			this.Name,
			this.Age);
		}
    }
}