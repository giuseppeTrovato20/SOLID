using System;
namespace SOLID.ISP
{
	public class UserPanel
    {
		public UserPanel()
		{
		}

		User user = new User("Giuseppe", "Trovato", 250, "saincnjsasaijnvjdas");

		public void renderUserPanel()
		{
			//impostazioni
			//name
			//balance
			ImageRenderer img = new ImageRenderer(user.imgBase64);
		}
	}
}

