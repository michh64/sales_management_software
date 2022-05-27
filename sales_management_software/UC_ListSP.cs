using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sales_management_software
{
    public partial class UC_ListSP : UserControl
    {
        List<SAN_PHAM_DTO> listSP = SAN_PHAM_BLL.EF_GetAll();
        public UC_ListSP()
        {
            InitializeComponent();
            LoadDirectory();
        }
        private void LoadDirectory()
        {
            List<Image> LoadedImages = new List<Image>();

            for (int i = 0; i < listSP.Count; i++)
            {
                LoadedImages.Add(SpecFunctions.Base64toImage(listSP[i].anhsp));
            }

            // initializing images list
            ImageList images = new ImageList();
            images.ImageSize = new Size(128, 128);

            // Convert form List to ImageList 
            foreach (var image in LoadedImages)
            {
                images.Images.Add(image);
            }

            // setting our listview with the imagelist
            listView1.LargeImageList = images;

            for (int i = 0; i < LoadedImages.Count; i++)
            {
                listView1.Items.Add(new ListViewItem($"{listSP[i].tensp} \n{listSP[i].dongia.ToString("0,000")}đ", i));
            }

        }

    }
}
