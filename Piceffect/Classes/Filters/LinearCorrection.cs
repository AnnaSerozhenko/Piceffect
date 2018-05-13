using System;
using System.Drawing;

namespace Piceffect
{
	public class LinearCorrection : BaseFilter
	{
		//имя фильтра
		public override string HandlerName => "LinearCorrection";

		//внутреннее изображение
		private Bitmap Picture;

		public override Bitmap Result { get => Picture; }

		//обработка
		public override void StartHandle()
		{
			byte min = 255, max = 0;
			FastBitmap Image = new FastBitmap(Source);
			Pixel pixel;
			for (int y = 0; y < Image.Height; ++y)
			{
				for (int x = 0; x < Image.Width; ++x)
				{
					pixel = Image.GetPixel(x, y);
					min = Math.Min(min, (byte)((pixel.R + pixel.G + pixel.B) / 3));
					max = Math.Max(max, (byte)((pixel.R + pixel.G + pixel.B) / 3));
				}
			}
			float coefficient = 255f / (max - min);
			for (int y = 0; y < Image.Height; ++y)
			{
				for (int x = 0; x < Image.Width; ++x)
				{
					pixel = Image.GetPixel(x, y);
					pixel.R = Limit((pixel.R - min) * coefficient);
					pixel.G = Limit((pixel.G - min) * coefficient);
					pixel.B = Limit((pixel.B - min) * coefficient);
					Image.SetPixel(x, y, pixel);
				}
			}
			Picture = Image.GetBitmap();
		}
	}
}