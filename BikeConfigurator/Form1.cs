using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BikeConfigurator.Functii;

namespace BikeConfigurator
{
    public partial class Form1 : Form
    {
        BikeController bikeController;
        BindingSource bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bikeController = new BikeController();
            
            bindingSource.DataSource = bikeController.getBikeList();
            lstBoxProduse.DataSource = bindingSource;
            lstBoxProduse.DisplayMember = "Display";
            lstBoxProduse.ValueMember = "Display";

        }

        private void lstBoxProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void grpBoxViteze_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(isSelected(grpBoxModel,rdoBtnShimano, rdobtnPegas) 
            && isSelected(grpBoxViteze, rdoBtn2Viteze, rdoBtn18Viteze)
            && isSelected(grpBoxCuloare, rdoBtnRosie, rdoBtnVerde)
            && isFilled(txtBoxCustomer))
            {
                Bike bike = new Bike();
                 if(rdoBtnShimano.Checked == true)
                {
                    bike.setModel(rdoBtnShimano.Text);
                }
                 else
                {
                    bike.setModel(rdobtnPegas.Text);
                }
                 if(rdoBtn2Viteze.Checked==true)
                {
                    bike.setViteze(int.Parse(rdoBtn2Viteze.Text));
                }
                 else
                {
                    bike.setViteze(int.Parse(rdoBtn18Viteze.Text));
                }
                 if (rdoBtnRosie.Checked == true)
                {
                    bike.setCuloare(rdoBtnRosie.Text);
                }
                 else
                {
                    bike.setCuloare(rdoBtnVerde.Text);
                }
                bike.setCustomer(txtBoxCustomer.Text);
                bikeController.Add(bike);
                bikeController.WriteToFile();
                bindingSource.ResetBindings(false);
            }
                
        }

        private void rdoBtn2Viteze_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

