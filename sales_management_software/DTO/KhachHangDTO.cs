using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class KhachHangDTO
	{
		private string _MaKH;
		public string MaKH
		{
			get { return _MaKH; }
			set { _MaKH = value; }
		}

		private string _TenKH;
		public string TenKH
		{
			get { return _TenKH; }
			set { _TenKH = value; }
		}

		private string _DienThoai;
		public string DienThoai
		{
			get { return _DienThoai; }
			set { _DienThoai = value; }
		}

		private string _DiaChi;
		public string DiaChi
		{
			get { return _DiaChi; }
			set { _DiaChi = value; }
		}

		private bool _TrangThai;
		public bool TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}


		public KhachHangDTO(string MaKH_, string TenKH_, string DienThoai_, string DiaChi_, bool TrangThai_)
		{
			this.MaKH = MaKH_;
			this.TenKH = TenKH_;
			this.DienThoai = DienThoai_;
			this.DiaChi = DiaChi_;
			this.TrangThai = TrangThai_;
		}
		public KhachHangDTO()
		{
			
		}
	}
}
