
namespace Fall
{
    partial class Form_Main
    {
        private System.ComponentModel.IContainer components = null;
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
        private void InitializeComponent()
        {
            this.btn_Viga = new System.Windows.Forms.Button();
            this.btn_Pilares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Viga
            // 
            this.btn_Viga.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Viga.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Viga.Location = new System.Drawing.Point(15, 15);
            this.btn_Viga.Name = "btn_Viga";
            this.btn_Viga.Size = new System.Drawing.Size(100, 50);
            this.btn_Viga.TabIndex = 0;
            this.btn_Viga.Text = "Vigas";
            this.btn_Viga.UseVisualStyleBackColor = false;
            this.btn_Viga.Click += new System.EventHandler(this.btn_Vigas_Click);
            // 
            // btn_Pilares
            // 
            this.btn_Pilares.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Pilares.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Pilares.Location = new System.Drawing.Point(121, 15);
            this.btn_Pilares.Name = "btn_Pilares";
            this.btn_Pilares.Size = new System.Drawing.Size(100, 50);
            this.btn_Pilares.TabIndex = 1;
            this.btn_Pilares.Text = "Pilares";
            this.btn_Pilares.UseVisualStyleBackColor = false;
            this.btn_Pilares.Click += new System.EventHandler(this.btn_Pilares_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.btn_Pilares);
            this.Controls.Add(this.btn_Viga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fall";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btn_Viga;
        private System.Windows.Forms.Button btn_Pilares;
    }
}

