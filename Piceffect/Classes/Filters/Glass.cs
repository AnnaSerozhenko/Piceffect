using System;
using System.Drawing;

namespace Piceffect
{
	public class Glass : BaseFilter
	{
		//имя фильтра
		public override string HandlerName => "Glass";

		//внутреннее изображение
		private Bitmap Picture;

		public override Bitmap Result { get => Picture; }

		//обработка
		public override void StartHandle()
		{
			FastBitmap Image = new FastBitmap(Source);
			Random random = new Random();
			for (int y = 0; y < Image.Height; ++y)
			{
				for (int x = 0; x < Image.Width; ++x)
				{
					int newX = Math.Min(Math.Max((int)(x + random.NextDouble() * 15 - 5), 0), Image.Width - 1);
					int newY = Math.Min(Math.Max((int)(y + random.NextDouble() * 15 - 5), 0), Image.Height - 1);
					Image.SwapPixels(x, y, newX, newY);
				}
			}
			Picture = Image.GetBitmap();
		}
	}
}
