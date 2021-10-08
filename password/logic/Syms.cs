using System;
using System.Linq;

namespace PassWordGenerator.password.logic
{
	class Syms
	{		
		public static string sym(int lenght, bool cases)
		{
			if (cases)
			{
				var random = new Random();
				const string chars = "@%&$#|";
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
