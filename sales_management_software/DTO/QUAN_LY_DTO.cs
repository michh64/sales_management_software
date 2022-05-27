using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class QUAN_LY_DTO
	{
		private string _maql;
		public string maql
		{
			get { return _maql; }
			set { _maql = value; }
		}

		private string _tenql;
		public string tenql
		{
			get { return _tenql; }
			set { _tenql = value; }
		}

		private string _username;
		public string username
		{
			get { return _username; }
			set { _username = value; }
		}

		private string _pass;
		public string pass
		{
			get { return _pass; }
			set { _pass = value; }
		}


		public QUAN_LY_DTO(string maql_, string tenql_, string username_, string pass_)
		{
			this.maql = maql_;
			this.tenql = tenql_;
			this.username = username_;
			this.pass = pass_;
		}

		public QUAN_LY_DTO()
        {

        }
	}
}
