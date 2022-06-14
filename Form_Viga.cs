using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fall.Entities; //Necessário para pegar de outra pasta, se estivesse na mesma pasta não precisaria por esse import;

namespace Fall
{
    public partial class Form_Viga : Form
    {
        public Form_Viga()
        {
            InitializeComponent();
        }

        public void calculo()
        {
            Viga v = new Viga();
            string specifier = "#,#.0#";
            v.BaseViga = Double.Parse(tb_Base.Text);
            v.AlturaViga = Double.Parse(tb_Altura.Text);
            v.ComprimentoViga = Double.Parse(tb_Comprimento.Text);
            v.DLinha = Double.Parse(tb_dLinha.Text);
            v.ComprConsolo = Double.Parse(tb_CConsolo.Text);
            v.AlturaRecorteConsolo = Double.Parse(tb_AlturaRecorteConsolo.Text);
            v.DiametroPino = Double.Parse(tb_DiamPino.Text);
            v.QtdPino = Double.Parse(tb_QtdPinos.Text);
            tb_AreaLateral.Text = v.AreaLateral.ToString(specifier) + " m²";
            tb_Volume.Text = v.Volume.ToString(specifier) + " m³";
            tb_Peso.Text = v.Peso.ToString(specifier) + " kg";
        }

        private void btn_Geometria_Click(object sender, EventArgs e)
        {
            Form_GeometriaViga Form_GeometriaViga = new Form_GeometriaViga();
            Form_GeometriaViga.Show();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            calculo();
        }
    }


}
