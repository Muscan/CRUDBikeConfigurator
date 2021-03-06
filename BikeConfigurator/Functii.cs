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

        public static void ResetButtons(RadioButton rdo1, RadioButton rdo2)
        {
            rdo1.Checked = false;
            rdo2.Checked = false;
        }

        public static void ResetTextBox(TextBox text)
        {
            text.Text = "";
        }

        public static bool ElemFromListSelected(ListBox lstBox)
        {
            if (lstBox.SelectedIndex == -1)
            {
                MessageBox.Show("First READ then select.");
                return false;
            }
            return true;
        }

        public static bool AtLeastOneElemInTheList(List<Bike> bikes)
        {
            if (bikes.Count == 0)
            {
                MessageBox.Show("No elem. in the list. Add one before going further.");
                return false;
            }
            return true;
        }
    }
}
