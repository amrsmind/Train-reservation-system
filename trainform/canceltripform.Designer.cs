namespace trainform
{
    partial class canceltripform
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
            this.canceltripbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.tripnumtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the trip number";
            // 
            // canceltripbutton
            // 
            this.canceltripbutton.Location = new System.Drawing.Point(641, 354);
            this.canceltripbutton.Name = "canceltripbutton";
            this.canceltripbutton.Size = new System.Drawing.Size(97, 32);
            this.canceltripbutton.TabIndex = 1;
            this.canceltripbutton.Text = "Cancel trip";
            this.canceltripbutton.UseVisualStyleBackColor = true;
            this.canceltripbutton.Click += new System.EventHandler(this.canceltripbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(538, 354);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(97, 32);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // tripnumtext
            // 
            this.tripnumtext.Location = new System.Drawing.Point(247, 118);
            this.tripnumtext.Name = "tripnumtext";
            this.tripnumtext.Size = new System.Drawing.Size(45, 22);
            this.tripnumtext.TabIndex = 4;
            this.tripnumtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // canceltripform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tripnumtext);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.canceltripbutton);
            this.Controls.Add(this.label1);
            this.Name = "canceltripform";
            this.Text = "canceltripform";
            this.Load += new System.EventHandler(this.canceltripform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button canceltripbutton;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.TextBox tripnumtext;
    }
}