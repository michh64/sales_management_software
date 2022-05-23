using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class LoaiSanPhamDTO
	{
		private string _MaLSP;
		public string MaLSP
		{
			get { return _MaLSP; }
			set { _MaLSP = value; }
		}

		private string _TenLSP;
		public string TenLSP
		{
			get { return _TenLSP; }
			set { _TenLSP = value; }
		}


		public LoaiSanPhamDTO(string MaLSP_, string TenLSP_)
		{
			this.MaLSP = MaLSP_;
			this.TenLSP = TenLSP_;
		}
		public LoaiSanPhamDTO()
		{
			
		}

	}
}
