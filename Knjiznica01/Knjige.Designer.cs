
namespace Knjiznica01
{
    partial class Knjige
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
            this.Knjigelabel = new System.Windows.Forms.Label();
            this.BrisiButton2 = new System.Windows.Forms.Button();
            this.UrediButton2 = new System.Windows.Forms.Button();
            this.DodajButton2 = new System.Windows.Forms.Button();
            this.textBoxUcenici2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Knjigelabel
            // 
            this.Knjigelabel.AutoSize = true;
            this.Knjigelabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Knjigelabel.Location = new System.Drawing.Point(35, 51);
            this.Knjigelabel.Name = "Knjigelabel";
            this.Knjigelabel.Size = new System.Drawing.Size(71, 28);
            this.Knjigelabel.TabIndex = 2;
            this.Knjigelabel.Text = "Knjige:";
            // 
            // BrisiButton2
            // 
            this.BrisiButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrisiButton2.Location = new System.Drawing.Point(376, 288);
            this.BrisiButton2.Name = "BrisiButton2";
            this.BrisiButton2.Size = new System.Drawing.Size(114, 55);
            this.BrisiButton2.TabIndex = 12;
            this.BrisiButton2.Text = "Briši";
            this.BrisiButton2.UseVisualStyleBackColor = true;
            // 
            // UrediButton2
            // 
            this.UrediButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UrediButton2.Location = new System.Drawing.Point(376, 192);
            this.UrediButton2.Name = "UrediButton2";
            this.UrediButton2.Size = new System.Drawing.Size(114, 55);
            this.UrediButton2.TabIndex = 11;
            this.UrediButton2.Text = "Uredi";
            this.UrediButton2.UseVisualStyleBackColor = true;
            // 
            // DodajButton2
            // 
            this.DodajButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DodajButton2.Location = new System.Drawing.Point(376, 109);
            this.DodajButton2.Name = "DodajButton2";
            this.DodajButton2.Size = new System.Drawing.Size(114, 55);
            this.DodajButton2.TabIndex = 10;
            this.DodajButton2.Text = "Dodaj";
            this.DodajButton2.UseVisualStyleBackColor = true;
            // 
            // textBoxUcenici2
            // 
            this.textBoxUcenici2.Location = new System.Drawing.Point(35, 109);
            this.textBoxUcenici2.Multiline = true;
            this.textBoxUcenici2.Name = "textBoxUcenici2";
            this.textBoxUcenici2.Size = new System.Drawing.Size(268, 234);
            this.textBoxUcenici2.TabIndex = 13;
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 416);
            this.Controls.Add(this.textBoxUcenici2);
            this.Controls.Add(this.BrisiButton2);
            this.Controls.Add(this.UrediButton2);
            this.Controls.Add(this.DodajButton2);
            this.Controls.Add(this.Knjigelabel);
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Knjigelabel;
        private System.Windows.Forms.Button BrisiButton2;
        private System.Windows.Forms.Button UrediButton2;
        private System.Windows.Forms.Button DodajButton2;
        private System.Windows.Forms.TextBox textBoxUcenici2;
    }
}