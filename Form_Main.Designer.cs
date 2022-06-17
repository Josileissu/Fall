
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
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Analise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Viga
            // 
            this.btn_Viga.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Viga.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Viga.Location = new System.Drawing.Point(17, 20);
            this.btn_Viga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Viga.Name = "btn_Viga";
            this.btn_Viga.Size = new System.Drawing.Size(114, 67);
            this.btn_Viga.TabIndex = 0;
            this.btn_Viga.Text = "Vigas";
            this.btn_Viga.UseVisualStyleBackColor = false;
            this.btn_Viga.Click += new System.EventHandler(this.btn_Vigas_Click);
            // 
            // btn_Pilares
            // 
            this.btn_Pilares.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Pilares.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Pilares.Location = new System.Drawing.Point(138, 20);
            this.btn_Pilares.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Pilares.Name = "btn_Pilares";
            this.btn_Pilares.Size = new System.Drawing.Size(114, 67);
            this.btn_Pilares.TabIndex = 1;
            this.btn_Pilares.Text = "Pilares";
            this.btn_Pilares.UseVisualStyleBackColor = false;
            this.btn_Pilares.Click += new System.EventHandler(this.btn_Pilares_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.DimGray;
            this.btn_Fechar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Fechar.Location = new System.Drawing.Point(1015, 584);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(114, 67);
            this.btn_Fechar.TabIndex = 0;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Analise
            // 
            this.btn_Analise.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Analise.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Analise.Location = new System.Drawing.Point(258, 20);
            this.btn_Analise.Name = "btn_Analise";
            this.btn_Analise.Size = new System.Drawing.Size(114, 67);
            this.btn_Analise.TabIndex = 2;
            this.btn_Analise.Text = "Análise";
            this.btn_Analise.UseVisualStyleBackColor = false;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(1143, 667);
            this.Controls.Add(this.btn_Analise);
            this.Controls.Add(this.btn_Pilares);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.btn_Viga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Analise;
    }
}

