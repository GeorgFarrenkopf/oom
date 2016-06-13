using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class bike
	{
		private int rahmenSize;
		private string name;

		public bike(int size, string name)
		{
			Size = size;
			UpdateSize(size);
		}

		public int size
		{
			get
			{
				return rahmenSize;
			}
			set
			{
				if (value < 1) throw new Exception("Size muss > 0 sein");
				rahmenSize = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}            
		}

		public void UpdateName(string name)
		{
			if (string.IsNullOrWhiteSpace(name)) throw new Exception("Name darf nicht leer sein");
			this.name = name;
		}

	}
}