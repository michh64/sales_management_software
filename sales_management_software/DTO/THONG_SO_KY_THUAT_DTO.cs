using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_management_software
{
	public class THONG_SO_KY_THUAT_DTO
	{
		private bool _deleted;
		public bool deleted
		{
			get { return _deleted; }
			set { _deleted = value; }
		}

		private string _manhinh;
		public string manhinh
		{
			get { return _manhinh; }
			set { _manhinh = value; }
		}

		private string _camera;
		public string camera
		{
			get { return _camera; }
			set { _camera = value; }
		}

		private string _chipset;
		public string chipset
		{
			get { return _chipset; }
			set { _chipset = value; }
		}

		private string _ram;
		public string ram
		{
			get { return _ram; }
			set { _ram = value; }
		}

		private string _pin;
		public string pin
		{
			get { return _pin; }
			set { _pin = value; }
		}

		private string _memory;
		public string memory
		{
			get { return _memory; }
			set { _memory = value; }
		}

		private string _mats;
		public string mats
		{
			get { return _mats; }
			set { _mats = value; }
		}


		public THONG_SO_KY_THUAT_DTO(bool deleted_, string manhinh_, string camera_, string chipset_, string ram_, string pin_, string memory_, string mats_)
		{
			this.deleted = deleted_;
			this.manhinh = manhinh_;
			this.camera = camera_;
			this.chipset = chipset_;
			this.ram = ram_;
			this.pin = pin_;
			this.memory = memory_;
			this.mats = mats_;
		}

		public THONG_SO_KY_THUAT_DTO()
        {

        }
	}
}
