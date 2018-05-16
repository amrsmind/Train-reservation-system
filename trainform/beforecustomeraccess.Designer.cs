namespace trainform
{
    partial class beforecustomeraccess
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
            this.booktripbutton = new System.Windows.Forms.Button();
            this.canceltripbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booktripbutton
            // 
            this.booktripbutton.Location = new System.Drawing.Point(232, 131);
            this.booktripbutton.Name = "booktripbutton";
            this.booktripbutton.Size = new System.Drawing.Size(127, 46);
            this.booktripbutton.TabIndex = 0;
            this.booktripbutton.Text = "Book trip";
            this.booktripbutton.UseVisualStyleBackColor = true;
            this.booktripbutton.Click += new System.EventHandler(this.booktripbutton_Click);
            // 
            // canceltripbutton
            // 
            this.canceltripbutton.Location = new System.Drawing.Point(460, 131);
            this.canceltripbutton.Name = "canceltripbutton";
            this.canceltripbutton.Size = new System.Drawing.Size(127, 46);
            this.canceltripbutton.TabIndex = 2;
            this.canceltripbutton.Text = "Cancel trip";
            this.canceltripbutton.UseVisualStyleBackColor = true;
            this.canceltripbutton.Click += new System.EventHandler(this.canceltripbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(58, 379);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 3;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // beforecustomeraccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 430);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.canceltripbutton);
            this.Controls.Add(this.booktripbutton);
            this.Name = "beforecustomeraccess";
            this.Text = "beforecustomeraccess";
            this.Load += new System.EventHandler(this.beforecustomeraccess_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button booktripbutton;
        private System.Windows.Forms.Button canceltripbutton;
        private System.Windows.Forms.Button backbutton;
    }
}