using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var x = new bike ("KTM", 29);
				Console.WriteLine(x.Name);
				Console.WriteLine(x.Size);
				x.UpdateName ("Scott");
				Console.WriteLine (x.Name);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error:{ex}");
			}
		}
	}
}