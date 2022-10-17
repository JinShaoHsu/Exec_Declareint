using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第四題
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number1 = 10;
		    int number2 = 20;
			if (number1 > number2)
			{
				int temp = number1;
				Console.WriteLine(number1=number2);
				Console.WriteLine(number2=temp);
			}
			else
			{
				Console.WriteLine(number1);
				Console.WriteLine(number2);
			}
		}
	}
}
