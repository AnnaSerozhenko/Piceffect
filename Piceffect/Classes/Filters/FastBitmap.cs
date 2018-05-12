using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Piceffect
{
	public class FastBitmap
	{
		private byte[] data;
		private int stride;
		private int width;
		private int height;

		public int Width { get => width; }
		public int Height { get => height; }

		public FastBitmap(Bitmap image)
		{
			BitmapData bits = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
			stride = bits.Stride;
			int bytes = stride * bits.Height;
			data = new byte[bytes];
			Marshal.Copy(bits.Scan0, data, 0, bytes);
			image.UnlockBits(bits);
			width = image.Width;
			height = image.Height;
		}

		public Pixel GetPixel(int x, int y)
		{
			Pixel color = new Pixel();
			int position = y * stride + x * 4;
			color.B = data[position++];
			color.G = data[position++];
			color.R = data[position++];
			color.A = data[position++];
			return color;
		}

		public void SetPixel(int x, int y, byte r, byte g, byte b, byte a = 255)
		{
			int position = y * stride + x * 4;
			data[position++] = b;
			data[position++] = g;
			data[position++] = r;
			data[position++] = a;
		}

		public void SetPixel(int x, int y, Pixel pixel)
		{
			int position = y * stride + x * 4;
			data[position++] = pixel.B;
			data[position++] = pixel.G;
			data[position++] = pixel.R;
			data[position++] = pixel.A;
		}

		public void SwapPixels(int x, int y, int newX, int newY)
		{
			Pixel color = GetPixel(x, y);
			SetPixel(x, y, GetPixel(newX, newY));
			SetPixel(newX, newY, color);
		}

		public Bitmap GetBitmap()
		{
			Bitmap result = new Bitmap(width, height);
			BitmapData bits = result.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
			Marshal.Copy(data, 0, bits.Scan0, data.Length);
			result.UnlockBits(bits);
			return result;
		}
	}

	public struct Pixel
	{
		public Pixel(byte r, byte g, byte b)
		{
			R = r;
			G = g;
			B = b;
			A = 255;
		}
		public Pixel(byte r, byte g, byte b, byte a)
		{
			R = r;
			G = g;
			B = b;
			A = a;
		}
		public byte B;
		public byte G;
		public byte R;
		public byte A;
	}
}
