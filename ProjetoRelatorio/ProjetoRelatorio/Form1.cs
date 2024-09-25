using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoRelatorio
{
    public partial class Form1 : Form
    {
        //Instanciar o aobjeto da classe Compra
        Compra cmp = new Compra();


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            int codigo, estoque;
            string genero, descricao;
            double valor_unitario;

            codigo = int.Parse(txt_Codigo.Text);
            descricao = txt_Descricao.Text;
            genero = cmb_Genero.SelectedItem.ToString();
            estoque = int.Parse(txt_Estoque.Text);
            valor_unitario = double.Parse(msk_Valor.Text);

            cmp.Codigo = codigo;
            cmp.Descricao = descricao;
            cmp.Estoque = estoque;
            cmp.Genero = genero;
            cmp.Valor_unitario = valor_unitario;

            MessageBox.Show("Produto Registrado");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string dados;
            //chama o metodo da classe compra e guarda na variavel dados
            dados = cmp.mostraDadosCadastrados();

            // cria um objeto fonte para armazenar tipo da fonte
            Font times12 = new Font("Times New Roman", 12);
            // cria um objeto para armazenar a cor da fonte
            SolidBrush brushBlack = new SolidBrush(Color.Black);

            Font times16 = new Font("Arial", 16);
            SolidBrush brushBlue = new SolidBrush(Color.Blue);

            e.Graphics.DrawString("MERCADINHO'S", times16, brushBlue, new Point(10, 100));
            e.Graphics.DrawString(dados, times12, brushBlack, new Point(50, 250));
        }

        private void btn_GerarNota_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
