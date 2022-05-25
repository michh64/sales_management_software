using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class SHIPPER_DTO
	{
		private string _mashiper;
		public string mashiper
		{
			get { return _mashiper; }
			set { _mashiper = value; }
		}

		private string _tenshipper;
		public string tenshipper
		{
			get { return _tenshipper; }
			set { _tenshipper = value; }
		}

		private string _madh;
		public string madh
		{
			get { return _madh; }
			set { _madh = value; }
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


		public SHIPPER_DTO(string mashiper_, string tenshipper_, string madh_, string sdt_, bool deleted_)
		{
			this.mashiper = mashiper_;
			this.tenshipper = tenshipper_;
			this.madh = madh_;
			this.sdt = sdt_;
			this.deleted = deleted_;
		}
		public SHIPPER_DTO()
        {

        }
	}
}

