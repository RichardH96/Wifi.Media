using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Media.Data
{
	[System.Serializable()]
	public class Album
	{


		//*********************************************************************************************************
		#region constructors

		public Album()
		{
			this.songs = new List<Song>();
		}

		
		#endregion

		//*********************************************************************************************************
		#region Properties
		public string Name { get; set; }

		public DateTime ReleaseDate { get; set; }

		public string Genere { get; set; }



		private List<Song> songs;

		public List<Song> MyProperty
		{
			get { return Songs; }
			set { Songs = value; }

		}

		#endregion









	}
}
