using System;
namespace SOLID.ISP
{
	public class ImageRenderer
	{
		string imgBase64;

		public ImageRenderer(string imgBase64)
		{
			this.imgBase64 = imgBase64;
		}


		public void  renderImage()
		{
			Console.WriteLine(imgBase64);
		}
	}
}

