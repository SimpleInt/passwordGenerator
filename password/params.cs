using PassWordGenerator.password.logic;

namespace PassWordGenerator.password
{
	public class @params 
	{
		
		public static string param(bool sym, bool num, bool lower, bool upper, bool ambiguos, bool preferences, uint lenght)
		{
			int trues = 0;
			bool[] values = new bool[5] { sym, num, lower, upper, ambiguos };
			for (int i = 0; i < values.Length; i++)
			{
				if (values[i])
				{
					trues++;
				}
			}

			int a = (int)lenghtER(lenght, trues);

			return makeThePass.makeASimplePass(Syms.sym(a, sym), nums.num(a,num), toLowerAndUpper.toLower(a, lower), toLowerAndUpper.toUpper(a, upper), ambiguous.ambiguou(a, ambiguos), lenght);
		}
		
		static double lenghtER(uint lenght, int trues)
		{
			double result;
			try
			{
				result = lenght / trues;
			}
			catch (System.Exception)
			{
				result = 1;
			}
			return result;
		}
	}
}
