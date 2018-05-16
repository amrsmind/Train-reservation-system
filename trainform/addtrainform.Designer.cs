namespace trainform
{
    partial class addtrainform
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
            this.label2 = new System.Windows.Forms.Label();
            this.trainnumtext = new System.Windows.Forms.TextBox();
            this.availseattext = new System.Windows.Forms.TextBox();
            this.backbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Train you wanna add:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Availabe seat at this train:";
            // 
            // trainnumtext
            // 
            this.trainnumtext.Location = new System.Drawing.Point(124, 92);
            this.trainnumtext.Name = "trainnumtext";
            this.trainnumtext.Size = new System.Drawing.Size(224, 22);
            this.trainnumtext.TabIndex = 2;
            this.trainnumtext.TextChanged += new System.EventHandler(this.trainnumtext_TextChanged);
            // 
            // availseattext
            // 
            this.availseattext.Location = new System.Drawing.Point(124, 254);
            this.availseattext.Name = "availseattext";
            this.availseattext.Size = new System.Drawing.Size(224, 22);
            this.availseattext.TabIndex = 3;
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(571, 382);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 4;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(652, 382);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 5;
            this.addbutton.Text = "add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // addtrainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.availseattext);
            this.Controls.Add(this.trainnumtext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addtrainform";
            this.Text = "addtrainform";
            this.Load += new System.EventHandler(this.addtrainform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox trainnumtext;
        private System.Windows.Forms.TextBox availseattext;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button addbutton;
    }
}