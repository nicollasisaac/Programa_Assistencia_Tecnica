using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Assistencia_Tecnica
{
    public partial class Estoque : Form
    {
        Point btn = new Point(46, 369);
        Point btn2 = new Point(46, 520);
        int x;
        int z;
        public Estoque()
        {
            InitializeComponent();
            btn_adicionar.Location = btn;
            btn_especificacao.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
        }

        private void btn_especificacao_Click(object sender, EventArgs e)
        {
            if (txt_Bateria.Visible == false)
            {
                btn_adicionar.Location = btn2;
                label2.Visible = true;
                label3.Visible = true;
                txt_Bateria.Visible = true;
                txt_Tela.Visible = true;
            }
            else
            {
                btn_adicionar.Location = btn;
                label2.Visible = false;
                label3.Visible = false;
                txt_Bateria.Visible = false;
                txt_Tela.Visible = false;
            }
        }
        void Selecionar_ltbItem()
        {
            ltb_nome.SelectedIndex = x;
            ltb_valorRevenda.SelectedIndex = x;
            ltb_bateria.SelectedIndex = x;
            ltb_tela.SelectedIndex = x;
            ltb_estoque.SelectedIndex = x;
            ltb_precoCusto.SelectedIndex = x;
            ltb_valorRevenda.SelectedIndex = x;
        }

        private void ltb_nome_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = ltb_nome.SelectedIndex;

            Selecionar_ltbItem();
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

        private void ltb_precoCusto_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = ltb_precoCusto.SelectedIndex;

            Selecionar_ltbItem();
        }

        private void ltb_valorRevenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = ltb_valorRevenda.SelectedIndex;

            Selecionar_ltbItem();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(txt_produto.Text != "" && txt_PrecoCusto.Text != "" && txt_ValorRevenda.Text != "" && txt_Estoque.Text != "" && txt_produto.Visible == true)
            {
                ltb_nome.Items.Add(txt_produto.Text);
                if (txt_Bateria.Text == "" && txt_Tela.Text == "")
                {
                    ltb_tela.Items.Add("Não tem");
                    ltb_bateria.Items.Add("Não tem");
                }
                else
                {
                    ltb_tela.Items.Add(txt_Tela.Text);
                    ltb_bateria.Items.Add(txt_Bateria.Text);
                }
                try
                {
                    float estoque, precoCusto, valorRevenda;

                    estoque = float.Parse(txt_Estoque.Text);
                    ltb_estoque.Items.Add(txt_Estoque.Text);

                    precoCusto = float.Parse(txt_PrecoCusto.Text);
                    ltb_precoCusto.Items.Add(txt_PrecoCusto.Text);

                    valorRevenda = float.Parse(txt_ValorRevenda.Text);
                    ltb_valorRevenda.Items.Add(txt_ValorRevenda.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Em Estoque, Preço de custo e Valor de Revenda são aceitos somente números !!");
                }

                Limpar();
                // Voltar ao normal
                btn_adicionar.Location = btn;
                label2.Visible = false;
                label3.Visible = false;
                txt_Bateria.Visible = false;
                txt_Tela.Visible = false;

            }
            else if(txt_produto.Visible == false)
            {
                ltb_valorRevenda.Items[z] = txt_ValorRevenda.Text;
                ltb_estoque.Items[z] = Convert.ToDouble(txt_Estoque.Text) + Convert.ToDouble(ltb_estoque.Items[z]);
                ltb_precoCusto.Items[z] = txt_PrecoCusto.Text;

                btn_adicionar.Location = btn2;

                //Undo
                // Ativando Labels
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;

                //Ativando textbox
                txt_produto.Visible = true;
                btn_especificacao.Visible = true;
                txt_Bateria.Visible = true;
                txt_Tela.Visible = true;


                label5.Text = "Valor de revenda";
                label6.Text = "N° de aparelhos" + "\n" + "no estoque";

                Limpar();
                // Voltar ao normal
                btn_adicionar.Location = btn;
                label2.Visible = false;
                label3.Visible = false;
                txt_Bateria.Visible = false;
                txt_Tela.Visible = false;

                btn_edicao.Visible = false;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            if (ltb_nome.SelectedIndex > -1)
            {
                var y = ltb_nome.SelectedIndex;

                ltb_nome.Items.Remove(ltb_nome.Items[y]);
                ltb_bateria.Items.Remove(ltb_bateria.Items[y]);
                ltb_tela.Items.Remove(ltb_tela.Items[y]);
                ltb_estoque.Items.Remove(ltb_estoque.Items[y]);
                ltb_precoCusto.Items.Remove(ltb_precoCusto.Items[y]);
                ltb_valorRevenda.Items.Remove(ltb_valorRevenda.Items[y]);
            }
        }
        void Double_Click()
        {
            if (ltb_nome.SelectedIndex > -1)
            {
                if (DialogResult.Yes == MessageBox.Show("Vocês está prestes a entrar no modo edição, tem certeza desta ação?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    txt_produto.Text = ltb_nome.SelectedItem.ToString();
                    txt_Bateria.Text = ltb_bateria.SelectedItem.ToString();
                    txt_Tela.Text = ltb_tela.SelectedItem.ToString();
                    txt_Estoque.Text = ltb_estoque.SelectedItem.ToString();
                    txt_PrecoCusto.Text = ltb_precoCusto.SelectedItem.ToString();
                    txt_ValorRevenda.Text = ltb_valorRevenda.SelectedItem.ToString();

                    // Desativando Labels
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;

                    //Desativando textbox
                    txt_produto.Visible = false;
                    btn_especificacao.Visible = false;
                    txt_Bateria.Visible = false;
                    txt_Tela.Visible = false;

                    btn_adicionar.Location = btn;

                    label5.Text = "Novo valor de revenda";
                    label6.Text = "Quantidade à adicionar" + "\n" + "ao estoque";

                    z = x;

                    // Ativando visibilidade do botão ao entrar no modo edição
                    btn_edicao.Visible = true;
                }
            }
        }

        private void ltb_nome_DoubleClick(object sender, EventArgs e)
        {
            Double_Click();
        }
        void Limpar()
        {
            txt_produto.Clear();
            txt_PrecoCusto.Clear();
            txt_ValorRevenda.Clear();
            txt_Estoque.Clear();
            txt_Bateria.Clear();
            txt_Tela.Clear();
        }

        private void ltb_bateria_DoubleClick(object sender, EventArgs e)
        {
            Double_Click();
        }

        private void ltb_tela_DoubleClick(object sender, EventArgs e)
        {
            Double_Click();
        }

        private void ltb_estoque_DoubleClick(object sender, EventArgs e)
        {
            Double_Click();
        }

        private void ltb_precoCusto_DoubleClick(object sender, EventArgs e)
        {
            Double_Click();
        }

        private void ltb_valorRevenda_DoubleClick(object sender, EventArgs e)
        {
            Double_Click();
        }

        private void btn_edicao_Click(object sender, EventArgs e)
        {
            btn_adicionar.Location = btn2;

            //Undo
            // Ativando Labels
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            //Ativando textbox
            txt_produto.Visible = true;
            btn_especificacao.Visible = true;
            txt_Bateria.Visible = true;
            txt_Tela.Visible = true;


            label5.Text = "Valor de revenda";
            label6.Text = "N° de aparelhos" + "\n" + "no estoque";

            Limpar();
            // Voltar ao normal
            btn_adicionar.Location = btn;
            label2.Visible = false;
            label3.Visible = false;
            txt_Bateria.Visible = false;
            txt_Tela.Visible = false;

            //Desativando btn de edição
            btn_edicao.Visible = false;
        }

        private void Estoque_Leave(object sender, EventArgs e)
        {
            for(int i = 0; i < ltb_nome.Items.Count; i++)
            {
              richTextBox1.Text += ltb_nome.Items[i] + "\n";
              richTextBox2.Text += ltb_bateria.Items[i] + "\n";
              richTextBox3.Text += ltb_tela.Items[i] + "\n";
              richTextBox4.Text += ltb_estoque.Items[i] + "\n";
              richTextBox5.Text += ltb_precoCusto.Items[i] + "\n";
              richTextBox6.Text += ltb_valorRevenda.Items[i] + "\n";
              // Salvar dados
              SalvarItens();
            }
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarItens();
                for (int i = 0; i < richTextBox1.Lines.Length - 1; i++)
                { 

                    ltb_nome.Items.Add(richTextBox1.Lines[i]);
                    ltb_bateria.Items.Add(richTextBox2.Lines[i]);
                    ltb_tela.Items.Add(richTextBox3.Lines[i]);
                    ltb_estoque.Items.Add(richTextBox4.Lines[i]);
                    ltb_precoCusto.Items.Add(richTextBox5.Lines[i]);
                    ltb_valorRevenda.Items.Add(richTextBox6.Lines[i]);
                }
            }
            catch(Exception ex)
            {
                SalvarItens();
                for (int i = 0; i < richTextBox1.Lines.Length - 1; i++)
                {
                   ltb_nome.Items.Add(richTextBox1.Lines[i]);
                   ltb_bateria.Items.Add(richTextBox2.Lines[i]);
                   ltb_tela.Items.Add(richTextBox3.Lines[i]);
                   ltb_estoque.Items.Add(richTextBox4.Lines[i]);
                   ltb_precoCusto.Items.Add(richTextBox5.Lines[i]);
                   ltb_valorRevenda.Items.Add(richTextBox6.Lines[i]);
                }
            }
            LimparDados();
        }
        void SalvarItens()
        {
            richTextBox1.SaveFile("Nome.txt", RichTextBoxStreamType.PlainText);
            richTextBox2.SaveFile("Bateria.txt", RichTextBoxStreamType.PlainText);
            richTextBox3.SaveFile("Tela.txt", RichTextBoxStreamType.PlainText);
            richTextBox4.SaveFile("Estoque.txt", RichTextBoxStreamType.PlainText);
            richTextBox5.SaveFile("PrecoCusto.txt", RichTextBoxStreamType.PlainText);
            richTextBox6.SaveFile("ValorRevenda.txt", RichTextBoxStreamType.PlainText);
        }
        void CarregarItens()
        {
            richTextBox1.LoadFile("Nome.txt", RichTextBoxStreamType.PlainText);
            richTextBox2.LoadFile("Bateria.txt", RichTextBoxStreamType.PlainText);
            richTextBox3.LoadFile("Tela.txt", RichTextBoxStreamType.PlainText);
            richTextBox4.LoadFile("Estoque.txt", RichTextBoxStreamType.PlainText);
            richTextBox5.LoadFile("PrecoCusto.txt", RichTextBoxStreamType.PlainText);
            richTextBox6.LoadFile("ValorRevenda.txt", RichTextBoxStreamType.PlainText);
        }
        void LimparDados()
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox4.Clear();
            richTextBox5.Clear();
            richTextBox6.Clear();
        }
    }
}
