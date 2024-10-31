using System;
using System.Windows.Forms;

namespace CountLogic
{
    public partial class DetailsFRM : Form
    {
        public DetailsFRM()
        {
            InitializeComponent();
        }

        private void ItemDetails_Load(object sender, EventArgs e)  //when form loads
        {
            //for each item, add it to combo box
            for (int i =0; i < Form1.NumItems; i++)
            {
                ItemsCB.Items.Insert(i, Form1.ItemName[i]);
            }
            ItemsCB.SelectedIndex = 0;  //select the first item in the list
        }

        private void ItemsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when combo box item changes, pull from form1 arrays to populate text boxes
            int sel=ItemsCB.SelectedIndex;  //selected item
            InventoryTB.Text = Form1.CountValues[sel].ToString();
            CostPerCaseTB.Text = Form1.CaseCost[sel].ToString("C");
            QTYPerCaseTB.Text= Form1.CaseQTY[sel].ToString();
            CostPerItemTB.Text = Form1.CostperItem[sel].ToString("C");
            ProfitPerItemTB.Text = Form1.ProfitperItem[sel].ToString("C");
            ProfitPerCaseTB.Text = Form1.ProfitperCase[sel].ToString("C");
            SellingPriceTB.Text = Form1.SellingPrice[sel].ToString("C");
        }
    }
}