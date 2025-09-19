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
            financeirocs fin = new financeirocs();
            //populando as informações
            fin.data_lancamento = Data_lancamento.Value;
            fin.descricao = txtDescricao.Text;
            fin.servico = cboServico.Text;
            fin.valor = decimal.Parse(txtValor.Text);
            fin.tipo = cboTipo.Text;
            fin.pgto = chkpagamento.Checked;
            if (fin.cadastrar(con) == true)
            {
                MessageBox.Show("Cadastrado com sucesso");
                dataGridView1.Refresh();// atualiza o grid
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //chamo o objeto da conexao
            conexao com = new conexao();
            com.getConexao();
            dataGridView1.DataSource = com.obterdados("select * from financeiro");
            cboServico.Items.Add("Salário");
            cboServico.Items.Add("despesas");
            cboTipo.Items.Add("Entrada");
            cboTipo.Items.Add("Saída");


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //chamo o metodo da conexao
            conexao com = new conexao();
            com.getConexao();
            // chama o objeto do financeiro
            financeirocs financeiro = new financeirocs();
            financeiro.id = Convert.ToInt32(txtCodigo.Text);
            financeiro.descricao = txtDescricao.Text;
            financeiro.servico = cboServico.Text;
            financeiro.tipo = cboTipo.Text;
            financeiro.valor = decimal.Parse(txtValor.Text);
            financeiro.pgto = chkpagamento.Checked;
            financeiro.data_lancamento = Data_lancamento.Value;
            if (financeiro.editar(com) == true)
            {
                MessageBox.Show("Editado com sucesso!");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int codigo = 0;
            codigo = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            txtCodigo.Text = codigo.ToString();
            txtDescricao.Text = dataGridView1.Rows[e.RowIndex].Cells["descricao"].Value.ToString();
            txtValor.Text = dataGridView1.Rows[e.RowIndex].Cells["valor"].Value.ToString();
            cboServico.Text = dataGridView1.Rows[e.RowIndex].Cells["servico"].Value.ToString();
            cboTipo.Text = dataGridView1.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
            //convertendo o data implicitamente
            Data_lancamento.Value = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["data_lancamento"].Value;
            bool pago = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells["pgto"].Value.ToString());
            if (pago == true)
            {
                chkpagamento.Checked = true;
            }
            else
            {
                chkpagamento.Checked = false;
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //chamo o metodo da conexao
            conexao com = new conexao();
            com.getConexao();
            // chama o objeto do financeiro
            financeirocs financeiro = new financeirocs();
            financeiro.id = Convert.ToInt32(txtCodigo.Text);
            if (financeiro.Excluir(com) == true)
            {
                MessageBox.Show("Excluido com sucesso");
                dataGridView1.Refresh();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            conexao com = new conexao();
            com.getConexao();
            if (string.IsNullOrEmpty(txtPesquisar.Text))
            {
                dataGridView1.DataSource = com.obterdados("select * from financeiro");
            }
            else
            {
                dataGridView1.DataSource = com.obterdados("select * from financeiro where descricao like '%" + txtPesquisar.Text + "%' or data_lancamento like '%" + txtPesquisar.Text + "%'");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chama o formulario instancia o objeto
            FrmRelatorio relatorio = new FrmRelatorio();
            //abre a tela do relatorio
            relatorio.ShowDialog();
        }
    }
}
