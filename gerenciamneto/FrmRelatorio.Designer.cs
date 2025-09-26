namespace gerenciamneto
{
    partial class FrmRelatorio
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
            btnExcel = new Button();
            btnPDF = new Button();
            SuspendLayout();
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(405, 39);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(94, 29);
            btnExcel.TabIndex = 0;
            btnExcel.Text = "Gerar Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnPDF
            // 
            btnPDF.Location = new Point(420, 95);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(94, 29);
            btnPDF.TabIndex = 1;
            btnPDF.Text = "Gerar PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // FrmRelatorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPDF);
            Controls.Add(btnExcel);
            Name = "FrmRelatorio";
            Text = "FrmRelatorio";
            Load += FrmRelatorio_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnExcel;
        private Button btnPDF;
    }
}