namespace trainform
{
    partial class adminaccess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addtrain = new System.Windows.Forms.Button();
            this.addtrip = new System.Windows.Forms.Button();
            this.updatetrain = new System.Windows.Forms.Button();
            this.updatetrip = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.tripstrainsdata = new System.Windows.Forms.DataGridView();
            this.trainDataSet1 = new trainform.trainDataSet1();
            this.tripsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripsTableAdapter = new trainform.trainDataSet1TableAdapters.tripsTableAdapter();
            this.trainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainsTableAdapter = new trainform.trainDataSet1TableAdapters.trainsTableAdapter();
            this.showtablebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tripstrainsdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addtrain
            // 
            this.addtrain.Location = new System.Drawing.Point(87, 49);
            this.addtrain.Name = "addtrain";
            this.addtrain.Size = new System.Drawing.Size(86, 23);
            this.addtrain.TabIndex = 0;
            this.addtrain.Text = "Add Train";
            this.addtrain.UseVisualStyleBackColor = true;
            this.addtrain.Click += new System.EventHandler(this.button1_Click);
            // 
            // addtrip
            // 
            this.addtrip.Location = new System.Drawing.Point(437, 49);
            this.addtrip.Name = "addtrip";
            this.addtrip.Size = new System.Drawing.Size(75, 23);
            this.addtrip.TabIndex = 1;
            this.addtrip.Text = "Add Trip";
            this.addtrip.UseVisualStyleBackColor = true;
            this.addtrip.Click += new System.EventHandler(this.addtrip_Click);
            // 
            // updatetrain
            // 
            this.updatetrain.Location = new System.Drawing.Point(250, 49);
            this.updatetrain.Name = "updatetrain";
            this.updatetrain.Size = new System.Drawing.Size(110, 23);
            this.updatetrain.TabIndex = 2;
            this.updatetrain.Text = "Update train";
            this.updatetrain.UseVisualStyleBackColor = true;
            this.updatetrain.Click += new System.EventHandler(this.updatetrain_Click);
            // 
            // updatetrip
            // 
            this.updatetrip.Location = new System.Drawing.Point(585, 49);
            this.updatetrip.Name = "updatetrip";
            this.updatetrip.Size = new System.Drawing.Size(93, 23);
            this.updatetrip.TabIndex = 3;
            this.updatetrip.Text = "Update Trip";
            this.updatetrip.UseVisualStyleBackColor = true;
            this.updatetrip.Click += new System.EventHandler(this.updatetrip_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(27, 395);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // tripstrainsdata
            // 
            this.tripstrainsdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripstrainsdata.Location = new System.Drawing.Point(12, 96);
            this.tripstrainsdata.Name = "tripstrainsdata";
            this.tripstrainsdata.RowTemplate.Height = 24;
            this.tripstrainsdata.Size = new System.Drawing.Size(776, 273);
            this.tripstrainsdata.TabIndex = 5;
            // 
            // trainDataSet1
            // 
            this.trainDataSet1.DataSetName = "trainDataSet1";
            this.trainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tripsBindingSource
            // 
            this.tripsBindingSource.DataMember = "trips";
            this.tripsBindingSource.DataSource = this.trainDataSet1;
            // 
            // tripsTableAdapter
            // 
            this.tripsTableAdapter.ClearBeforeFill = true;
            // 
            // trainsBindingSource
            // 
            this.trainsBindingSource.DataMember = "trains";
            this.trainsBindingSource.DataSource = this.trainDataSet1;
            // 
            // trainsTableAdapter
            // 
            this.trainsTableAdapter.ClearBeforeFill = true;
            // 
            // showtablebutton
            // 
            this.showtablebutton.Location = new System.Drawing.Point(316, 388);
            this.showtablebutton.Name = "showtablebutton";
            this.showtablebutton.Size = new System.Drawing.Size(196, 50);
            this.showtablebutton.TabIndex = 6;
            this.showtablebutton.Text = "Show trips and trains";
            this.showtablebutton.UseVisualStyleBackColor = true;
            this.showtablebutton.Click += new System.EventHandler(this.showtablebutton_Click);
            // 
            // adminaccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showtablebutton);
            this.Controls.Add(this.tripstrainsdata);
            this.Controls.Add(this.back);
            this.Controls.Add(this.updatetrip);
            this.Controls.Add(this.updatetrain);
            this.Controls.Add(this.addtrip);
            this.Controls.Add(this.addtrain);
            this.Name = "adminaccess";
            this.Text = "adminaccess";
            this.Load += new System.EventHandler(this.adminaccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tripstrainsdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addtrain;
        private System.Windows.Forms.Button addtrip;
        private System.Windows.Forms.Button updatetrain;
        private System.Windows.Forms.Button updatetrip;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView tripstrainsdata;
        private trainDataSet1 trainDataSet1;
        private System.Windows.Forms.BindingSource tripsBindingSource;
        private trainDataSet1TableAdapters.tripsTableAdapter tripsTableAdapter;
        private System.Windows.Forms.BindingSource trainsBindingSource;
        private trainDataSet1TableAdapters.trainsTableAdapter trainsTableAdapter;
        private System.Windows.Forms.Button showtablebutton;
    }
}