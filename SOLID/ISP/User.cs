using System;
namespace SOLID.ISP
{
	public class User
	{
		string name;
		string surname;
		int balance;
		public string imgBase64 { get; set; }

		public User(string name, string surname, int balance, string imgBase64)
		{
			this.name = name;
			this.surname = surname;
			this.balance = balance;
			this.imgBase64 = imgBase64;
        }
	}
}

