using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BikeConfigurator
{
    class Functii
    {
        public static void resetResultsLabel(Label labelResults)
        {
            labelResults.Visible = false;
        }
      
        public static bool isSelected(GroupBox grpBox1,RadioButton rdo1, RadioButton rdo2)
        {
            if (rdo1.Checked == false && rdo2.Checked == false)
            {
                MessageBox.Show("Mandatory field: " + grpBox1.Text);
                return false;
            }
            return true;
        }
        public static bool isFilled(TextBox text)
        {
            if (text.Text == "Customer"
               || text.Text == "")
            {
                MessageBox.Show("Mandatory field Customer");
                return false;
            }
            return true;
        }
    }
}
