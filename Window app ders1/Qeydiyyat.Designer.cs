namespace Window_app_ders1
{
    partial class Qeydiyyat
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
            this.Adbox = new System.Windows.Forms.TextBox();
            this.Soyadbox = new System.Windows.Forms.TextBox();
            this.AdLabel = new System.Windows.Forms.Label();
            this.SoyadLabel = new System.Windows.Forms.Label();
            this.SeansLabel = new System.Windows.Forms.Label();
            this.Selectedlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Adbox
            // 
            this.Adbox.Location = new System.Drawing.Point(70, 8);
            this.Adbox.Name = "Adbox";
            this.Adbox.Size = new System.Drawing.Size(132, 20);
            this.Adbox.TabIndex = 0;
            // 
            // Soyadbox
            // 
            this.Soyadbox.Location = new System.Drawing.Point(70, 43);
            this.Soyadbox.Name = "Soyadbox";
            this.Soyadbox.Size = new System.Drawing.Size(132, 20);
            this.Soyadbox.TabIndex = 2;
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Location = new System.Drawing.Point(12, 15);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(20, 13);
            this.AdLabel.TabIndex = 3;
            this.AdLabel.Text = "Ad";
            // 
            // SoyadLabel
            // 
            this.SoyadLabel.AutoSize = true;
            this.SoyadLabel.Location = new System.Drawing.Point(12, 50);
            this.SoyadLabel.Name = "SoyadLabel";
            this.SoyadLabel.Size = new System.Drawing.Size(37, 13);
            this.SoyadLabel.TabIndex = 4;
            this.SoyadLabel.Text = "Soyad";
            // 
            // SeansLabel
            // 
            this.SeansLabel.AutoSize = true;
            this.SeansLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SeansLabel.Location = new System.Drawing.Point(32, 102);
            this.SeansLabel.Name = "SeansLabel";
            this.SeansLabel.Size = new System.Drawing.Size(0, 13);
            this.SeansLabel.TabIndex = 8;
            // 
            // Selectedlabel
            // 
            this.Selectedlabel.AutoSize = true;
            this.Selectedlabel.Location = new System.Drawing.Point(12, 80);
            this.Selectedlabel.Name = "Selectedlabel";
            this.Selectedlabel.Size = new System.Drawing.Size(43, 13);
            this.Selectedlabel.TabIndex = 9;
            this.Selectedlabel.Text = "Yerler : ";
            // 
            // Qeydiyyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 234);
            this.Controls.Add(this.Selectedlabel);
            this.Controls.Add(this.SeansLabel);
            this.Controls.Add(this.SoyadLabel);
            this.Controls.Add(this.AdLabel);
            this.Controls.Add(this.Soyadbox);
            this.Controls.Add(this.Adbox);
            this.Name = "Qeydiyyat";
            this.Text = "Qeydiyyat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adbox;
        private System.Windows.Forms.TextBox Soyadbox;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label SoyadLabel;
        private System.Windows.Forms.Label SeansLabel;
        private System.Windows.Forms.Label Selectedlabel;
    }
}