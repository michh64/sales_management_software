using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{

	public class NHA_CUNG_CAP_DTO
	{
		private string _maNCC;
		public string maNCC
		{
			get { return _maNCC; }
			set { _maNCC = value; }
		}

		private string _tencty;
		public string tencty
		{
			get { return _tencty; }
			set { _tencty = value; }
		}

		private string _diachi;
		public string diachi
		{
			get { return _diachi; }
			set { _diachi = value; }
		}

		private string _sdt;
		public string sdt
		{
			get { return _sdt; }
			set { _sdt = value; }
		}

		private bool _deleted;
		public bool deleted
		{
			get { return _deleted; }
			set { _deleted = value; }
		}


		public NHA_CUNG_CAP_DTO(string maNCC_, string tencty_, string diachi_, string sdt_, bool deleted_)
		{
			this.maNCC = maNCC_;
			this.tencty = tencty_;
			this.diachi = diachi_;
			this.sdt = sdt_;
			this.deleted = deleted_;
		}
	
	    public NHA_CUNG_CAP_DTO()
		{
			
		}
	}
}
