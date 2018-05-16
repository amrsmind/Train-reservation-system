namespace trainform
{
    partial class customeraccess
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
            this.Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainDataSet1 = new trainform.trainDataSet1();
            this.trainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainsTableAdapter = new trainform.trainDataSet1TableAdapters.trainsTableAdapter();
            this.tripsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tripsTableAdapter = new trainform.trainDataSet1TableAdapters.tripsTableAdapter();
            this.sourcecheck = new System.Windows.Forms.CheckBox();
            this.trainDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seatsTableAdapter = new trainform.trainDataSet1TableAdapters.seatsTableAdapter();
            this.arrivaltimecheck = new System.Windows.Forms.CheckBox();
            this.departuretimecheck = new System.Windows.Forms.CheckBox();
            this.arrivaldatecheck = new System.Windows.Forms.CheckBox();
            this.departuredatecheck = new System.Windows.Forms.CheckBox();
            this.departuretime = new System.Windows.Forms.DateTimePicker();
            this.arrivaltime = new System.Windows.Forms.DateTimePicker();
            this.arrivaldate = new System.Windows.Forms.DateTimePicker();
            this.departuredate = new System.Windows.Forms.DateTimePicker();
            this.destinationcheck = new System.Windows.Forms.CheckBox();
            this.sourcetext = new System.Windows.Forms.TextBox();
            this.destinationtext = new System.Windows.Forms.TextBox();
            this.showtrips = new System.Windows.Forms.Button();
            this.checktrips = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bookbutton = new System.Windows.Forms.Button();
            this.seatsnumbertext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(29, 367);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checktrips});
            this.dataGridView1.Location = new System.Drawing.Point(332, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(460, 268);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // trainDataSet1
            // 
            this.trainDataSet1.DataSetName = "trainDataSet1";
            this.trainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tripsBindingSource
            // 
            this.tripsBindingSource.DataMember = "trips";
            this.tripsBindingSource.DataSource = this.trainDataSet1;
            // 
            // tripsTableAdapter
            // 
            this.tripsTableAdapter.ClearBeforeFill = true;
            // 
            // sourcecheck
            // 
            this.sourcecheck.AutoSize = true;
            this.sourcecheck.Location = new System.Drawing.Point(29, 189);
            this.sourcecheck.Name = "sourcecheck";
            this.sourcecheck.Size = new System.Drawing.Size(123, 21);
            this.sourcecheck.TabIndex = 2;
            this.sourcecheck.Text = "choose source";
            this.sourcecheck.UseVisualStyleBackColor = true;
            this.sourcecheck.CheckedChanged += new System.EventHandler(this.sourcecheck_CheckedChanged);
            // 
            // trainDataSet1BindingSource
            // 
            this.trainDataSet1BindingSource.DataSource = this.trainDataSet1;
            this.trainDataSet1BindingSource.Position = 0;
            // 
            // seatsBindingSource
            // 
            this.seatsBindingSource.DataMember = "seats";
            this.seatsBindingSource.DataSource = this.trainDataSet1BindingSource;
            // 
            // seatsTableAdapter
            // 
            this.seatsTableAdapter.ClearBeforeFill = true;
            // 
            // arrivaltimecheck
            // 
            this.arrivaltimecheck.AutoSize = true;
            this.arrivaltimecheck.Location = new System.Drawing.Point(29, 145);
            this.arrivaltimecheck.Name = "arrivaltimecheck";
            this.arrivaltimecheck.Size = new System.Drawing.Size(149, 21);
            this.arrivaltimecheck.TabIndex = 39;
            this.arrivaltimecheck.Text = "choose arrival time";
            this.arrivaltimecheck.UseVisualStyleBackColor = true;
            this.arrivaltimecheck.CheckedChanged += new System.EventHandler(this.arrivaltimecheck_CheckedChanged);
            // 
            // departuretimecheck
            // 
            this.departuretimecheck.AutoSize = true;
            this.departuretimecheck.Location = new System.Drawing.Point(29, 104);
            this.departuretimecheck.Name = "departuretimecheck";
            this.departuretimecheck.Size = new System.Drawing.Size(172, 21);
            this.departuretimecheck.TabIndex = 38;
            this.departuretimecheck.Text = "choose departure time";
            this.departuretimecheck.UseVisualStyleBackColor = true;
            this.departuretimecheck.CheckedChanged += new System.EventHandler(this.departuretimecheck_CheckedChanged);
            // 
            // arrivaldatecheck
            // 
            this.arrivaldatecheck.AutoSize = true;
            this.arrivaldatecheck.Location = new System.Drawing.Point(29, 58);
            this.arrivaldatecheck.Name = "arrivaldatecheck";
            this.arrivaldatecheck.Size = new System.Drawing.Size(151, 21);
            this.arrivaldatecheck.TabIndex = 37;
            this.arrivaldatecheck.Text = "choose arrival date";
            this.arrivaldatecheck.UseVisualStyleBackColor = true;
            this.arrivaldatecheck.CheckedChanged += new System.EventHandler(this.arrivaldatecheck_CheckedChanged);
            // 
            // departuredatecheck
            // 
            this.departuredatecheck.AutoSize = true;
            this.departuredatecheck.Location = new System.Drawing.Point(29, 18);
            this.departuredatecheck.Name = "departuredatecheck";
            this.departuredatecheck.Size = new System.Drawing.Size(174, 21);
            this.departuredatecheck.TabIndex = 36;
            this.departuredatecheck.Text = "choose departure date";
            this.departuredatecheck.UseVisualStyleBackColor = true;
            this.departuredatecheck.CheckedChanged += new System.EventHandler(this.departuredatecheck_CheckedChanged);
            // 
            // departuretime
            // 
            this.departuretime.Enabled = false;
            this.departuretime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departuretime.Location = new System.Drawing.Point(208, 100);
            this.departuretime.MinDate = new System.DateTime(2018, 4, 29, 0, 0, 0, 0);
            this.departuretime.Name = "departuretime";
            this.departuretime.ShowUpDown = true;
            this.departuretime.Size = new System.Drawing.Size(97, 22);
            this.departuretime.TabIndex = 35;
            // 
            // arrivaltime
            // 
            this.arrivaltime.Enabled = false;
            this.arrivaltime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrivaltime.Location = new System.Drawing.Point(208, 145);
            this.arrivaltime.Name = "arrivaltime";
            this.arrivaltime.ShowUpDown = true;
            this.arrivaltime.Size = new System.Drawing.Size(99, 22);
            this.arrivaltime.TabIndex = 34;
            // 
            // arrivaldate
            // 
            this.arrivaldate.Enabled = false;
            this.arrivaldate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.arrivaldate.Location = new System.Drawing.Point(210, 57);
            this.arrivaldate.Name = "arrivaldate";
            this.arrivaldate.Size = new System.Drawing.Size(95, 22);
            this.arrivaldate.TabIndex = 33;
            // 
            // departuredate
            // 
            this.departuredate.Enabled = false;
            this.departuredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.departuredate.Location = new System.Drawing.Point(210, 18);
            this.departuredate.MinDate = new System.DateTime(2018, 4, 29, 1, 45, 25, 0);
            this.departuredate.Name = "departuredate";
            this.departuredate.Size = new System.Drawing.Size(95, 22);
            this.departuredate.TabIndex = 32;
            this.departuredate.Value = new System.DateTime(2018, 4, 29, 1, 45, 25, 0);
            // 
            // destinationcheck
            // 
            this.destinationcheck.AutoSize = true;
            this.destinationcheck.Location = new System.Drawing.Point(29, 230);
            this.destinationcheck.Name = "destinationcheck";
            this.destinationcheck.Size = new System.Drawing.Size(149, 21);
            this.destinationcheck.TabIndex = 40;
            this.destinationcheck.Text = "choose destination";
            this.destinationcheck.UseVisualStyleBackColor = true;
            this.destinationcheck.CheckedChanged += new System.EventHandler(this.destinationcheck_CheckedChanged);
            // 
            // sourcetext
            // 
            this.sourcetext.Enabled = false;
            this.sourcetext.Location = new System.Drawing.Point(205, 189);
            this.sourcetext.Name = "sourcetext";
            this.sourcetext.Size = new System.Drawing.Size(100, 22);
            this.sourcetext.TabIndex = 41;
            // 
            // destinationtext
            // 
            this.destinationtext.Enabled = false;
            this.destinationtext.Location = new System.Drawing.Point(205, 230);
            this.destinationtext.Name = "destinationtext";
            this.destinationtext.Size = new System.Drawing.Size(100, 22);
            this.destinationtext.TabIndex = 42;
            // 
            // showtrips
            // 
            this.showtrips.Location = new System.Drawing.Point(205, 291);
            this.showtrips.Name = "showtrips";
            this.showtrips.Size = new System.Drawing.Size(100, 23);
            this.showtrips.TabIndex = 43;
            this.showtrips.Text = "Show Trips";
            this.showtrips.UseVisualStyleBackColor = true;
            this.showtrips.Click += new System.EventHandler(this.showtrips_Click);
            // 
            // checktrips
            // 
            this.checktrips.HeaderText = "Booked trips";
            this.checktrips.IndeterminateValue = "True";
            this.checktrips.Name = "checktrips";
            // 
            // bookbutton
            // 
            this.bookbutton.Enabled = false;
            this.bookbutton.Location = new System.Drawing.Point(677, 348);
            this.bookbutton.Name = "bookbutton";
            this.bookbutton.Size = new System.Drawing.Size(115, 23);
            this.bookbutton.TabIndex = 44;
            this.bookbutton.Text = "Book trips";
            this.bookbutton.UseVisualStyleBackColor = true;
            this.bookbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // seatsnumbertext
            // 
            this.seatsnumbertext.Location = new System.Drawing.Point(566, 349);
            this.seatsnumbertext.Name = "seatsnumbertext";
            this.seatsnumbertext.Size = new System.Drawing.Size(100, 22);
            this.seatsnumbertext.TabIndex = 45;
            this.seatsnumbertext.TextChanged += new System.EventHandler(this.seatsnumbertext_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "number of seats";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customeraccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seatsnumbertext);
            this.Controls.Add(this.bookbutton);
            this.Controls.Add(this.showtrips);
            this.Controls.Add(this.destinationtext);
            this.Controls.Add(this.sourcetext);
            this.Controls.Add(this.destinationcheck);
            this.Controls.Add(this.arrivaltimecheck);
            this.Controls.Add(this.departuretimecheck);
            this.Controls.Add(this.arrivaldatecheck);
            this.Controls.Add(this.departuredatecheck);
            this.Controls.Add(this.departuretime);
            this.Controls.Add(this.arrivaltime);
            this.Controls.Add(this.arrivaldate);
            this.Controls.Add(this.departuredate);
            this.Controls.Add(this.sourcecheck);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Name = "customeraccess";
            this.Text = "customeraccess";
            this.Load += new System.EventHandler(this.customeraccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tripsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private trainDataSet1 trainDataSet1;
        private System.Windows.Forms.BindingSource trainsBindingSource;
        private trainDataSet1TableAdapters.trainsTableAdapter trainsTableAdapter;
        private System.Windows.Forms.BindingSource tripsBindingSource;
        private trainDataSet1TableAdapters.tripsTableAdapter tripsTableAdapter;
        private System.Windows.Forms.CheckBox sourcecheck;
        private System.Windows.Forms.BindingSource trainDataSet1BindingSource;
        private System.Windows.Forms.BindingSource seatsBindingSource;
        private trainDataSet1TableAdapters.seatsTableAdapter seatsTableAdapter;
        private System.Windows.Forms.CheckBox arrivaltimecheck;
        private System.Windows.Forms.CheckBox departuretimecheck;
        private System.Windows.Forms.CheckBox arrivaldatecheck;
        private System.Windows.Forms.CheckBox departuredatecheck;
        private System.Windows.Forms.DateTimePicker departuretime;
        private System.Windows.Forms.DateTimePicker arrivaltime;
        private System.Windows.Forms.DateTimePicker arrivaldate;
        private System.Windows.Forms.DateTimePicker departuredate;
        private System.Windows.Forms.CheckBox destinationcheck;
        private System.Windows.Forms.TextBox sourcetext;
        private System.Windows.Forms.TextBox destinationtext;
        private System.Windows.Forms.Button showtrips;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checktrips;
        private System.Windows.Forms.Button bookbutton;
        private System.Windows.Forms.TextBox seatsnumbertext;
        private System.Windows.Forms.Label label1;
    }
}