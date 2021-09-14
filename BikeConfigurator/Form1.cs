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
            
           

        }

        private void lstBoxProduse_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void grpBoxViteze_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            lstBoxProduse.DataSource = null;
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
                List<Bike> bikes = new List<Bike>();
                bikes.Add(bike);
                lstBoxProduse.DataSource = bikes;
                lstBoxProduse.DisplayMember = "Display";
                lstBoxProduse.ValueMember = "Display";
            }
            ResetButtons(rdoBtnShimano, rdobtnPegas);
            ResetButtons(rdoBtn2Viteze, rdoBtn18Viteze);
            ResetButtons(rdoBtnRosie, rdoBtnVerde);
            ResetTextBox(txtBoxCustomer);
        }

        private void rdoBtn2Viteze_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            lstBoxProduse.Visible = true;
            bindingSource.DataSource = bikeController.getBikeList();
            lstBoxProduse.DataSource = bindingSource;
            lstBoxProduse.DisplayMember = "Display";
            lstBoxProduse.ValueMember = "Display";

            ResetButtons(rdoBtnShimano, rdobtnPegas);
            ResetButtons(rdoBtn2Viteze, rdoBtn18Viteze);
            ResetButtons(rdoBtnRosie, rdoBtnVerde);
            ResetTextBox(txtBoxCustomer);

        }

        private void txtBoxCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //toate selectate
            //sa fie cel putin una in lista
            //update
            if (AtLeastOneElemInTheList(bikeController.getBikeList())
            && ElemFromListSelected(lstBoxProduse)
            && isSelected(grpBoxModel, rdoBtnShimano, rdobtnPegas)
            && isSelected(grpBoxViteze, rdoBtn2Viteze, rdoBtn18Viteze)
            && isSelected(grpBoxCuloare, rdoBtnRosie, rdoBtnVerde)
            && isFilled(txtBoxCustomer))
            {
                int index = lstBoxProduse.SelectedIndex;
                Bike bike = new Bike();
                if (rdoBtnShimano.Checked == true)
                {
                    bike.setModel(rdoBtnShimano.Text);
                }
                else
                {
                    bike.setModel(rdobtnPegas.Text);
                }
                if (rdoBtn2Viteze.Checked == true)
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
                bikeController.getBikeList()[index] = bike;
                bikeController.WriteToFile();
                bindingSource.ResetBindings(false);
                List<Bike> bikes = new List<Bike>();
                bikes.Add(bike);
                lstBoxProduse.DataSource = bikes;
                lstBoxProduse.DisplayMember = "Display";
                lstBoxProduse.ValueMember = "Display";

                ResetButtons(rdoBtnShimano, rdobtnPegas);
                ResetButtons(rdoBtn2Viteze, rdoBtn18Viteze);
                ResetButtons(rdoBtnRosie, rdoBtnVerde);
                ResetTextBox(txtBoxCustomer);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (AtLeastOneElemInTheList(bikeController.getBikeList())
            && ElemFromListSelected(lstBoxProduse))
            {
                int index = lstBoxProduse.SelectedIndex;
                bikeController.getBikeList().RemoveAt(index);
                bindingSource.DataSource = bikeController.getBikeList();
                lstBoxProduse.DataSource = bindingSource;
                lstBoxProduse.DisplayMember = "Display";
                lstBoxProduse.ValueMember = "Display";
                bindingSource.ResetBindings(false);

                ResetButtons(rdoBtnShimano, rdobtnPegas);
                ResetButtons(rdoBtn2Viteze, rdoBtn18Viteze);
                ResetButtons(rdoBtnRosie, rdoBtnVerde);
                ResetTextBox(txtBoxCustomer);
                bikeController.WriteToFile();
            }
        }
    }
}

