using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Media.Data
{
	[System.Serializable()]

	public class Artist
	{
		//*********************************************************************************************************
		#region constructors

		public Artist()
		{
			this.albums = new List<Album>();
		}

		#endregion

		//*********************************************************************************************************
		#region Properties
		public string Name { get; set; }

		public string Country { get; set; }



		private List<Album> albums;

		public List<Album> MyProperty
		{
			get { return Albums; }
			set { Albums = value; }

		}
		#endregion


	}
}
