using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：計算數值的階乘
			Console.WriteLine("輸入n的階乘");
			int n = Convert.ToInt32(Console.ReadLine());
			int result = 1;
			for (int i = 1; i <= n; i++)
			{
				result *= i;
			}
			Console.WriteLine(result);

		}
	}
}
