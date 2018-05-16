namespace trainform
{
    partial class addtripform
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
            this.Backbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tripnumtext = new System.Windows.Forms.TextBox();
            this.trainnumtext = new System.Windows.Forms.TextBox();
            this.routenumtext = new System.Windows.Forms.TextBox();
            this.departuredate = new System.Windows.Forms.DateTimePicker();
            this.arrivaldate = new System.Windows.Forms.DateTimePicker();
            this.arrivaltime = new System.Windows.Forms.DateTimePicker();
            this.departuretime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totext = new System.Windows.Forms.TextBox();
            this.Fromtext = new System.Windows.Forms.TextBox();
            this.newroutecheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(580, 375);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 23);
            this.Backbutton.TabIndex = 0;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(661, 375);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 1;
            this.Addbutton.Text = "Add Trip";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trip Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Departure date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "arrival date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "departure time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "arrival time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "train number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "route number";
            // 
            // tripnumtext
            // 
            this.tripnumtext.Location = new System.Drawing.Point(51, 45);
            this.tripnumtext.Name = "tripnumtext";
            this.tripnumtext.Size = new System.Drawing.Size(100, 22);
            this.tripnumtext.TabIndex = 9;
            // 
            // trainnumtext
            // 
            this.trainnumtext.Location = new System.Drawing.Point(46, 391);
            this.trainnumtext.Name = "trainnumtext";
            this.trainnumtext.Size = new System.Drawing.Size(100, 22);
            this.trainnumtext.TabIndex = 12;
            this.trainnumtext.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // routenumtext
            // 
            this.routenumtext.Enabled = false;
            this.routenumtext.Location = new System.Drawing.Point(253, 132);
            this.routenumtext.Name = "routenumtext";
            this.routenumtext.Size = new System.Drawing.Size(100, 22);
            this.routenumtext.TabIndex = 13;
            this.routenumtext.TextChanged += new System.EventHandler(this.routenumtext_TextChanged);
            // 
            // departuredate
            // 
            this.departuredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.departuredate.Location = new System.Drawing.Point(51, 107);
            this.departuredate.MinDate = new System.DateTime(2018, 4, 29, 1, 45, 25, 0);
            this.departuredate.Name = "departuredate";
            this.departuredate.Size = new System.Drawing.Size(95, 22);
            this.departuredate.TabIndex = 16;
            this.departuredate.Value = new System.DateTime(2018, 4, 29, 1, 45, 25, 0);
            // 
            // arrivaldate
            // 
            this.arrivaldate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.arrivaldate.Location = new System.Drawing.Point(51, 174);
            this.arrivaldate.Name = "arrivaldate";
            this.arrivaldate.Size = new System.Drawing.Size(95, 22);
            this.arrivaldate.TabIndex = 17;
            // 
            // arrivaltime
            // 
            this.arrivaltime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrivaltime.Location = new System.Drawing.Point(49, 317);
            this.arrivaltime.Name = "arrivaltime";
            this.arrivaltime.ShowUpDown = true;
            this.arrivaltime.Size = new System.Drawing.Size(99, 22);
            this.arrivaltime.TabIndex = 18;
            // 
            // departuretime
            // 
            this.departuretime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departuretime.Location = new System.Drawing.Point(49, 246);
            this.departuretime.MinDate = new System.DateTime(2018, 4, 29, 0, 0, 0, 0);
            this.departuretime.Name = "departuretime";
            this.departuretime.ShowUpDown = true;
            this.departuretime.Size = new System.Drawing.Size(97, 22);
            this.departuretime.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "To";
            // 
            // totext
            // 
            this.totext.Location = new System.Drawing.Point(360, 276);
            this.totext.Name = "totext";
            this.totext.Size = new System.Drawing.Size(100, 22);
            this.totext.TabIndex = 22;
            // 
            // Fromtext
            // 
            this.Fromtext.Location = new System.Drawing.Point(253, 276);
            this.Fromtext.Name = "Fromtext";
            this.Fromtext.Size = new System.Drawing.Size(100, 22);
            this.Fromtext.TabIndex = 23;
            // 
            // newroutecheck
            // 
            this.newroutecheck.AutoSize = true;
            this.newroutecheck.Location = new System.Drawing.Point(251, 47);
            this.newroutecheck.Name = "newroutecheck";
            this.newroutecheck.Size = new System.Drawing.Size(92, 21);
            this.newroutecheck.TabIndex = 24;
            this.newroutecheck.Text = "new route";
            this.newroutecheck.UseVisualStyleBackColor = true;
            this.newroutecheck.CheckedChanged += new System.EventHandler(this.newroutecheck_CheckedChanged);
            // 
            // addtripform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newroutecheck);
            this.Controls.Add(this.Fromtext);
            this.Controls.Add(this.totext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.departuretime);
            this.Controls.Add(this.arrivaltime);
            this.Controls.Add(this.arrivaldate);
            this.Controls.Add(this.departuredate);
            this.Controls.Add(this.routenumtext);
            this.Controls.Add(this.trainnumtext);
            this.Controls.Add(this.tripnumtext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Backbutton);
            this.Name = "addtripform";
            this.Text = "addtripform";
            this.Load += new System.EventHandler(this.addtripform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tripnumtext;
        private System.Windows.Forms.TextBox trainnumtext;
        private System.Windows.Forms.TextBox routenumtext;
        private System.Windows.Forms.DateTimePicker departuredate;
        private System.Windows.Forms.DateTimePicker arrivaldate;
        private System.Windows.Forms.DateTimePicker arrivaltime;
        private System.Windows.Forms.DateTimePicker departuretime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totext;
        private System.Windows.Forms.TextBox Fromtext;
        private System.Windows.Forms.CheckBox newroutecheck;
    }
}