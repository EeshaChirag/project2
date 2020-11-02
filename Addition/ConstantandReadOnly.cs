using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
	class ConstantEx
	{
		//Compile time constant
		public const float pi = 3.14f;
		const int value = 10 + 20;
		//non constant variable
		int data = 80;
		/*
		//Error
		pi=89.0;
		Const int add = 10+ data;
		static Const int value1=10+20;*/

		internal void PerimeterofCircle(int radius)
		{
			//const string name = "Jai";
			//pi=89.0; //error
			Console.WriteLine("PerimeterofCircle:{0}", (2 * pi * radius));
		}
	}

	class ReadOnlyEx
	{
		//RunTime Constant
		internal readonly string SchoolName;
		internal static readonly string OrgName = "L&T";

		internal ReadOnlyEx(string SchoolName)
		{
			this.SchoolName = SchoolName;
		}

		void DisplayStudent()
		{
			//Error
			//SchoolName="MN";
		}
	}
	class ConstantandReadOnly
    {
		static void Main()
		{
			ReadOnlyEx readonlyEg = new ReadOnlyEx("Zain");
			ReadOnlyEx r2 = new ReadOnlyEx("KV");
			ConstantEx c = new ConstantEx();
			c.PerimeterofCircle(4);
			Console.Read();
		}
	}
}
