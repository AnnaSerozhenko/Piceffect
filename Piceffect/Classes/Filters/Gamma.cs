using System;
using System.Drawing;
using System.Collections.Generic;

namespace Piceffect
{
	public class Gamma : BaseFilter
	{
		//имя фильтра
		public override string HandlerName => "Gamma";

		//внутреннее изображение
		private Bitmap Picture;

		public override Bitmap Result { get => Picture; }

		//инициализация
		public override void Init(SortedList<string, object> parameters)
		{
			gamma = 1 / (float)parameters["gamma"];
		}

		//степень коррекции
		float gamma;

		//обработка
		public override void StartHandle(ProgressDelegate progress)
		{
			FastBitmap Source = new FastBitmap(this.Source);
			FastBitmap Image = new FastBitmap(new Bitmap(Source.Width, Source.Height));
			Pixel color;
			//long count = 0;
			for (int y = 0; y < Source.Height; ++y)
			{
				for (int x = 0; x < Source.Width; ++x)
				{
					color = Source.GetPixel(x, y);
					byte r = Limit(Math.Pow(color.R / 255.0, gamma) * 255 + 0.5);
					byte g = Limit(Math.Pow(color.G / 255.0, gamma) * 255 + 0.5);
					byte b = Limit(Math.Pow(color.B / 255.0, gamma) * 255 + 0.5);
					Image.SetPixel(x, y, r, g, b);
					//progress((double)(++count) / (Source.Width * Source.Height));
				}
			}
			Picture = Image.GetBitmap();
		}
	}
}
