﻿namespace BuilderDesignPatternExample
{
	public abstract class BeverageBuilder : IBeverageBuilder
	{
		protected Beverage beverage;

		public void CreateBeverage()
		{
			beverage = new Beverage();
		}

		public Beverage GetBeverage()
		{
			return beverage;
		}

		public abstract void SetBeverageType();

		public abstract void SetWater();

		public abstract void SetMilk();

		public abstract void SetSugar();

		public abstract void SetPowderQuantity();
	}
}