using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
	class DellLaptop
	{
		//Properties: To access the private variables of the class
		//Read-Only Property
		public string Laptopname { get; private set; } //get:fetch : set: setting the data
		public string ram {get; set;}

	internal DellLaptop(string Laptopname, string ram)
	{
		this.Laptopname = Laptopname;
		this.ram = ram;
	}

	class Student
    {
		static void Main()
		{
			DellLaptop d = new DellLaptop("Inspironi3", "8 Gb");
			Console.WriteLine("Name:{0}", d.Laptopname);
			d.ram = "16 Gb";
			Console.WriteLine("Ram:{0}", d.ram);

				Console.ReadLine();
		}
	}
}
	class Property
    {

	}
}
