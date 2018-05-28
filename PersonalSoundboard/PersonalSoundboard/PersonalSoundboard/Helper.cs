using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalSoundboard
{
    class Helper
    {
		public static Random random = new Random();
		//public static int lenght = 10;
		private static int length = 10;

		public static string GenerateId()
		{
			string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			StringBuilder result = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				result.Append(characters[random.Next(characters.Length)]);
			}
			return result.ToString();
		}
	}
}
