using System.Runtime;

namespace CompanyLib
{
    [Serializable]
    public class Car:Attribute
    {
		private string Cname;
		private int _price;

		public int Price
		{
			get { return _price; }
			set { _price = value; }
		}


		public string Name
		{
			get { return Cname; }
			set { Cname = value; }
		}

	}
}
