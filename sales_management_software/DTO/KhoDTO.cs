using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
    public class KhoDTO
    {
		public KhoDTO()
		{

		}
		private string _MaKho;
		public string MaKho
		{
			get { return _MaKho; }
			set { _MaKho = value; }
		}

		private string _MaSP;
		public string MaSP
		{
			get { return _MaSP; }
			set { _MaSP = value; }
		}

		private int _SoLuongTonKho;
		public int SoLuongTonKho
		{
			get { return _SoLuongTonKho; }
			set { _SoLuongTonKho = value; }
		}

		private bool _TrangThai;
		public bool TrangThai
		{
			get { return _TrangThai; }
			set { _TrangThai = value; }
		}


		public KhoDTO(string MaKho_, string MaSP_, int SoLuongTonKho_, bool TrangThai_)
		{
			this.MaKho = MaKho_;
			this.MaSP = MaSP_;
			this.SoLuongTonKho = SoLuongTonKho_;
			this.TrangThai = TrangThai_;
		}
	}
}
