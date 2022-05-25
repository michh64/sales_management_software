using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
		public class THONG_SO_KY_THUAT_DTO
		{
			private string _mats;
			public string mats
			{
				get { return _mats; }
				set { _mats = value; }
			}

			private string _tents;
			public string tents
			{
				get { return _tents; }
				set { _tents = value; }
			}

			private string _masp;
			public string masp
			{
				get { return _masp; }
				set { _masp = value; }
			}

			private string _giatri;
			public string giatri
			{
				get { return _giatri; }
				set { _giatri = value; }
			}

			private bool _deleted;
			public bool deleted
			{
				get { return _deleted; }
				set { _deleted = value; }
			}


			public THONG_SO_KY_THUAT_DTO(string mats_, string tents_, string masp_, string giatri_, bool deleted_)
			{
				this.mats = mats_;
				this.tents = tents_;
				this.masp = masp_;
				this.giatri = giatri_;
				this.deleted = deleted_;
			}
			public THONG_SO_KY_THUAT_DTO()
            {

            }
		}
	
}
