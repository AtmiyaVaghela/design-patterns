﻿namespace FactoryMethodDesignPattern
{
	public class PlatinumFactory : CreditCardFactory
	{
		protected override ICreditCard MakeProduct()
		{
			ICreditCard product = new Platinum();
			return product;
		}
	}
}