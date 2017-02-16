using System;
using Library;

namespace Fizzbuzz
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			for (int i = 1; i <= 100; i++)
			{
				Console.WriteLine(Buzzer.Buzz(i));
			}
			var tester = new Tester();
		}
		class Tester
		{///<summary> This is the test class, which contains a method, that compares two objects to another.</summary>
		 ///<param name = "">  </param>
		 ///<returns> The Test() method only returns the error message if the test fails. </returns>
			public enum StateType { Successful, Failed };
			public StateType s;

			public StateType GetState()
			{
				return s;
			}

			public void Test(string actual, string expected, string message)
			{
				if (actual == expected)
				{
					s = StateType.Successful;
				}
				else
				{
					s = StateType.Failed;
					Console.Error.WriteLine(message);
				}
			}
		}
	}
}

