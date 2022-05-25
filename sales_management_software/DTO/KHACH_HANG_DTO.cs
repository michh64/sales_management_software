using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class KHACH_HANG_DTO
	{
		private string _makh;
		public string makh
		{
			get { return _makh; }
			set { _makh = value; }
		}

		private string _tenkh;
		public string tenkh
		{
			get { return _tenkh; }
			set { _tenkh = value; }
		}

		private string _sdt;
		public string sdt
		{
			get { return _sdt; }
			set { _sdt = value; }
		}

		private string _diachi;
		public string diachi
		{
			get { return _diachi; }
			set { _diachi = value; }
		}

		private bool _deleted;
		public bool deleted
		{
			get { return _deleted; }
			set { _deleted = value; }
		}


		public KHACH_HANG_DTO(string makh_, string tenkh_, string sdt_, string diachi_, bool deleted_)
		{
			this.makh = makh_;
			this.tenkh = tenkh_;
			this.sdt = sdt_;
			this.diachi = diachi_;
			this.deleted = deleted_;
		}
		public KHACH_HANG_DTO()
        {

        }
	}

}
