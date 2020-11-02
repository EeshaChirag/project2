using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
	/*Access_Modifier struct structure_name
{
	//Fields
	//Parameterized constructor
	//Constants
	//Properties
	//Indexers
	//Events
	//Methods etc.
}*/

	public struct Pen
	{
		internal int penid;
		public string color;
		//error
		//string type = "Fountain";
	}
	class Struct
    {
		static void Main()
		{
			Pen p = new Pen();
			p.penid = 100;
			p.color = "red";
			Console.Read();
		}
	}
}
