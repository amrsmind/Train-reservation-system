namespace trainform
{
    partial class updatetripform
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
            this.label1 = new System.Windows.Forms.Label();
            this.departuretime = new System.Windows.Forms.DateTimePicker();
            this.arrivaltime = new System.Windows.Forms.DateTimePicker();
            this.arrivaldate = new System.Windows.Forms.DateTimePicker();
            this.departuredate = new System.Windows.Forms.DateTimePicker();
            this.departuredatecheck = new System.Windows.Forms.CheckBox();
            this.arrivaldatecheck = new System.Windows.Forms.CheckBox();
            this.departuretimecheck = new System.Windows.Forms.CheckBox();
            this.arrivaltimecheck = new System.Windows.Forms.CheckBox();
            this.trainnumcheck = new System.Windows.Forms.CheckBox();
            this.trainnumtext = new System.Windows.Forms.TextBox();
            this.routenumtext = new System.Windows.Forms.TextBox();
            this.routenumcheck = new System.Windows.Forms.CheckBox();
            this.tripnumtext = new System.Windows.Forms.TextBox();
            this.checkbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of trip you wanna edit:";
            // 
            // departuretime
            // 
            this.departuretime.Enabled = false;
            this.departuretime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departuretime.Location = new System.Drawing.Point(495, 142);
            this.departuretime.MinDate = new System.DateTime(2018, 4, 29, 0, 0, 0, 0);
            this.departuretime.Name = "departuretime";
            this.departuretime.ShowUpDown = true;
            this.departuretime.Size = new System.Drawing.Size(97, 22);
            this.departuretime.TabIndex = 27;
            // 
            // arrivaltime
            // 
            this.arrivaltime.Enabled = false;
            this.arrivaltime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrivaltime.Location = new System.Drawing.Point(495, 187);
            this.arrivaltime.Name = "arrivaltime";
            this.arrivaltime.ShowUpDown = true;
            this.arrivaltime.Size = new System.Drawing.Size(99, 22);
            this.arrivaltime.TabIndex = 26;
            // 
            // arrivaldate
            // 
            this.arrivaldate.Enabled = false;
            this.arrivaldate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.arrivaldate.Location = new System.Drawing.Point(497, 99);
            this.arrivaldate.Name = "arrivaldate";
            this.arrivaldate.Size = new System.Drawing.Size(95, 22);
            this.arrivaldate.TabIndex = 25;
            // 
            // departuredate
            // 
            this.departuredate.Enabled = false;
            this.departuredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.departuredate.Location = new System.Drawing.Point(497, 60);
            this.departuredate.MinDate = new System.DateTime(2018, 4, 29, 1, 45, 25, 0);
            this.departuredate.Name = "departuredate";
            this.departuredate.Size = new System.Drawing.Size(95, 22);
            this.departuredate.TabIndex = 24;
            this.departuredate.Value = new System.DateTime(2018, 4, 29, 1, 45, 25, 0);
            this.departuredate.ValueChanged += new System.EventHandler(this.departuredate_ValueChanged);
            // 
            // departuredatecheck
            // 
            this.departuredatecheck.AutoSize = true;
            this.departuredatecheck.Location = new System.Drawing.Point(316, 60);
            this.departuredatecheck.Name = "departuredatecheck";
            this.departuredatecheck.Size = new System.Drawing.Size(175, 21);
            this.departuredatecheck.TabIndex = 28;
            this.departuredatecheck.Text = "change departure date";
            this.departuredatecheck.UseVisualStyleBackColor = true;
            this.departuredatecheck.CheckedChanged += new System.EventHandler(this.departurecheck_CheckedChanged);
            // 
            // arrivaldatecheck
            // 
            this.arrivaldatecheck.AutoSize = true;
            this.arrivaldatecheck.Location = new System.Drawing.Point(316, 100);
            this.arrivaldatecheck.Name = "arrivaldatecheck";
            this.arrivaldatecheck.Size = new System.Drawing.Size(152, 21);
            this.arrivaldatecheck.TabIndex = 29;
            this.arrivaldatecheck.Text = "change arrival date";
            this.arrivaldatecheck.UseVisualStyleBackColor = true;
            this.arrivaldatecheck.CheckedChanged += new System.EventHandler(this.arrivaldatecheck_CheckedChanged);
            // 
            // departuretimecheck
            // 
            this.departuretimecheck.AutoSize = true;
            this.departuretimecheck.Location = new System.Drawing.Point(316, 146);
            this.departuretimecheck.Name = "departuretimecheck";
            this.departuretimecheck.Size = new System.Drawing.Size(173, 21);
            this.departuretimecheck.TabIndex = 30;
            this.departuretimecheck.Text = "change departure time";
            this.departuretimecheck.UseVisualStyleBackColor = true;
            this.departuretimecheck.CheckedChanged += new System.EventHandler(this.departuretimecheck_CheckedChanged);
            // 
            // arrivaltimecheck
            // 
            this.arrivaltimecheck.AutoSize = true;
            this.arrivaltimecheck.Location = new System.Drawing.Point(316, 187);
            this.arrivaltimecheck.Name = "arrivaltimecheck";
            this.arrivaltimecheck.Size = new System.Drawing.Size(150, 21);
            this.arrivaltimecheck.TabIndex = 31;
            this.arrivaltimecheck.Text = "change arrival time";
            this.arrivaltimecheck.UseVisualStyleBackColor = true;
            this.arrivaltimecheck.CheckedChanged += new System.EventHandler(this.arrivaltimecheck_CheckedChanged);
            // 
            // trainnumcheck
            // 
            this.trainnumcheck.AutoSize = true;
            this.trainnumcheck.Location = new System.Drawing.Point(316, 227);
            this.trainnumcheck.Name = "trainnumcheck";
            this.trainnumcheck.Size = new System.Drawing.Size(161, 21);
            this.trainnumcheck.TabIndex = 32;
            this.trainnumcheck.Text = "change train number";
            this.trainnumcheck.UseVisualStyleBackColor = true;
            this.trainnumcheck.CheckedChanged += new System.EventHandler(this.trainnumcheck_CheckedChanged);
            // 
            // trainnumtext
            // 
            this.trainnumtext.Enabled = false;
            this.trainnumtext.Location = new System.Drawing.Point(494, 227);
            this.trainnumtext.Name = "trainnumtext";
            this.trainnumtext.Size = new System.Drawing.Size(100, 22);
            this.trainnumtext.TabIndex = 33;
            // 
            // routenumtext
            // 
            this.routenumtext.Enabled = false;
            this.routenumtext.Location = new System.Drawing.Point(494, 267);
            this.routenumtext.Name = "routenumtext";
            this.routenumtext.Size = new System.Drawing.Size(100, 22);
            this.routenumtext.TabIndex = 34;
            // 
            // routenumcheck
            // 
            this.routenumcheck.AutoSize = true;
            this.routenumcheck.Location = new System.Drawing.Point(316, 267);
            this.routenumcheck.Name = "routenumcheck";
            this.routenumcheck.Size = new System.Drawing.Size(166, 21);
            this.routenumcheck.TabIndex = 35;
            this.routenumcheck.Text = "change route number";
            this.routenumcheck.UseVisualStyleBackColor = true;
            this.routenumcheck.CheckedChanged += new System.EventHandler(this.routenumcheck_CheckedChanged);
            // 
            // tripnumtext
            // 
            this.tripnumtext.Location = new System.Drawing.Point(48, 62);
            this.tripnumtext.Name = "tripnumtext";
            this.tripnumtext.Size = new System.Drawing.Size(107, 22);
            this.tripnumtext.TabIndex = 36;
            // 
            // checkbutton
            // 
            this.checkbutton.Location = new System.Drawing.Point(171, 62);
            this.checkbutton.Name = "checkbutton";
            this.checkbutton.Size = new System.Drawing.Size(75, 23);
            this.checkbutton.TabIndex = 37;
            this.checkbutton.Text = "check";
            this.checkbutton.UseVisualStyleBackColor = true;
            this.checkbutton.Click += new System.EventHandler(this.checkbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(576, 376);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 38;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(657, 376);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 39;
            this.updatebutton.Text = "update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // updatetripform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.checkbutton);
            this.Controls.Add(this.tripnumtext);
            this.Controls.Add(this.routenumcheck);
            this.Controls.Add(this.routenumtext);
            this.Controls.Add(this.trainnumtext);
            this.Controls.Add(this.trainnumcheck);
            this.Controls.Add(this.arrivaltimecheck);
            this.Controls.Add(this.departuretimecheck);
            this.Controls.Add(this.arrivaldatecheck);
            this.Controls.Add(this.departuredatecheck);
            this.Controls.Add(this.departuretime);
            this.Controls.Add(this.arrivaltime);
            this.Controls.Add(this.arrivaldate);
            this.Controls.Add(this.departuredate);
            this.Controls.Add(this.label1);
            this.Name = "updatetripform";
            this.Text = "updatetripform";
            this.Load += new System.EventHandler(this.updatetripform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker departuretime;
        private System.Windows.Forms.DateTimePicker arrivaltime;
        private System.Windows.Forms.DateTimePicker arrivaldate;
        private System.Windows.Forms.DateTimePicker departuredate;
        private System.Windows.Forms.CheckBox departuredatecheck;
        private System.Windows.Forms.CheckBox arrivaldatecheck;
        private System.Windows.Forms.CheckBox departuretimecheck;
        private System.Windows.Forms.CheckBox arrivaltimecheck;
        private System.Windows.Forms.CheckBox trainnumcheck;
        private System.Windows.Forms.TextBox trainnumtext;
        private System.Windows.Forms.TextBox routenumtext;
        private System.Windows.Forms.CheckBox routenumcheck;
        private System.Windows.Forms.TextBox tripnumtext;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button updatebutton;
    }
}