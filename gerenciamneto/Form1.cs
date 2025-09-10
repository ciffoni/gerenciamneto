using gerenciamneto.objeto;

namespace gerenciamneto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            con.getConexao();
            //chamando o objeto financeiro
            financeirocs fin=new financeirocs();
            //populando as informações
            fin.data_lancamento = Data_lancamento.Text;
            fin.descricao=txtDescricao.Text;
            fin.servico=cboServico.Text;
            fin.valor=Convert.ToDecimal(txtValor.Text);
            fin.tipo=cboTipo.Text;
            fin.pgto=chkpagamento.Checked;
           if( fin.cadastrar(con)== true)
            {
                MessageBox.Show("Cadastrado com sucesso");
            }

        }
    }
}
