using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software.DTO
{
		public class DON_HANG_DTO
		{
			private string _madh;
			public string madh
			{
				get { return _madh; }
				set { _madh = value; }
			}

			private string _mahd;
			public string mahd
			{
				get { return _mahd; }
				set { _mahd = value; }
			}

			private string _makh;
			public string makh
			{
				get { return _makh; }
				set { _makh = value; }
			}

			private string _manv;
			public string manv
			{
				get { return _manv; }
				set { _manv = value; }
			}

			private string _mashiper;
			public string mashiper
			{
				get { return _mashiper; }
				set { _mashiper = value; }
			}

			private DateTime _ngaydat;
			public DateTime ngaydat
			{
				get { return _ngaydat; }
				set { _ngaydat = value; }
			}

			private DateTime _ngaygiao;
			public DateTime ngaygiao
			{
				get { return _ngaygiao; }
				set { _ngaygiao = value; }
			}

			private string _diachigiao;
			public string diachigiao
			{
				get { return _diachigiao; }
				set { _diachigiao = value; }
			}

			private bool _deleted;
			public bool deleted
			{
				get { return _deleted; }
				set { _deleted = value; }
			}


			public DON_HANG_DTO(string madh_, string mahd_, string makh_, string manv_, string mashiper_, DateTime ngaydat_, DateTime ngaygiao_, string diachigiao_, bool deleted_)
			{
				this.madh = madh_;
				this.mahd = mahd_;
				this.makh = makh_;
				this.manv = manv_;
				this.mashiper = mashiper_;
				this.ngaydat = ngaydat_;
				this.ngaygiao = ngaygiao_;
				this.diachigiao = diachigiao_;
				this.deleted = deleted_;
			}
			public DON_HANG_DTO()
            {

            }
		}
	
}
