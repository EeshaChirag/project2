using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class SystemException
    {
		static void Main()
		{
			int num = 30;
			string[] fruits = { "Orange", "Mango" };
			int[,] arr = { { 10, 20, 90 }, { 30, 40, 80 } };

			try
			{
				Console.WriteLine("Fruit[2]:{0}", fruits[2]);
				num = num / 0;
			}
			//Exception is handled
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("Message:{0}", ex);
}

			catch (IndexOutOfRangeException ex)
			{
				Console.WriteLine("Message:{0}", ex);
			}

			catch (Exception ex)
			{
				//Console.WriteLine("Message:{0}", ex);
				Console.WriteLine("Message:{0}", ex.Message);
		
				Console.WriteLine("Source:{0}", ex.Source);
				Console.WriteLine("Message:{0}", ex.StackTrace);
				Console.WriteLine("Message: Please Check the inputs");
			}

			finally
			{
				Console.WriteLine("Used to close open Connection");
			}

			num = num * num;
			Console.WriteLine("Multiplication:{0}", num);
		
			Console.WriteLine("End of system Exception");
			Console.Read();
		}
	}
}
