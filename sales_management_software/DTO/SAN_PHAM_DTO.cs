using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class SAN_PHAM_DTO
	{
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

		private int _soluong;
		public int soluong
		{
			get { return _soluong; }
			set { _soluong = value; }
		}

		private string _maNCC;
		public string maNCC
		{
			get { return _maNCC; }
			set { _maNCC = value; }
		}

		private string _maloai;
		public string maloai
		{
			get { return _maloai; }
			set { _maloai = value; }
		}

		private bool _deleted;
		public bool deleted
		{
			get { return _deleted; }
			set { _deleted = value; }
		}


		public SAN_PHAM_DTO(string masp_, string tensp_, int dongia_, int soluong_, string maNCC_, string maloai_, bool deleted_)
		{
			this.masp = masp_;
			this.tensp = tensp_;
			this.dongia = dongia_;
			this.soluong = soluong_;
			this.maNCC = maNCC_;
			this.maloai = maloai_;
			this.deleted = deleted_;
		}
		public SAN_PHAM_DTO()
		{

		}
	}

}
