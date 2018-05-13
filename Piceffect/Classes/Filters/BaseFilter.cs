using System;
using System.Drawing;
using System.Collections.Generic;

namespace Piceffect
{
	public abstract class BaseFilter : IFilter
	{
		public virtual string HandlerName => "";

		public Bitmap Source { get; set; }

		public virtual Bitmap Result { get; }

		public virtual void Init(SortedList<string, object> parameters)
		{
			throw new NotImplementedException();
		}

		public virtual void StartHandle()
		{
			throw new NotImplementedException();
		}

		protected byte Limit(double value)
		{
			return (byte)((value < 0) ? 0 : (value > 255) ? 255 : value);
		}

		protected byte Limit(float value)
		{
			return (byte)((value < 0) ? 0 : (value > 255) ? 255 : value);
		}
	}
}
