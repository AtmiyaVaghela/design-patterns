using System;

namespace FactoryDesignPattern
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//Generally we will get the Card Type from UI.
			//Here we are hardcoded the card type

			ICreditCard cardDetails = CreditCardFactory.GetCreditCard("MoneyBack");

			if (cardDetails != null)
			{
				Console.WriteLine("CardType : " + cardDetails.GetCardType());
				Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
				Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
			}
			else
			{
				Console.Write("Invalid Card Type");
			}
			Console.ReadLine();
		}
	}
}