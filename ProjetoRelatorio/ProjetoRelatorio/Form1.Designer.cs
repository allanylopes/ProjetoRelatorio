namespace ProjetoRelatorio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Genero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Estoque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.msk_Valor = new System.Windows.Forms.MaskedTextBox();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.btn_GerarNota = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Compra de Produtos";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Location = new System.Drawing.Point(115, 95);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(73, 20);
            this.txt_Codigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição:";
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(115, 140);
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(267, 20);
            this.txt_Descricao.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gênero:";
            // 
            // cmb_Genero
            // 
            this.cmb_Genero.FormattingEnabled = true;
            this.cmb_Genero.Items.AddRange(new object[] {
            "Alimentícios",
            "Bebidas",
            "Limpeza",
            "Higiene",
            "Utensílios"});
            this.cmb_Genero.Location = new System.Drawing.Point(115, 181);
            this.cmb_Genero.Name = "cmb_Genero";
            this.cmb_Genero.Size = new System.Drawing.Size(121, 21);
            this.cmb_Genero.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Estoque:";
            // 
            // txt_Estoque
            // 
            this.txt_Estoque.Location = new System.Drawing.Point(115, 216);
            this.txt_Estoque.Name = "txt_Estoque";
            this.txt_Estoque.Size = new System.Drawing.Size(100, 20);
            this.txt_Estoque.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor Unitário:";
            // 
            // msk_Valor
            // 
            this.msk_Valor.Location = new System.Drawing.Point(130, 255);
            this.msk_Valor.Mask = "999,99";
            this.msk_Valor.Name = "msk_Valor";
            this.msk_Valor.Size = new System.Drawing.Size(58, 20);
            this.msk_Valor.TabIndex = 10;
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.Image = global::ProjetoRelatorio.Properties.Resources.cart_add;
            this.btn_Comprar.Location = new System.Drawing.Point(35, 314);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(127, 51);
            this.btn_Comprar.TabIndex = 11;
            this.btn_Comprar.Text = "COMPRAR";
            this.btn_Comprar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Comprar.UseVisualStyleBackColor = true;
            this.btn_Comprar.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // btn_GerarNota
            // 
            this.btn_GerarNota.Image = global::ProjetoRelatorio.Properties.Resources.ListarConsultas;
            this.btn_GerarNota.Location = new System.Drawing.Point(413, 94);
            this.btn_GerarNota.Name = "btn_GerarNota";
            this.btn_GerarNota.Size = new System.Drawing.Size(112, 63);
            this.btn_GerarNota.TabIndex = 12;
            this.btn_GerarNota.Text = "GERAR NOTA";
            this.btn_GerarNota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_GerarNota.UseVisualStyleBackColor = true;
            this.btn_GerarNota.Click += new System.EventHandler(this.btn_GerarNota_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Image = global::ProjetoRelatorio.Properties.Resources.Sair;
            this.btn_Sair.Location = new System.Drawing.Point(190, 314);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(127, 51);
            this.btn_Sair.TabIndex = 13;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Sair.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoRelatorio.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 407);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_GerarNota);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.msk_Valor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Estoque);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Genero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Genero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Estoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox msk_Valor;
        private System.Windows.Forms.Button btn_Comprar;
        private System.Windows.Forms.Button btn_GerarNota;
        private System.Windows.Forms.Button btn_Sair;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

