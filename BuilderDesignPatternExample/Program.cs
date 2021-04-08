using System;

namespace BuilderDesignPatternExample
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Beverage beverage;
			BeverageDirector beverageDirector = new BeverageDirector();

			TeaBuilder tea = new TeaBuilder();
			beverage = beverageDirector.MakeBeverage(tea);
			Console.WriteLine(beverage.ShowBeverage());

			CoffeeBuilder coffee = new CoffeeBuilder();
			beverage = beverageDirector.MakeBeverage(coffee);
			Console.WriteLine(beverage.ShowBeverage());
			Console.ReadKey();
		}
	}
}