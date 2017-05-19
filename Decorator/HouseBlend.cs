using System;

namespace Decorator
{
	public class HouseBlend : Beverage
	{
		public HouseBlend ()
		{
			description = "House Blend Coffee";
		}

		public double cost()
		{
			return .89;
		}
	}
}
