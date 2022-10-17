using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第三題
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number1 = 9 % 2;
			int number2 = 202 % 2;
			if (number1 == 1) 
			{
				Console.WriteLine("數字9為基數");
			}
			else 
			{
				Console.WriteLine("數字9為偶數"); 
			}
			if (number2 == 1)
			{
				Console.WriteLine("數字202為基數");
			}
			else
			{
				Console.WriteLine("數字202為偶數");
			}
			
		}
	}
}
