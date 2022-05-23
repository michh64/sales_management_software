using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class ShipperDTO
	{
		private string _MaShipper;
		public string MaShipper
		{
			get { return _MaShipper; }
			set { _MaShipper = value; }
		}

		private string _Ten;
		public string Ten
		{
			get { return _Ten; }
			set { _Ten = value; }
		}

		private string _SoDienThoai;
		public string SoDienThoai
		{
			get { return _SoDienThoai; }
			set { _SoDienThoai = value; }
		}

		private bool _TrangThai;
		public bool TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}

		private string _MaHD;
		public string MaHD
		{
			get { return _MaHD; }
			set { _MaHD = value; }
		}


		public ShipperDTO(string MaShipper_, string Ten_, string SoDienThoai_, bool TrangThai_, string MaHD_)
		{
			this.MaShipper = MaShipper_;
			this.Ten = Ten_;
			this.SoDienThoai = SoDienThoai_;
			this.TrangThai = TrangThai_;
			this.MaHD = MaHD_;
		}
		public ShipperDTO()
		{
			
		}
	}
}
