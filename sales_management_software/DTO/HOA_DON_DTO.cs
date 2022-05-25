using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{

		public class HOA_DON_DTO
		{
			private string _mahd;
			public string mahd
			{
				get { return _mahd; }
				set { _mahd = value; }
			}

			private string _masp;
			public string masp
			{
				get { return _masp; }
				set { _masp = value; }
			}

			private string _tensp;
			public string tensp
			{
				get { return _tensp; }
				set { _tensp = value; }
			}

			private int _dongia;
			public int dongia
			{
				get { return _dongia; }
				set { _dongia = value; }
			}

			private int _giamgia;
			public int giamgia
			{
				get { return _giamgia; }
				set { _giamgia = value; }
			}

			private int _soluong;
			public int soluong
			{
				get { return _soluong; }
				set { _soluong = value; }
			}

			private int _tongtien;
			public int tongtien
			{
				get { return _tongtien; }
				set { _tongtien = value; }
			}

			private bool _deleted;
			public bool deleted
			{
				get { return _deleted; }
				set { _deleted = value; }
			}


			public HOA_DON_DTO(string mahd_, string masp_, string tensp_, int dongia_, int giamgia_, int soluong_, int tongtien_, bool deleted_)
			{
				this.mahd = mahd_;
				this.masp = masp_;
				this.tensp = tensp_;
				this.dongia = dongia_;
				this.giamgia = giamgia_;
				this.soluong = soluong_;
				this.tongtien = tongtien_;
				this.deleted = deleted_;
			}
			public HOA_DON_DTO()
            {

            }
		}
	
}
