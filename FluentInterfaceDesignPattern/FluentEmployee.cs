using System;

namespace FluentInterfaceDesignPattern
{
	internal class FluentEmployee
	{
		private Employee employee = new Employee();

		public FluentEmployee()
		{
		}

		internal object NameOfTheEmployee(string fullName)
		{
			employee.FullName = fullName;
			return this;
		}

		public FluentEmployee Born(string DateOfBirth)
		{
			employee.DateOfBirth = Convert.ToDateTime(DateOfBirth);
			return this;
		}

		public FluentEmployee WorkingOn(string Department)
		{
			employee.Department = Department;
			return this;
		}

		public FluentEmployee StaysAt(string Address)
		{
			employee.Address = Address;
			return this;
		}
	}
}