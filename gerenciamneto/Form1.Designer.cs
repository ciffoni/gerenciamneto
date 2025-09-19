namespace gerenciamneto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCodigo = new TextBox();
            txtDescricao = new TextBox();
            txtValor = new TextBox();
            cboTipo = new ComboBox();
            cboServico = new ComboBox();
            Data_lancamento = new DateTimePicker();
            chkpagamento = new CheckBox();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnPesquisar = new Button();
            label8 = new Label();
            txtPesquisar = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 35);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 78);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 124);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "valor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 169);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "tipo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 207);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "serviço:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 247);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 5;
            label6.Text = "Data:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 294);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 6;
            label7.Text = "pagamento:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(130, 35);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 7;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(130, 77);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(125, 27);
            txtDescricao.TabIndex = 8;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(130, 122);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 9;
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(130, 172);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(151, 28);
            cboTipo.TabIndex = 10;
            // 
            // cboServico
            // 
            cboServico.FormattingEnabled = true;
            cboServico.Location = new Point(130, 209);
            cboServico.Name = "cboServico";
            cboServico.Size = new Size(151, 28);
            cboServico.TabIndex = 11;
            // 
            // Data_lancamento
            // 
            Data_lancamento.Location = new Point(130, 247);
            Data_lancamento.Name = "Data_lancamento";
            Data_lancamento.Size = new Size(250, 27);
            Data_lancamento.TabIndex = 12;
            // 
            // chkpagamento
            // 
            chkpagamento.AutoSize = true;
            chkpagamento.Location = new Point(155, 294);
            chkpagamento.Name = "chkpagamento";
            chkpagamento.Size = new Size(101, 24);
            chkpagamento.TabIndex = 13;
            chkpagamento.Text = "checkBox1";
            chkpagamento.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(42, 347);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(94, 29);
            btnCadastrar.TabIndex = 14;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(160, 351);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(281, 357);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(645, 12);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 17;
            btnPesquisar.Text = "buscar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(391, 17);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 18;
            label8.Text = "psquisar";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(496, 14);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(125, 27);
            txtPesquisar.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(414, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(665, 322);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(822, 24);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "Relatório";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtPesquisar);
            Controls.Add(label8);
            Controls.Add(btnPesquisar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(chkpagamento);
            Controls.Add(Data_lancamento);
            Controls.Add(cboServico);
            Controls.Add(cboTipo);
            Controls.Add(txtValor);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodigo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCodigo;
        private TextBox txtDescricao;
        private TextBox txtValor;
        private ComboBox cboTipo;
        private ComboBox cboServico;
        private DateTimePicker Data_lancamento;
        private CheckBox chkpagamento;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnPesquisar;
        private Label label8;
        private TextBox txtPesquisar;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
