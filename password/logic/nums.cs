using System;
using System.Linq;

namespace PassWordGenerator.password.logic
{
	class nums
	{
		public static string num(int lenght, bool cases)
		{
			if (cases)
			{
				var random = new Random();
				const string chars = "1234567890";
				return new string(Enumerable.Repeat(chars, lenght)
		 .Select(s => s[random.Next(s.Length)]).ToArray());
			}
			else
			{
				return "";
			}
			
		}
	}
}
