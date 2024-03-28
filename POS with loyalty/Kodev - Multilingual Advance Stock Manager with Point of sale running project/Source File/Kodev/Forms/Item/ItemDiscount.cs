using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kodev.Forms.Item
{
    public partial class ItemDiscount : Form
    {
        public ItemDiscount()
        {
            InitializeComponent();
            clsUtility.FillDataGrid(" SELECT iteminformation.ItemName, Dis_percentage.item_id,Discount_percentage, Start_Date,End_Date FROM  Dis_percentage  inner JOIN iteminformation ON iteminformation.Item_ID = Dis_percentage.item_id ", Discout1);
            clsUtility.FillDataGrid(" SELECT iteminformation.ItemName, Dis_Product.item_id,Discount_item, Quantity,Self FROM  Dis_Product  inner JOIN iteminformation ON iteminformation.Item_ID = Dis_Product.item_id ", Discount2);

        }

    }
}
