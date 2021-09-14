
namespace BikeConfigurator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRezultate = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lstBoxProduse = new System.Windows.Forms.ListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpBoxCRUD = new System.Windows.Forms.GroupBox();
            this.grpBoxActions = new System.Windows.Forms.GroupBox();
            this.grpBoxModel = new System.Windows.Forms.GroupBox();
            this.rdobtnPegas = new System.Windows.Forms.RadioButton();
            this.rdoBtnShimano = new System.Windows.Forms.RadioButton();
            this.grpBoxViteze = new System.Windows.Forms.GroupBox();
            this.rdoBtn18Viteze = new System.Windows.Forms.RadioButton();
            this.rdoBtn2Viteze = new System.Windows.Forms.RadioButton();
            this.grpBoxCuloare = new System.Windows.Forms.GroupBox();
            this.rdoBtnVerde = new System.Windows.Forms.RadioButton();
            this.rdoBtnRosie = new System.Windows.Forms.RadioButton();
            this.txtBoxCustomer = new System.Windows.Forms.TextBox();
            this.grpBoxCRUD.SuspendLayout();
            this.grpBoxActions.SuspendLayout();
            this.grpBoxModel.SuspendLayout();
            this.grpBoxViteze.SuspendLayout();
            this.grpBoxCuloare.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRezultate
            // 
            this.lblRezultate.AutoSize = true;
            this.lblRezultate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRezultate.Location = new System.Drawing.Point(6, 65);
            this.lblRezultate.Name = "lblRezultate";
            this.lblRezultate.Size = new System.Drawing.Size(231, 24);
            this.lblRezultate.TabIndex = 3;
            this.lblRezultate.Text = "Rezultatelele configurarii";
            this.lblRezultate.Visible = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnOrder.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.Location = new System.Drawing.Point(6, 31);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(127, 37);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(6, 145);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 36);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // lstBoxProduse
            // 
            this.lstBoxProduse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstBoxProduse.FormattingEnabled = true;
            this.lstBoxProduse.ItemHeight = 24;
            this.lstBoxProduse.Items.AddRange(new object[] {
            "ProduseTest.."});
            this.lstBoxProduse.Location = new System.Drawing.Point(46, 356);
            this.lstBoxProduse.Name = "lstBoxProduse";
            this.lstBoxProduse.Size = new System.Drawing.Size(544, 220);
            this.lstBoxProduse.TabIndex = 6;
            this.lstBoxProduse.SelectedIndexChanged += new System.EventHandler(this.lstBoxProduse_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(20, 26);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Padding = new System.Windows.Forms.Padding(1);
            this.btnCreate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreate.Size = new System.Drawing.Size(102, 39);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRead.Location = new System.Drawing.Point(20, 71);
            this.btnRead.Name = "btnRead";
            this.btnRead.Padding = new System.Windows.Forms.Padding(1);
            this.btnRead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRead.Size = new System.Drawing.Size(102, 35);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(20, 117);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(1);
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(102, 31);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(20, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(1);
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(102, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpBoxCRUD
            // 
            this.grpBoxCRUD.Controls.Add(this.btnCreate);
            this.grpBoxCRUD.Controls.Add(this.btnDelete);
            this.grpBoxCRUD.Controls.Add(this.btnRead);
            this.grpBoxCRUD.Controls.Add(this.btnUpdate);
            this.grpBoxCRUD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBoxCRUD.Location = new System.Drawing.Point(596, 342);
            this.grpBoxCRUD.Name = "grpBoxCRUD";
            this.grpBoxCRUD.Size = new System.Drawing.Size(141, 234);
            this.grpBoxCRUD.TabIndex = 11;
            this.grpBoxCRUD.TabStop = false;
            this.grpBoxCRUD.Text = "CRUD";
            // 
            // grpBoxActions
            // 
            this.grpBoxActions.Controls.Add(this.btnOrder);
            this.grpBoxActions.Controls.Add(this.btnReset);
            this.grpBoxActions.Controls.Add(this.lblRezultate);
            this.grpBoxActions.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBoxActions.Location = new System.Drawing.Point(743, 356);
            this.grpBoxActions.Name = "grpBoxActions";
            this.grpBoxActions.Size = new System.Drawing.Size(230, 220);
            this.grpBoxActions.TabIndex = 12;
            this.grpBoxActions.TabStop = false;
            this.grpBoxActions.Text = "Actions";
            // 
            // grpBoxModel
            // 
            this.grpBoxModel.Controls.Add(this.rdobtnPegas);
            this.grpBoxModel.Controls.Add(this.rdoBtnShimano);
            this.grpBoxModel.Location = new System.Drawing.Point(46, 143);
            this.grpBoxModel.Name = "grpBoxModel";
            this.grpBoxModel.Size = new System.Drawing.Size(250, 125);
            this.grpBoxModel.TabIndex = 14;
            this.grpBoxModel.TabStop = false;
            this.grpBoxModel.Text = "Model";
            // 
            // rdobtnPegas
            // 
            this.rdobtnPegas.AutoSize = true;
            this.rdobtnPegas.Location = new System.Drawing.Point(6, 78);
            this.rdobtnPegas.Name = "rdobtnPegas";
            this.rdobtnPegas.Size = new System.Drawing.Size(68, 24);
            this.rdobtnPegas.TabIndex = 1;
            this.rdobtnPegas.TabStop = true;
            this.rdobtnPegas.Text = "Pegas";
            this.rdobtnPegas.UseVisualStyleBackColor = true;
            // 
            // rdoBtnShimano
            // 
            this.rdoBtnShimano.AutoSize = true;
            this.rdoBtnShimano.Location = new System.Drawing.Point(6, 36);
            this.rdoBtnShimano.Name = "rdoBtnShimano";
            this.rdoBtnShimano.Size = new System.Drawing.Size(80, 24);
            this.rdoBtnShimano.TabIndex = 0;
            this.rdoBtnShimano.TabStop = true;
            this.rdoBtnShimano.Text = "Shimao";
            this.rdoBtnShimano.UseVisualStyleBackColor = true;
            // 
            // grpBoxViteze
            // 
            this.grpBoxViteze.Controls.Add(this.rdoBtn18Viteze);
            this.grpBoxViteze.Controls.Add(this.rdoBtn2Viteze);
            this.grpBoxViteze.Location = new System.Drawing.Point(302, 143);
            this.grpBoxViteze.Name = "grpBoxViteze";
            this.grpBoxViteze.Size = new System.Drawing.Size(250, 125);
            this.grpBoxViteze.TabIndex = 15;
            this.grpBoxViteze.TabStop = false;
            this.grpBoxViteze.Text = "Viteze";
            this.grpBoxViteze.Enter += new System.EventHandler(this.grpBoxViteze_Enter);
            // 
            // rdoBtn18Viteze
            // 
            this.rdoBtn18Viteze.AutoSize = true;
            this.rdoBtn18Viteze.Location = new System.Drawing.Point(47, 78);
            this.rdoBtn18Viteze.Name = "rdoBtn18Viteze";
            this.rdoBtn18Viteze.Size = new System.Drawing.Size(46, 24);
            this.rdoBtn18Viteze.TabIndex = 3;
            this.rdoBtn18Viteze.Text = "18";
            this.rdoBtn18Viteze.UseVisualStyleBackColor = true;
            // 
            // rdoBtn2Viteze
            // 
            this.rdoBtn2Viteze.AutoSize = true;
            this.rdoBtn2Viteze.Location = new System.Drawing.Point(47, 27);
            this.rdoBtn2Viteze.Name = "rdoBtn2Viteze";
            this.rdoBtn2Viteze.Size = new System.Drawing.Size(38, 24);
            this.rdoBtn2Viteze.TabIndex = 2;
            this.rdoBtn2Viteze.Text = "2";
            this.rdoBtn2Viteze.UseVisualStyleBackColor = true;
            this.rdoBtn2Viteze.CheckedChanged += new System.EventHandler(this.rdoBtn2Viteze_CheckedChanged);
            // 
            // grpBoxCuloare
            // 
            this.grpBoxCuloare.Controls.Add(this.rdoBtnVerde);
            this.grpBoxCuloare.Controls.Add(this.rdoBtnRosie);
            this.grpBoxCuloare.Location = new System.Drawing.Point(574, 143);
            this.grpBoxCuloare.Name = "grpBoxCuloare";
            this.grpBoxCuloare.Size = new System.Drawing.Size(250, 125);
            this.grpBoxCuloare.TabIndex = 16;
            this.grpBoxCuloare.TabStop = false;
            this.grpBoxCuloare.Text = "Culoare";
            // 
            // rdoBtnVerde
            // 
            this.rdoBtnVerde.AutoSize = true;
            this.rdoBtnVerde.Location = new System.Drawing.Point(0, 78);
            this.rdoBtnVerde.Name = "rdoBtnVerde";
            this.rdoBtnVerde.Size = new System.Drawing.Size(68, 24);
            this.rdoBtnVerde.TabIndex = 5;
            this.rdoBtnVerde.TabStop = true;
            this.rdoBtnVerde.Text = "Verde";
            this.rdoBtnVerde.UseVisualStyleBackColor = true;
            // 
            // rdoBtnRosie
            // 
            this.rdoBtnRosie.AutoSize = true;
            this.rdoBtnRosie.Location = new System.Drawing.Point(0, 36);
            this.rdoBtnRosie.Name = "rdoBtnRosie";
            this.rdoBtnRosie.Size = new System.Drawing.Size(66, 24);
            this.rdoBtnRosie.TabIndex = 4;
            this.rdoBtnRosie.TabStop = true;
            this.rdoBtnRosie.Text = "Rosie";
            this.rdoBtnRosie.UseVisualStyleBackColor = true;
            // 
            // txtBoxCustomer
            // 
            this.txtBoxCustomer.Location = new System.Drawing.Point(52, 81);
            this.txtBoxCustomer.Name = "txtBoxCustomer";
            this.txtBoxCustomer.Size = new System.Drawing.Size(777, 27);
            this.txtBoxCustomer.TabIndex = 17;
            this.txtBoxCustomer.Text = "Customer";
            this.txtBoxCustomer.TextChanged += new System.EventHandler(this.txtBoxCustomer_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 660);
            this.Controls.Add(this.txtBoxCustomer);
            this.Controls.Add(this.grpBoxCuloare);
            this.Controls.Add(this.grpBoxViteze);
            this.Controls.Add(this.grpBoxModel);
            this.Controls.Add(this.grpBoxActions);
            this.Controls.Add(this.grpBoxCRUD);
            this.Controls.Add(this.lstBoxProduse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxCRUD.ResumeLayout(false);
            this.grpBoxActions.ResumeLayout(false);
            this.grpBoxActions.PerformLayout();
            this.grpBoxModel.ResumeLayout(false);
            this.grpBoxModel.PerformLayout();
            this.grpBoxViteze.ResumeLayout(false);
            this.grpBoxViteze.PerformLayout();
            this.grpBoxCuloare.ResumeLayout(false);
            this.grpBoxCuloare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRezultate;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lstBoxProduse;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpBoxCRUD;
        private System.Windows.Forms.GroupBox grpBoxActions;
        private System.Windows.Forms.GroupBox grpBoxModel;
        private System.Windows.Forms.RadioButton rdobtnPegas;
        private System.Windows.Forms.RadioButton rdoBtnShimano;
        private System.Windows.Forms.GroupBox grpBoxViteze;
        private System.Windows.Forms.RadioButton rdoBtn18Viteze;
        private System.Windows.Forms.RadioButton rdoBtn2Viteze;
        private System.Windows.Forms.GroupBox grpBoxCuloare;
        private System.Windows.Forms.RadioButton rdoBtnVerde;
        private System.Windows.Forms.RadioButton rdoBtnRosie;
        private System.Windows.Forms.TextBox txtBoxCustomer;
    }
}

