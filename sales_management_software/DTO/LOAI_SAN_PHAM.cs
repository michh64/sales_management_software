using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class LOAI_SAN_PHAM_DTO
	{
		private string _maloai;
		public string maloai
		{
			get { return _maloai; }
			set { _maloai = value; }
		}

		private string _tenloai;
		public string tenloai
		{
			get { return _tenloai; }
			set { _tenloai = value; }
		}

		private bool _deleted;
		public bool deleted
		{
			get { return _deleted; }
			set { _deleted = value; }
		}


		public LOAI_SAN_PHAM_DTO(string maloai_, string tenloai_, bool deleted_)
		{
			this.maloai = maloai_;
			this.tenloai = tenloai_;
			this.deleted = deleted_;
		}
	
	    public LOAI_SAN_PHAM_DTO()
		{
			
		}

	}
}
