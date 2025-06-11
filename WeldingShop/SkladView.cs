using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecClothes
{
    public class SkladView : Button
    {
        public int ID { get; set; }
        public int number { get; set; }
        public string address { get; set; }

        public virtual ICollection<WearViewItem> Products { get; set; }

        public SkladView()
        {
            Products = new List<WearViewItem>();

            //BackgroundImageLayout = ImageLayout.Zoom;
            //BackgroundImage = new Bitmap("D:\\Загрузки\\img_sklad.png");
            Image = new Bitmap("D:\\Загрузки\\sklad-small.png");
            ImageAlign = ContentAlignment.TopCenter;
            TextAlign = ContentAlignment.BottomCenter;
            Font = new Font("Georgia", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = Color.NavajoWhite;
            Size = new Size(50, 50);
            Margin = new Padding(5);
            Padding = new Padding(3);
        }

        public override bool Equals(object obj)
        {
            return this.ID == (obj as SkladView).ID;
        }

    }
}
