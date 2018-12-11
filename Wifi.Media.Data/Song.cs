using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Media.Data
{
	[System.Serializable()]

	public class Song
	{
		//*********************************************************************************************************
		#region Properties
		public int TrackNr { get; set; }

		public string Name { get; set; }

		public TimeSpan Duration { get; set; }

		public string Language { get; set; }
		#endregion

	}
}
