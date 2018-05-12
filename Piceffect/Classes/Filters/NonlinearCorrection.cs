using System;
using System.Drawing;

namespace Piceffect
{
	public class NonlinearCorrection : BaseFilter
	{
		//имя фильтра
		public override string HandlerName => "NonlinearCorrection";

		//внутреннее изображение
		private Bitmap Picture;

		public override Bitmap Result { get => Picture; }

		//обработка
		public override void StartHandle(ProgressDelegate progress)
		{
			float coefficient = 40f;
			FastBitmap Image = new FastBitmap(Source);
			Pixel pixel;
			//long count = 0;
			for (int y = 0; y < Image.Height; ++y)
			{
				for (int x = 0; x < Image.Width; ++x)
				{
					pixel = Image.GetPixel(x, y);
                    pixel.R = Limit(coefficient * Math.Log(1 + pixel.R) / Math.Log(2));
					pixel.G = Limit(coefficient * Math.Log(1 + pixel.G) / Math.Log(2));
					pixel.B = Limit(coefficient * Math.Log(1 + pixel.B) / Math.Log(2));
					Image.SetPixel(x, y, pixel);
					//progress((double)(++count) / (Source.Width * Source.Height * 2));
				}
			}
			Picture = Image.GetBitmap();
		}
	}
}