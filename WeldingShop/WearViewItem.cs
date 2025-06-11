using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecClothes
{
    public class WearViewItem : ListViewItem
    {
        public string article;
        public string name;
        public string type;
        public int ID_size;
        public string size;
        public decimal price;
        public decimal discount;
        public int ID_manufacturer;        
        public string manufacturer;
        public int count;
        public int ID_order;

        public override bool Equals(object obj)
        {
            return this.article == (obj as WearViewItem).article && this.size == (obj as WearViewItem).size;
        }
    }
}
