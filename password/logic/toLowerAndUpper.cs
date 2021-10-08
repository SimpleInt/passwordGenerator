using System;
using System.Linq;


namespace PassWordGenerator.password.logic
{
	class toLowerAndUpper
	{
		public static string toLower(int lenght, bool cases)
		{
			if (cases)
			{
				var random = new Random();
				string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();

				return new string(Enumerable.Repeat(chars, lenght)
		 .Select(s => s[random.Next(s.Length)]).ToArray());
			}
			else
			{
				return "";
			}
			
		}
		public static string toUpper(int lenght, bool cases)
		{
			if (cases)
			{
				var random = new Random();
				string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

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
