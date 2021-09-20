using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Assistencia_Tecnica
{
    public partial class Caixa : Form
    {
        int x = 0;
        int y = 0;
        int c = 0;
        public Caixa()
        {
            InitializeComponent();
            var x = 0;
        }
        private void btn_pesquisa_Click(object sender, EventArgs e)
        {
            bool achou = false;
            for (int i = 0; i < ltb_nome.Items.Count; i++)
            {
                if (ltb_nome.Items[i].ToString() == txt_consulta.Text)
                {
                    ltb_nome.SelectedIndex = i;
                    achou = true;
                }
            }
            var y = ltb_nome.SelectedIndex;
            if (achou == true)
            {
                ltb_tela.SelectedIndex = y;
                ltb_bateria.SelectedIndex = y;
                ltb_estoque.SelectedIndex = y;
                ltb_valorRevenda.SelectedIndex = y;
            }
            else
            {
                MessageBox.Show("O item procurado não existe, certifique-se de que escreveu o nome do produto corretamente !!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txt_consulta.Clear();
            if (txt_consulta.Text == "")
            {
                txt_consulta.Text = "Digite o nome do produto";
                txt_consulta.ForeColor = Color.Gray;
            }
        }
        void Selecionar_ltbItem()
        {
            ltb_nome.SelectedIndex = x;
            ltb_valorRevenda.SelectedIndex = x;
            ltb_bateria.SelectedIndex = x;
            ltb_tela.SelectedIndex = x;
            ltb_estoque.SelectedIndex = x;
            ltb_valorRevenda.SelectedIndex = x;
        }

        private void ltb_bateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = ltb_bateria.SelectedIndex;

            Selecionar_ltbItem();
        }

        private void ltb_tela_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = ltb_tela.SelectedIndex;

            Selecionar_ltbItem();
        }

        private void ltb_estoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = ltb_estoque.SelectedIndex;

            Selecionar_ltbItem();
        }

        private void ltb_valorRevenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = ltb_valorRevenda.SelectedIndex;

            Selecionar_ltbItem();
        }

        void DoubleClick1()
        {
            var u = ltb_estoque.SelectedIndex;
            try
            {
                if (Convert.ToDouble(ltb_estoque.Items[u]) > 0)
                {
                    string estoque;
                    estoque = ((Convert.ToDouble(ltb_estoque.Items[u]) - 1)).ToString();
                    ltb_estoque.Items[u] = estoque;
                    ltb_nomeProduto.Items.Add(ltb_nome.SelectedItem.ToString());
                    ltb_produto.Items.Add(ltb_bateria.SelectedItem.ToString() + "\t  " + ltb_tela.SelectedItem.ToString());
                    ltb_itens.Items.Add("1");
                    ltb_preco.Items.Add(ltb_valorRevenda.SelectedItem.ToString());

                    double Total;
                    Total = Convert.ToDouble(txt_total.Text);
                    txt_total.Text = (Convert.ToDouble(Total) + Convert.ToDouble(ltb_valorRevenda.SelectedItem)).ToString();
                }
                else
                {
                    MessageBox.Show("O item desejado esta em falta na loja !!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void ltb_nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = ltb_nome.SelectedIndex;

            Selecionar_ltbItem();
        }

        private void ltb_nome_DoubleClick(object sender, EventArgs e)
        {
            DoubleClick1();
        }

        private void ltb_bateria_DoubleClick(object sender, EventArgs e)
        {
            DoubleClick1();
        }

        private void ltb_tela_DoubleClick(object sender, EventArgs e)
        {
            DoubleClick1();
        }

        private void ltb_estoque_DoubleClick(object sender, EventArgs e)
        {
            DoubleClick1();
        }

        private void ltb_valorRevenda_DoubleClick(object sender, EventArgs e)
        {
            DoubleClick1();
        }
        void Selecionar_itemCompra()
        {
            ltb_produto.SelectedIndex = y;
            ltb_preco.SelectedIndex = y;
            ltb_itens.SelectedIndex = y;
            ltb_nomeProduto.SelectedIndex = y;
        }

        private void ltb_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            y = ltb_produto.SelectedIndex;

            Selecionar_itemCompra();
        }

        private void ltb_itens_SelectedIndexChanged(object sender, EventArgs e)
        {
            y = ltb_itens.SelectedIndex;

            Selecionar_itemCompra();
        }

        private void ltb_preco_SelectedIndexChanged(object sender, EventArgs e)
        {
            y = ltb_preco.SelectedIndex;

            Selecionar_itemCompra();
        }

        private void Caixa_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("Nome.txt", RichTextBoxStreamType.PlainText);
            richTextBox2.LoadFile("Bateria.txt", RichTextBoxStreamType.PlainText);
            richTextBox3.LoadFile("Tela.txt", RichTextBoxStreamType.PlainText);
            richTextBox4.LoadFile("Estoque.txt", RichTextBoxStreamType.PlainText);
            richTextBox5.LoadFile("ValorRevenda.txt", RichTextBoxStreamType.PlainText);

            for (int i = 0; i < richTextBox1.Lines.Length - 1; i++)
            {

                ltb_nome.Items.Add(richTextBox1.Lines[i]);
                ltb_bateria.Items.Add(richTextBox2.Lines[i]);
                ltb_tela.Items.Add(richTextBox3.Lines[i]);
                ltb_estoque.Items.Add(richTextBox4.Lines[i]);
                ltb_valorRevenda.Items.Add(richTextBox5.Lines[i]);
            }
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
        }

        private void txt_consulta_Leave(object sender, EventArgs e)
        {
            if (txt_consulta.Text == "")
            {
                txt_consulta.Text = "Digite o nome do produto";
                txt_consulta.ForeColor = Color.Gray;
            }
        }

        private void txt_consulta_Enter(object sender, EventArgs e)
        {
            if (txt_consulta.Text == "Digite o nome do produto")
            {
                txt_consulta.Text = "";
                txt_consulta.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0,00";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0,00")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "0,00")
            {
                lbl_troco.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(txt_total.Text)).ToString();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Tem certezar que quer finalizar a compra ??", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                textBox1.Text = "0,00";
                lbl_troco.Text = "0,00";
                txt_total.Text = "0,00";
                ltb_nomeProduto.Items.Clear();
                ltb_produto.Items.Clear();
                ltb_itens.Items.Clear();
                ltb_preco.Items.Clear();
            }
            else
            {
                MessageBox.Show("Compra não finalizada !!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string lixo;
                var nlixo = ltb_nomeProduto.SelectedIndex;
                lixo = ltb_nomeProduto.SelectedItem.ToString();
                bool achou = false;
                for (int i = 0; i < ltb_nome.Items.Count; i++)
                {
                    if (ltb_nome.Items[i].ToString() == lixo)
                    {
                        ltb_nome.SelectedIndex = i;
                        achou = true;
                    }
                }
                var l = ltb_estoque.SelectedIndex;
                ltb_estoque.Items[l] = (Convert.ToDouble(ltb_estoque.Items[l]) + 1);

                var nl = ltb_nomeProduto.SelectedIndex;

                //Subtraindo valor excluído, do total

                txt_total.Text = (Convert.ToDouble(txt_total.Text) - Convert.ToDouble(ltb_preco.Items[nl])).ToString();

                // Excluindo itens

                ltb_nomeProduto.Items.Remove(ltb_nomeProduto.Items[nl]);
                ltb_itens.Items.Remove(ltb_itens.Items[nl]);
                ltb_preco.Items.Remove(ltb_preco.Items[nl]);
                ltb_produto.Items.Remove(ltb_produto.Items[nl]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Você tem que selecionar algum item para conseguir remover !!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ltb_nomeProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            y = ltb_nomeProduto.SelectedIndex;

            Selecionar_itemCompra();
        }

        private void Caixa_Leave(object sender, EventArgs e)
        {
            for (int i = 0; i < ltb_nome.Items.Count; i++)
            {
                richTextBox1.Text += ltb_nome.Items[i] + "\n";
                richTextBox2.Text += ltb_bateria.Items[i] + "\n";
                richTextBox3.Text += ltb_tela.Items[i] + "\n";
                richTextBox4.Text += ltb_estoque.Items[i] + "\n";
                richTextBox5.Text += ltb_valorRevenda.Items[i] + "\n";
                // Salvar dados
                richTextBox1.SaveFile("Nome.txt", RichTextBoxStreamType.PlainText);
                richTextBox2.SaveFile("Bateria.txt", RichTextBoxStreamType.PlainText);
                richTextBox3.SaveFile("Tela.txt", RichTextBoxStreamType.PlainText);
                richTextBox4.SaveFile("Estoque.txt", RichTextBoxStreamType.PlainText);
                richTextBox5.SaveFile("ValorRevenda.txt", RichTextBoxStreamType.PlainText);
            }
        }
    }
}
