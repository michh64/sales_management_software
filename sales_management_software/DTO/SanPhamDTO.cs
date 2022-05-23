using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class SanPhamDTO
	{
		private string _MaSP;
		public string MaSP
		{
			get { return _MaSP; }
			set { _MaSP = value; }
		}

		private string _TenSP;
		public string TenSP
		{
			get { return _TenSP; }
			set { _TenSP = value; }
		}

		private string _DonGia;
		public string DonGia
		{
			get { return _DonGia; }
			set { _DonGia = value; }
		}

		private string _MaNCC;
		public string MaNCC
		{
			get { return _MaNCC; }
			set { _MaNCC = value; }
		}

		private string _MaKho;
		public string MaKho
		{
			get { return _MaKho; }
			set { _MaKho = value; }
		}

		private string _MaLSP;
		public string MaLSP
		{
			get { return _MaLSP; }
			set { _MaLSP = value; }
		}

		private bool _TrangThai;
		public bool TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}


		public SanPhamDTO(string MaSP_, string TenSP_, string DonGia_, string MaNCC_, string MaKho_, string MaLSP_, bool TrangThai_)
		{
			this.MaSP = MaSP_;
			this.TenSP = TenSP_;
			this.DonGia = DonGia_;
			this.MaNCC = MaNCC_;
			this.MaKho = MaKho_;
			this.MaLSP = MaLSP_;
			this.TrangThai = TrangThai_;
		}
		public SanPhamDTO()
		{
			
		}
	}
}
