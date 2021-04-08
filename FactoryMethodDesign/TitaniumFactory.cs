namespace FactoryMethodDesignPattern
{
	public class TitaniumFactory : CreditCardFactory
	{
		protected override ICreditCard MakeProduct()
		{
			ICreditCard product = new Titanium();
			return product;
		}
	}
}