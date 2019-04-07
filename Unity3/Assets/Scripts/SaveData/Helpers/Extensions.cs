using System;

namespace FPS.Data
{
	public static class Extensions
	{
		public static bool TryBool(this string self)
		{
			bool result;
			return Boolean.TryParse(self, out result) && result;
		}
	}
}
