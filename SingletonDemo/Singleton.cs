using System;

namespace SingletonDemo
{
	public sealed class Singleton
	{
		private static int counter = 0;

		private Singleton()
		{
			counter++;
			System.Console.WriteLine("Counter Value " + counter.ToString());
		}

		private static readonly Lazy<Singleton> InstanceLock = new Lazy<Singleton>(() => new Singleton());

		public static Singleton GetInstance
		{
			get
			{
				return InstanceLock.Value;
			}
		}

		public void PrintDetails(string message)
		{
			System.Console.WriteLine(message);
		}
	}
}