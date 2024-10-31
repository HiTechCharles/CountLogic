using System;
using System.IO;  //file access
using System.Windows.Forms;

namespace CountLogic
{
    public partial class Form1 : Form
    {
        #region VARIABLES
        //file path for items and prices
        public static string CatalogPath = Environment.GetEnvironmentVariable("onedriveconsumer") + "\\documents\\brew for you\\CountLogic\\catalog.txt";
        public static string ReportPath = Environment.GetEnvironmentVariable("onedriveconsumer") + "\\documents\\brew for you\\CountLogic\\";

        public static string[] ItemName = new string[16];  //product names
        public static decimal[] CaseCost = new decimal[16]; //cost per case
        public static decimal[] CaseQTY = new decimal[16]; //# items per case
        public static decimal[] SellingPrice= new decimal[16];   //selling price
        public static decimal[] CostperItem = new decimal[16]; //cost per item
        public static decimal[] ProfitperItem = new decimal[16]; //cost per item
        public static decimal[] ProfitperCase = new decimal[16]; //cost per item
        public static decimal[] CountValues = new decimal[16]; //values of numeric updown controls
        public static decimal TotalItems, TotalCost, TotalValue;  //total items in inventory, and number of items in file
        public static string line;  //file is read line by line
        public static int NumItems;  //Number of items in file
        DateTime ReportDate;  //report date
        #endregion

        public Form1()
        {
            InitializeComponent();

            StreamReader CsvRip = new StreamReader  //open catalog file
            (CatalogPath);  

            while (!CsvRip.EndOfStream)  //loop until EOF
            {
                line = CsvRip.ReadLine();  //read a line from file

                string[] subs = line.Split(',');  //split string by ,  
                //(I don't want no subs, a sub is a girl that can't get no love from me )
                ItemName[NumItems] = subs[0];  //store product name
                CaseQTY[NumItems] = Convert.ToDecimal(subs[1]);  //qty per case
                CaseCost[NumItems] = Convert.ToDecimal(subs[2]);  //cost per case
                SellingPrice[NumItems] = Convert.ToDecimal(subs[3]);

                NumItems++;  //count number of lines
            }
            #region Array values to label names
            Name1.Text = ItemName[0];  //put array items as label names on form1
            Name2.Text = ItemName[1];
            Name3.Text = ItemName[2];
            Name4.Text = ItemName[3];  
            Name5.Text = ItemName[4];
            Name6.Text = ItemName[5];
            Name7.Text = ItemName[6];
            Name8.Text = ItemName[7];
            Name9.Text = ItemName[8];
            Name10.Text = ItemName[9];
            Name11.Text = ItemName[10];
            Name12.Text = ItemName[11];
            Name13.Text = ItemName[12];
            Name14.Text = ItemName[13];
            #endregion

            for (int i = 0; i < NumItems; i++)  //for each item, do some math
            {
                CostperItem[i] = CaseCost[i] / CaseQTY[i];  //cost per item
                ProfitperItem[i] = SellingPrice[i] - CostperItem[i];  //profit per item
                ProfitperCase[i] = SellingPrice[i] * CaseQTY[i] - CaseCost[i];  //profit per case
            }
        }

        #region Numeric UpDown ValueChanged
        private void Count1_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count2_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count3_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count4_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count5_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count6_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count7_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count8_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count9_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count10_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count11_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count12_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count13_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }

        private void Count14_ValueChanged(object sender, EventArgs e)
        {
            GetTotals();
        }
        #endregion

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Clear numeric up down controls
            Count1.Value = 0;
            Count2.Value = 0;
            Count3.Value = 0;
            Count4.Value = 0;
            Count5.Value = 0;
            Count6.Value = 0;
            Count7.Value = 0;
            Count8.Value = 0;
            Count9.Value = 0;
            Count10.Value = 0;
            Count11.Value = 0;
            Count12.Value = 0;
            Count13.Value = 0;
            Count14.Value = 0;
            #endregion
        }

        private void itemDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new DetailsFRM();  //show form2
            form2.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TotalItems == 0)
            {
                System.Media.SystemSounds.Exclamation.Play();
                return;
            }
            SaveReport();  //save report to file
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void GetTotals ()  //get totals and other stats
        {
            #region CountX.values to array
            //put numeric controls in array for faster processing
            CountValues[0] = Count1.Value;
            CountValues[1] = Count2.Value;
            CountValues[2] = Count3.Value;
            CountValues[3] = Count4.Value;
            CountValues[4] = Count5.Value;
            CountValues[5] = Count6.Value;
            CountValues[6] = Count7.Value;
            CountValues[7] = Count8.Value;
            CountValues[8] = Count9.Value;
            CountValues[9] = Count10.Value;
            CountValues[10] = Count11.Value;
            CountValues[11] = Count12.Value;
            CountValues[12] = Count13.Value;
            CountValues[13] = Count14.Value;
            #endregion

            TotalItems = 0;  //clear values
            TotalCost = 0;
            TotalValue= 0;
            for (int i = 0; i < NumItems; i++)  //for each item, do some math
            {
                TotalItems += CountValues[i];  //total items in inventory
                TotalCost += CountValues[i] * CostperItem[i];  //total cost
                TotalValue += CountValues[i] * SellingPrice[i];  //sale value
            }
                TotalItemsTB.Text = TotalItems.ToString("n0");  //write values to controls
                CostTB.Text = TotalCost.ToString("C");
                ValueTB.Text= TotalValue.ToString("C");
        }
        
        private void SaveReport()  //save report to file
        {
            GetTotals();  //update totals before saving
            ReportDate = DateTime.Now;  //report time and date
            string FileDate = "Report " +  ReportDate.ToString("MM-d-yyyy");   //month day year for file names
            StreamWriter InvReport = new StreamWriter(ReportPath + FileDate + ".txt"); //open report file for writing

            InvReport.WriteLine("Brew for You Inventory Report");
            InvReport.WriteLine(ReportDate.ToString("D") );
            InvReport.WriteLine();

            for (int i = 0; i < NumItems; i++)  //for each item, do some math
            {
                //add lines to file where inventory value > 0
                if (CountValues[i] > 0)
                {
                    InvReport.WriteLine(ItemName[i] + ":  " + CountValues[i]);
                }
                
            }

            InvReport.WriteLine();
            InvReport.WriteLine("Total Cost:  " + TotalCost.ToString("C"));
            InvReport.WriteLine("Total Items:  " + TotalItems);
            InvReport.WriteLine("Total Sale Value:  $" + TotalValue);
            InvReport.Close();
        }
    }  //end class
}  //end namespace