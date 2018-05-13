using System;
using System.Drawing;
using System.Collections.Generic;

namespace Piceffect
{
	public class NonlinearCorrection : BaseFilter
	{
		//имя фильтра
		public override string HandlerName => "NonlinearCorrection";

		//внутреннее изображение
		private Bitmap Picture;

		public override Bitmap Result { get => Picture; }

		//инициализация
		public override void Init(SortedList<string, object> parameters)
		{
			coefficient = float.Parse(parameters["coefficient"].ToString());
		}

		float coefficient;

		//обработка
		public override void StartHandle()
		{
			FastBitmap Image = new FastBitmap(Source);
			Pixel pixel;
			for (int y = 0; y < Image.Height; ++y)
			{
				for (int x = 0; x < Image.Width; ++x)
				{
					pixel = Image.GetPixel(x, y);
                    pixel.R = Limit(coefficient * Math.Log(1 + pixel.R) / Math.Log(2));
					pixel.G = Limit(coefficient * Math.Log(1 + pixel.G) / Math.Log(2));
					pixel.B = Limit(coefficient * Math.Log(1 + pixel.B) / Math.Log(2));
					Image.SetPixel(x, y, pixel);
				}
			}
			Picture = Image.GetBitmap();
		}
	}
}