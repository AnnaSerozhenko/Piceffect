using System;
using System.Drawing;
using System.Collections.Generic;

namespace Piceffect
{
	public class Noise : BaseFilter
	{
		//имя фильтра
		public override string HandlerName => "Noise";

		//внутреннее изображение
		private Bitmap Picture;

		public override Bitmap Result { get => Picture; }

		//инициализация
		public override void Init(SortedList<string, object> parameters)
		{
			strength = (int)parameters["strength"];
			scale = float.Parse(parameters["scale"].ToString());
		}

		//параметры фильтра
		int strength;
		float scale;

		//обработка
		public override void StartHandle()
		{
			FastBitmap Image = new FastBitmap(Source);
			Pixel color;
			Random random = new Random();
			int size = (int)(Image.Width * Image.Height * scale);
			for (int i = 0; i < size; ++i)
			{
				int x = random.Next(0, Image.Width);
				int y = random.Next(0, Image.Height);
				color = Image.GetPixel(x, y);
				int shift = random.Next(-strength, strength);
				byte r = Limit(color.R + shift);
				byte g = Limit(color.G + shift);
				byte b = Limit(color.B + shift);
				Image.SetPixel(x, y, r, g, b);
			}
			Picture = Image.GetBitmap();
		}
	}
}
