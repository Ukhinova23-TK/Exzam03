using System;
using System.Collections.Generic;
using System.Text;

namespace src
{
    class Bus
    {
		private int _numberRoute;
		private string _endStop1;
		private string _endStop2;
		private int _countStop;

		public int NumberRoute
		{
			get { return _numberRoute; }
			set { this._numberRoute = Convert.ToInt32(value); }
		}

		public string EndStop1
		{
			get { return _endStop1; }
			set { this._endStop1 = value; }
		}

		public string EndStop2
		{
			get { return _endStop2; }
			set { this._endStop2 = value; }
		}

		public int CountStop
		{
			get { return _countStop; }
			set { this._countStop = Convert.ToInt32(value); }
		}

		public Bus() { }
	}
}
