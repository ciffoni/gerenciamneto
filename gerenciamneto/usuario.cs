using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios; // biblioteca para pegar informações 
using System.ClientModel.Primitives;
namespace gerenciamneto
{
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
        }

        private void usuario_Load(object sender, EventArgs e)
        {

        }

        private void txtcep_Leave(object sender, EventArgs e)
        {
            // instanciar a api do correio
            var correios= new CorreiosApi();
            var dados = correios.consultaCEP(txtcep.Text);
            MessageBox.Show("Enreço:" + dados.end.ToString() +
                "cidade:" + dados.cidade.ToString() + "Bairro:" + dados.bairro.ToString());
        }
    }
}
