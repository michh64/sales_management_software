using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class KHO_HANG_DTO
	{
		private string _makho;
		public string makho
		{
			get { return _makho; }
			set { _makho = value; }
		}

		private string _tenkho;
		public string tenkho
		{
			get { return _tenkho; }
			set { _tenkho = value; }
		}

		private string _masp;
		public string masp
		{
			get { return _masp; }
			set { _masp = value; }
		}

		private int _soluongtonkho;
		public int soluongtonkho
		{
			get { return _soluongtonkho; }
			set { _soluongtonkho = value; }
		}

		private bool _deleted;
		public bool deleted
		{
			get { return _deleted; }
			set { _deleted = value; }
		}


		public KHO_HANG_DTO(string makho_, string tenkho_, string masp_, int soluongtonkho_, bool deleted_)
		{
			this.makho = makho_;
			this.tenkho = tenkho_;
			this.masp = masp_;
			this.soluongtonkho = soluongtonkho_;
			this.deleted = deleted_;
		}
		public KHO_HANG_DTO()
        {

        }
	}
}

