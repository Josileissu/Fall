using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {

        }
        private void btn_Vigas_Click(object sender, EventArgs e)
        {
            Form_Viga Form_Viga = new Form_Viga();
            Form_Viga.Show();
            //se eu quisesse fechar o formulário que está aberto, é só fazer this.close();
        }

        private void btn_Pilares_Click(object sender, EventArgs e)
        {

        }
    }
}
