namespace FactoryMethodDesignPattern
{
	public class MoneyBackFactory : CreditCardFactory
	{
		protected override ICreditCard MakeProduct()
		{
			ICreditCard product = new MoneyBack();
			return product;
		}
	}
}