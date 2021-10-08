using System;
using System.Linq;

namespace PassWordGenerator.password.logic
{
	class makeThePass
	{
		public static string makeASimplePass(string sym, string nums, string toLower, string toUpper, string ambiguos, uint lenght)
		{
			var chars = sym+nums+toLower+toUpper+ambiguos;
			
			var random = new Random();
			try {
				return new string(Enumerable.Repeat(chars, (int)lenght)
		 .Select(s => s[random.Next(s.Length)]).ToArray());
			}
				catch {
					return "NOTHING FOR YOU";
			}
			

			
		}
		
	}
}
