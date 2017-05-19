using System;

namespace Decorator
{
	public class Mocha : CondimentDecorator
	{
		Beverage beverage;

		public Mocha (Beverage beverage)
		{
			this.beverage = beverage;
		}

		public string getDescription()
		{
			return beverage.getDescription () + ", Mocha";
		}

		public double cost()
		{
			return .20 + beverage.cost ();
		}
	}
}

