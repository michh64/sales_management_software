using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class NhanVienDTO
	{
		private string _MaNV;
		public string MaNV
		{
			get { return _MaNV; }
			set { _MaNV = value; }
		}

		private string _Ho;
		public string Ho
		{
			get { return _Ho; }
			set { _Ho = value; }
		}

		private string _Ten;
		public string Ten
		{
			get { return _Ten; }
			set { _Ten = value; }
		}

		private DateTime _NgaySinh;
		public DateTime NgaySinh
		{
			get { return _NgaySinh; }
			set { _NgaySinh = value; }
		}

		private DateTime _NgayThue;
		public DateTime NgayThue
		{
			get { return _NgayThue; }
			set { _NgayThue = value; }
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

		private string _TaiKhoan;
		public string TaiKhoan
		{
			get { return _TaiKhoan; }
			set { _TaiKhoan = value; }
		}

		private string _MatKhau;
		public string MatKhau
		{
			get { return _MatKhau; }
			set { _MatKhau = value; }
		}


		public NhanVienDTO(string MaNV_, string Ho_, string Ten_, DateTime NgaySinh_, DateTime NgayThue_, string DiaChi_, string SoDienThoai_, bool TrangThai_, string TaiKhoan_, string MatKhau_)
		{
			this.MaNV = MaNV_;
			this.Ho = Ho_;
			this.Ten = Ten_;
			this.NgaySinh = NgaySinh_;
			this.NgayThue = NgayThue_;
			this.DiaChi = DiaChi_;
			this.SoDienThoai = SoDienThoai_;
			this.TrangThai = TrangThai_;
			this.TaiKhoan = TaiKhoan_;
			this.MatKhau = MatKhau_;
		}
		public NhanVienDTO()
		{
			
		}
	}
}
