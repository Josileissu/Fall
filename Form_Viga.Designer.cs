
namespace Fall
{
    partial class Form_Viga
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
            this.btn_Geometria = new System.Windows.Forms.Button();
            this.gB_geometria = new System.Windows.Forms.GroupBox();
            this.lb_Volume = new System.Windows.Forms.Label();
            this.lb_Peso = new System.Windows.Forms.Label();
            this.lb_QuantidadePino = new System.Windows.Forms.Label();
            this.lb_DiametroPino = new System.Windows.Forms.Label();
            this.lb_AreaLateral = new System.Windows.Forms.Label();
            this.lb_AlturaRecorteConsolo = new System.Windows.Forms.Label();
            this.lb_CConsolo = new System.Windows.Forms.Label();
            this.lb_d = new System.Windows.Forms.Label();
            this.lb_dLinha = new System.Windows.Forms.Label();
            this.lb_Comprimento = new System.Windows.Forms.Label();
            this.lb_Altura = new System.Windows.Forms.Label();
            this.lb_Base = new System.Windows.Forms.Label();
            this.tb_Peso = new System.Windows.Forms.TextBox();
            this.tb_Volume = new System.Windows.Forms.TextBox();
            this.tb_QtdPinos = new System.Windows.Forms.TextBox();
            this.tb_DiamPino = new System.Windows.Forms.TextBox();
            this.tb_AreaLateral = new System.Windows.Forms.TextBox();
            this.tb_AlturaRecorteConsolo = new System.Windows.Forms.TextBox();
            this.tb_CConsolo = new System.Windows.Forms.TextBox();
            this.tb_d = new System.Windows.Forms.TextBox();
            this.tb_dLinha = new System.Windows.Forms.TextBox();
            this.tb_Comprimento = new System.Windows.Forms.TextBox();
            this.tb_Altura = new System.Windows.Forms.TextBox();
            this.tb_Base = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.gB_geometria.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Geometria
            // 
            this.btn_Geometria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Geometria.Location = new System.Drawing.Point(12, 343);
            this.btn_Geometria.Name = "btn_Geometria";
            this.btn_Geometria.Size = new System.Drawing.Size(100, 50);
            this.btn_Geometria.TabIndex = 0;
            this.btn_Geometria.Text = "Geometria";
            this.btn_Geometria.UseVisualStyleBackColor = true;
            this.btn_Geometria.Click += new System.EventHandler(this.btn_Geometria_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(191, 372);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // gB_geometria
            // 
            this.gB_geometria.Controls.Add(this.lb_Volume);
            this.gB_geometria.Controls.Add(this.lb_Peso);
            this.gB_geometria.Controls.Add(this.lb_QuantidadePino);
            this.gB_geometria.Controls.Add(this.lb_DiametroPino);
            this.gB_geometria.Controls.Add(this.lb_AreaLateral);
            this.gB_geometria.Controls.Add(this.lb_AlturaRecorteConsolo);
            this.gB_geometria.Controls.Add(this.lb_CConsolo);
            this.gB_geometria.Controls.Add(this.lb_d);
            this.gB_geometria.Controls.Add(this.lb_dLinha);
            this.gB_geometria.Controls.Add(this.lb_Comprimento);
            this.gB_geometria.Controls.Add(this.lb_Altura);
            this.gB_geometria.Controls.Add(this.lb_Base);
            this.gB_geometria.Controls.Add(this.tb_Peso);
            this.gB_geometria.Controls.Add(this.tb_Volume);
            this.gB_geometria.Controls.Add(this.tb_QtdPinos);
            this.gB_geometria.Controls.Add(this.tb_DiamPino);
            this.gB_geometria.Controls.Add(this.tb_AreaLateral);
            this.gB_geometria.Controls.Add(this.tb_AlturaRecorteConsolo);
            this.gB_geometria.Controls.Add(this.tb_CConsolo);
            this.gB_geometria.Controls.Add(this.tb_d);
            this.gB_geometria.Controls.Add(this.tb_dLinha);
            this.gB_geometria.Controls.Add(this.tb_Comprimento);
            this.gB_geometria.Controls.Add(this.tb_Altura);
            this.gB_geometria.Controls.Add(this.tb_Base);
            this.gB_geometria.Location = new System.Drawing.Point(12, 12);
            this.gB_geometria.Name = "gB_geometria";
            this.gB_geometria.Size = new System.Drawing.Size(270, 325);
            this.gB_geometria.TabIndex = 1;
            this.gB_geometria.TabStop = false;
            this.gB_geometria.Text = "Geometria";
            // 
            // lb_Volume
            // 
            this.lb_Volume.AutoSize = true;
            this.lb_Volume.Location = new System.Drawing.Point(10, 273);
            this.lb_Volume.Name = "lb_Volume";
            this.lb_Volume.Size = new System.Drawing.Size(91, 15);
            this.lb_Volume.TabIndex = 1;
            this.lb_Volume.Text = "Volume da Peça";
            // 
            // lb_Peso
            // 
            this.lb_Peso.AutoSize = true;
            this.lb_Peso.Location = new System.Drawing.Point(10, 295);
            this.lb_Peso.Name = "lb_Peso";
            this.lb_Peso.Size = new System.Drawing.Size(76, 15);
            this.lb_Peso.TabIndex = 1;
            this.lb_Peso.Text = "Peso da Peça";
            // 
            // lb_QuantidadePino
            // 
            this.lb_QuantidadePino.AutoSize = true;
            this.lb_QuantidadePino.Location = new System.Drawing.Point(10, 245);
            this.lb_QuantidadePino.Name = "lb_QuantidadePino";
            this.lb_QuantidadePino.Size = new System.Drawing.Size(101, 15);
            this.lb_QuantidadePino.TabIndex = 1;
            this.lb_QuantidadePino.Text = "Quantidade Pinos";
            // 
            // lb_DiametroPino
            // 
            this.lb_DiametroPino.AutoSize = true;
            this.lb_DiametroPino.Location = new System.Drawing.Point(10, 220);
            this.lb_DiametroPino.Name = "lb_DiametroPino";
            this.lb_DiametroPino.Size = new System.Drawing.Size(83, 15);
            this.lb_DiametroPino.TabIndex = 1;
            this.lb_DiametroPino.Text = "Diâmetro Pino";
            // 
            // lb_AreaLateral
            // 
            this.lb_AreaLateral.AutoSize = true;
            this.lb_AreaLateral.Location = new System.Drawing.Point(10, 195);
            this.lb_AreaLateral.Name = "lb_AreaLateral";
            this.lb_AreaLateral.Size = new System.Drawing.Size(69, 15);
            this.lb_AreaLateral.TabIndex = 1;
            this.lb_AreaLateral.Text = "Área Lateral";
            // 
            // lb_AlturaRecorteConsolo
            // 
            this.lb_AlturaRecorteConsolo.AutoSize = true;
            this.lb_AlturaRecorteConsolo.Location = new System.Drawing.Point(10, 170);
            this.lb_AlturaRecorteConsolo.Name = "lb_AlturaRecorteConsolo";
            this.lb_AlturaRecorteConsolo.Size = new System.Drawing.Size(129, 15);
            this.lb_AlturaRecorteConsolo.TabIndex = 1;
            this.lb_AlturaRecorteConsolo.Text = "Altura Recorte Consolo";
            // 
            // lb_CConsolo
            // 
            this.lb_CConsolo.AutoSize = true;
            this.lb_CConsolo.Location = new System.Drawing.Point(10, 145);
            this.lb_CConsolo.Name = "lb_CConsolo";
            this.lb_CConsolo.Size = new System.Drawing.Size(94, 15);
            this.lb_CConsolo.TabIndex = 1;
            this.lb_CConsolo.Text = "Compr. Consolo";
            // 
            // lb_d
            // 
            this.lb_d.AutoSize = true;
            this.lb_d.Location = new System.Drawing.Point(10, 123);
            this.lb_d.Name = "lb_d";
            this.lb_d.Size = new System.Drawing.Size(14, 15);
            this.lb_d.TabIndex = 1;
            this.lb_d.Text = "d";
            // 
            // lb_dLinha
            // 
            this.lb_dLinha.AutoSize = true;
            this.lb_dLinha.Location = new System.Drawing.Point(10, 95);
            this.lb_dLinha.Name = "lb_dLinha";
            this.lb_dLinha.Size = new System.Drawing.Size(17, 15);
            this.lb_dLinha.TabIndex = 1;
            this.lb_dLinha.Text = "d\'";
            // 
            // lb_Comprimento
            // 
            this.lb_Comprimento.AutoSize = true;
            this.lb_Comprimento.Location = new System.Drawing.Point(10, 70);
            this.lb_Comprimento.Name = "lb_Comprimento";
            this.lb_Comprimento.Size = new System.Drawing.Size(82, 15);
            this.lb_Comprimento.TabIndex = 1;
            this.lb_Comprimento.Text = "Comprimento";
            // 
            // lb_Altura
            // 
            this.lb_Altura.AutoSize = true;
            this.lb_Altura.Location = new System.Drawing.Point(10, 45);
            this.lb_Altura.Name = "lb_Altura";
            this.lb_Altura.Size = new System.Drawing.Size(39, 15);
            this.lb_Altura.TabIndex = 1;
            this.lb_Altura.Text = "Altura";
            // 
            // lb_Base
            // 
            this.lb_Base.AutoSize = true;
            this.lb_Base.Location = new System.Drawing.Point(10, 20);
            this.lb_Base.Name = "lb_Base";
            this.lb_Base.Size = new System.Drawing.Size(31, 15);
            this.lb_Base.TabIndex = 1;
            this.lb_Base.Text = "Base";
            // 
            // tb_Peso
            // 
            this.tb_Peso.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Peso.Enabled = false;
            this.tb_Peso.Location = new System.Drawing.Point(146, 295);
            this.tb_Peso.Name = "tb_Peso";
            this.tb_Peso.Size = new System.Drawing.Size(100, 23);
            this.tb_Peso.TabIndex = 0;
            // 
            // tb_Volume
            // 
            this.tb_Volume.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Volume.Enabled = false;
            this.tb_Volume.Location = new System.Drawing.Point(146, 270);
            this.tb_Volume.Name = "tb_Volume";
            this.tb_Volume.Size = new System.Drawing.Size(100, 23);
            this.tb_Volume.TabIndex = 0;
            // 
            // tb_QtdPinos
            // 
            this.tb_QtdPinos.Location = new System.Drawing.Point(146, 245);
            this.tb_QtdPinos.Name = "tb_QtdPinos";
            this.tb_QtdPinos.Size = new System.Drawing.Size(100, 23);
            this.tb_QtdPinos.TabIndex = 0;
            // 
            // tb_DiamPino
            // 
            this.tb_DiamPino.Location = new System.Drawing.Point(146, 220);
            this.tb_DiamPino.Name = "tb_DiamPino";
            this.tb_DiamPino.Size = new System.Drawing.Size(100, 23);
            this.tb_DiamPino.TabIndex = 0;
            // 
            // tb_AreaLateral
            // 
            this.tb_AreaLateral.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_AreaLateral.Enabled = false;
            this.tb_AreaLateral.Location = new System.Drawing.Point(146, 195);
            this.tb_AreaLateral.Name = "tb_AreaLateral";
            this.tb_AreaLateral.Size = new System.Drawing.Size(100, 23);
            this.tb_AreaLateral.TabIndex = 0;
            // 
            // tb_AlturaRecorteConsolo
            // 
            this.tb_AlturaRecorteConsolo.Location = new System.Drawing.Point(146, 170);
            this.tb_AlturaRecorteConsolo.Name = "tb_AlturaRecorteConsolo";
            this.tb_AlturaRecorteConsolo.Size = new System.Drawing.Size(100, 23);
            this.tb_AlturaRecorteConsolo.TabIndex = 0;
            // 
            // tb_CConsolo
            // 
            this.tb_CConsolo.Location = new System.Drawing.Point(146, 145);
            this.tb_CConsolo.Name = "tb_CConsolo";
            this.tb_CConsolo.Size = new System.Drawing.Size(100, 23);
            this.tb_CConsolo.TabIndex = 0;
            // 
            // tb_d
            // 
            this.tb_d.Location = new System.Drawing.Point(146, 120);
            this.tb_d.Name = "tb_d";
            this.tb_d.Size = new System.Drawing.Size(100, 23);
            this.tb_d.TabIndex = 0;
            // 
            // tb_dLinha
            // 
            this.tb_dLinha.Location = new System.Drawing.Point(146, 95);
            this.tb_dLinha.Name = "tb_dLinha";
            this.tb_dLinha.Size = new System.Drawing.Size(100, 23);
            this.tb_dLinha.TabIndex = 0;
            // 
            // tb_Comprimento
            // 
            this.tb_Comprimento.Location = new System.Drawing.Point(146, 70);
            this.tb_Comprimento.Name = "tb_Comprimento";
            this.tb_Comprimento.Size = new System.Drawing.Size(100, 23);
            this.tb_Comprimento.TabIndex = 0;
            // 
            // tb_Altura
            // 
            this.tb_Altura.Location = new System.Drawing.Point(146, 45);
            this.tb_Altura.Name = "tb_Altura";
            this.tb_Altura.Size = new System.Drawing.Size(100, 23);
            this.tb_Altura.TabIndex = 0;
            // 
            // tb_Base
            // 
            this.tb_Base.Location = new System.Drawing.Point(146, 20);
            this.tb_Base.Name = "tb_Base";
            this.tb_Base.Size = new System.Drawing.Size(100, 23);
            this.tb_Base.TabIndex = 0;
            // 
            // Form_Viga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 406);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.gB_geometria);
            this.Controls.Add(this.btn_Geometria);
            this.Name = "Form_Viga";
            this.Text = "Form_Viga";
            this.gB_geometria.ResumeLayout(false);
            this.gB_geometria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Geometria;
        private System.Windows.Forms.GroupBox gB_geometria;
        private System.Windows.Forms.Label lb_Altura;
        private System.Windows.Forms.Label lb_Base;
        private System.Windows.Forms.TextBox tb_Peso;
        private System.Windows.Forms.TextBox tb_Volume;
        private System.Windows.Forms.TextBox tb_QtdPinos;
        private System.Windows.Forms.TextBox tb_DiamPino;
        private System.Windows.Forms.TextBox tb_AreaLateral;
        private System.Windows.Forms.TextBox tb_AlturaRecorteConsolo;
        private System.Windows.Forms.TextBox tb_CConsolo;
        private System.Windows.Forms.TextBox tb_d;
        private System.Windows.Forms.TextBox tb_dLinha;
        private System.Windows.Forms.TextBox tb_Comprimento;
        private System.Windows.Forms.TextBox tb_Altura;
        private System.Windows.Forms.TextBox tb_Base;
        private System.Windows.Forms.Label lb_Volume;
        private System.Windows.Forms.Label lb_Peso;
        private System.Windows.Forms.Label lb_QuantidadePino;
        private System.Windows.Forms.Label lb_DiametroPino;
        private System.Windows.Forms.Label lb_AreaLateral;
        private System.Windows.Forms.Label lb_AlturaRecorteConsolo;
        private System.Windows.Forms.Label lb_CConsolo;
        private System.Windows.Forms.Label lb_d;
        private System.Windows.Forms.Label lb_dLinha;
        private System.Windows.Forms.Label lb_Comprimento;
        private System.Windows.Forms.Button btn_Calcular;
    }
}