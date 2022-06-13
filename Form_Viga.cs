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
            Viga v = new Viga();
            v.BaseViga = 20;
            v.AlturaViga = 40;
            v.ComprimentoViga = 500;
            v.DLinha = 2.5;
            v.ComprConsolo = 25;
            v.AlturaRecorteConsolo = 25;
            v.DiametroPino = 32;
            v.QtdPino = 4;
        }

        public void calculo()
        {
            
        }

        private void btn_Geometria_Click(object sender, EventArgs e)
        {
            Form_GeometriaViga Form_GeometriaViga = new Form_GeometriaViga();
            Form_GeometriaViga.Show();
        }

        private void tb_Base_TextChanged(object sender, EventArgs e)
        {
            
        }
    }


}
