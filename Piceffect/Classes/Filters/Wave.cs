using System;
using System.Drawing;

namespace Piceffect
{
	public class Wave : BaseFilter
	{
		//имя фильтра
		public override string HandlerName => "Wave";

		//внутреннее изображение
		private Bitmap Picture;

		public override Bitmap Result { get => Picture; }

		//обработка
		public override void StartHandle()
		{
			FastBitmap Source = new FastBitmap(this.Source);
			FastBitmap Image = new FastBitmap(new Bitmap(Source.Width, Source.Height));
			Pixel color;
			for (int y = 0; y < Source.Height; ++y)
			{
				for (int x = 0; x < Source.Width; ++x)
				{
					int position = (int)(y + 20 * Math.Sin(2 * Math.PI * y / 30));
					position = Math.Max(position, 0);
					position = Math.Min(position, Source.Height - 1);
					color = Source.GetPixel(x, position);
					Image.SetPixel(x, y, color);
				}
			}
			Picture = Image.GetBitmap();
		}
	}
}
