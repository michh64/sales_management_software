using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class NhaCungCapDTO
	{
		private string _MaNCC;
		public string MaNCC
		{
			get { return _MaNCC; }
			set { _MaNCC = value; }
		}

		private string _TenCongTy;
		public string TenCongTy
		{
			get { return _TenCongTy; }
			set { _TenCongTy = value; }
		}

		private string _DiaChi;
		public string DiaChi
		{
			get { return _DiaChi; }
			set { _DiaChi = value; }
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


		public NhaCungCapDTO(string MaNCC_, string TenCongTy_, string DiaChi_, string SoDienThoai_, bool TrangThai_)
		{
			this.MaNCC = MaNCC_;
			this.TenCongTy = TenCongTy_;
			this.DiaChi = DiaChi_;
			this.SoDienThoai = SoDienThoai_;
			this.TrangThai = TrangThai_;
		}
		public NhaCungCapDTO()
		{
			
		}
	}
}
