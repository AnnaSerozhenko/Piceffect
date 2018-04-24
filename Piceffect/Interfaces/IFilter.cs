using System.Drawing;
using System.Collections.Generic;

namespace Piceffect
{
	//указатель на функцию обработки прогресса выполнения задачи
	public delegate void ProgressDelegate(double percent);

	interface IFilter
	{
		//получение имени обработчика
		string HandlerName { get; }

		//инициализация параметров обработчика
		void Init(SortedList<string, object> parameters);

		//установка изображения-источника
		Bitmap Source { set; }

		//получение изображения-результата
		Bitmap Result { get; }

		//Запуск обработки
		void StartHandle(ProgressDelegate progress);
	}
}
