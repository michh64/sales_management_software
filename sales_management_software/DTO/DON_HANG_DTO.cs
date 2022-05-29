using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class DON_HANG_DTO
	{
		private string _madh;
		public string madh
		{
			get { return _madh; }
			set { _madh = value; }
		}

		private string _makh;
		public string makh
		{
			get { return _makh; }
			set { _makh = value; }
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


		public DON_HANG_DTO(string madh_, string makh_, DateTime ngaydat_, DateTime ngaygiao_, string diachigiao_, bool deleted_, string masp_, string tensp_, int dongia_, int soluong_)
		{
			this.madh = madh_;
			this.makh = makh_;
			this.ngaydat = ngaydat_;
			this.ngaygiao = ngaygiao_;
			this.diachigiao = diachigiao_;
			this.deleted = deleted_;
			this.masp = masp_;
			this.tensp = tensp_;
			this.dongia = dongia_;
			this.soluong = soluong_;
		}
		public DON_HANG_DTO()
		{

		}
	}

}
