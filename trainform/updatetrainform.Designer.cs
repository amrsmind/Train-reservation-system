namespace trainform
{
    partial class updatetrainform
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
            this.trainnumtext = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.applybutton = new System.Windows.Forms.Button();
            this.trainnumbercheck = new System.Windows.Forms.CheckBox();
            this.availseatscheck = new System.Windows.Forms.CheckBox();
            this.newtrainnumbertext = new System.Windows.Forms.TextBox();
            this.newavailseats = new System.Windows.Forms.TextBox();
            this.donebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the train num you wanna edit:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trainnumtext
            // 
            this.trainnumtext.Location = new System.Drawing.Point(57, 66);
            this.trainnumtext.Name = "trainnumtext";
            this.trainnumtext.Size = new System.Drawing.Size(195, 22);
            this.trainnumtext.TabIndex = 1;
            this.trainnumtext.TextChanged += new System.EventHandler(this.trainnumtext_TextChanged);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(573, 313);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 2;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // applybutton
            // 
            this.applybutton.Location = new System.Drawing.Point(654, 313);
            this.applybutton.Name = "applybutton";
            this.applybutton.Size = new System.Drawing.Size(75, 23);
            this.applybutton.TabIndex = 3;
            this.applybutton.Text = "Apply";
            this.applybutton.UseVisualStyleBackColor = true;
            this.applybutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // trainnumbercheck
            // 
            this.trainnumbercheck.AutoSize = true;
            this.trainnumbercheck.Location = new System.Drawing.Point(57, 160);
            this.trainnumbercheck.Name = "trainnumbercheck";
            this.trainnumbercheck.Size = new System.Drawing.Size(110, 21);
            this.trainnumbercheck.TabIndex = 4;
            this.trainnumbercheck.Text = "train number";
            this.trainnumbercheck.UseVisualStyleBackColor = true;
            this.trainnumbercheck.CheckedChanged += new System.EventHandler(this.trainnumbercheeck_CheckedChanged);
            // 
            // availseatscheck
            // 
            this.availseatscheck.AutoSize = true;
            this.availseatscheck.Location = new System.Drawing.Point(57, 232);
            this.availseatscheck.Name = "availseatscheck";
            this.availseatscheck.Size = new System.Drawing.Size(124, 21);
            this.availseatscheck.TabIndex = 5;
            this.availseatscheck.Text = "available seats";
            this.availseatscheck.UseVisualStyleBackColor = true;
            this.availseatscheck.CheckedChanged += new System.EventHandler(this.availseatscheck_CheckedChanged);
            // 
            // newtrainnumbertext
            // 
            this.newtrainnumbertext.Enabled = false;
            this.newtrainnumbertext.Location = new System.Drawing.Point(57, 188);
            this.newtrainnumbertext.Name = "newtrainnumbertext";
            this.newtrainnumbertext.Size = new System.Drawing.Size(124, 22);
            this.newtrainnumbertext.TabIndex = 6;
            this.newtrainnumbertext.TextChanged += new System.EventHandler(this.newtrainnumbertext_TextChanged);
            // 
            // newavailseats
            // 
            this.newavailseats.Enabled = false;
            this.newavailseats.Location = new System.Drawing.Point(57, 259);
            this.newavailseats.Name = "newavailseats";
            this.newavailseats.Size = new System.Drawing.Size(124, 22);
            this.newavailseats.TabIndex = 7;
            // 
            // donebutton
            // 
            this.donebutton.Location = new System.Drawing.Point(267, 66);
            this.donebutton.Name = "donebutton";
            this.donebutton.Size = new System.Drawing.Size(75, 23);
            this.donebutton.TabIndex = 8;
            this.donebutton.Text = "Done";
            this.donebutton.UseVisualStyleBackColor = true;
            this.donebutton.Click += new System.EventHandler(this.donebutton_Click);
            // 
            // updatetrainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.donebutton);
            this.Controls.Add(this.newavailseats);
            this.Controls.Add(this.newtrainnumbertext);
            this.Controls.Add(this.availseatscheck);
            this.Controls.Add(this.trainnumbercheck);
            this.Controls.Add(this.applybutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.trainnumtext);
            this.Controls.Add(this.label1);
            this.Name = "updatetrainform";
            this.Text = "updatetrainform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trainnumtext;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button applybutton;
        private System.Windows.Forms.CheckBox trainnumbercheck;
        private System.Windows.Forms.CheckBox availseatscheck;
        private System.Windows.Forms.TextBox newtrainnumbertext;
        private System.Windows.Forms.TextBox newavailseats;
        private System.Windows.Forms.Button donebutton;
    }
}