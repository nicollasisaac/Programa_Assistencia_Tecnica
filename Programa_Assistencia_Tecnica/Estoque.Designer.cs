namespace Programa_Assistencia_Tecnica
{
    partial class Estoque
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
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Estoque = new System.Windows.Forms.TextBox();
            this.ltb_valorRevenda = new System.Windows.Forms.ListBox();
            this.btn_Remover = new FontAwesome.Sharp.IconButton();
            this.btn_adicionar = new FontAwesome.Sharp.IconButton();
            this.ltb_precoCusto = new System.Windows.Forms.ListBox();
            this.ltb_estoque = new System.Windows.Forms.ListBox();
            this.ltb_nome = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ValorRevenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PrecoCusto = new System.Windows.Forms.TextBox();
            this.txt_Tela = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Bateria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.ltb_tela = new System.Windows.Forms.ListBox();
            this.ltb_bateria = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_especificacao = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_edicao = new FontAwesome.Sharp.IconButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Alatsi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 60);
            this.label6.TabIndex = 39;
            this.label6.Text = "N° de aparelhos \r\nno estoque";
            // 
            // txt_Estoque
            // 
            this.txt_Estoque.Location = new System.Drawing.Point(46, 346);
            this.txt_Estoque.Name = "txt_Estoque";
            this.txt_Estoque.Size = new System.Drawing.Size(171, 20);
            this.txt_Estoque.TabIndex = 38;
            // 
            // ltb_valorRevenda
            // 
            this.ltb_valorRevenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltb_valorRevenda.FormattingEnabled = true;
            this.ltb_valorRevenda.Location = new System.Drawing.Point(1045, 96);
            this.ltb_valorRevenda.Name = "ltb_valorRevenda";
            this.ltb_valorRevenda.Size = new System.Drawing.Size(125, 377);
            this.ltb_valorRevenda.TabIndex = 37;
            this.ltb_valorRevenda.SelectedIndexChanged += new System.EventHandler(this.ltb_valorRevenda_SelectedIndexChanged);
            this.ltb_valorRevenda.DoubleClick += new System.EventHandler(this.ltb_valorRevenda_DoubleClick);
            // 
            // btn_Remover
            // 
            this.btn_Remover.FlatAppearance.BorderSize = 0;
            this.btn_Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remover.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Remover.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remover.ForeColor = System.Drawing.Color.White;
            this.btn_Remover.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btn_Remover.IconColor = System.Drawing.Color.White;
            this.btn_Remover.IconSize = 30;
            this.btn_Remover.Location = new System.Drawing.Point(1051, 479);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Rotation = 0D;
            this.btn_Remover.Size = new System.Drawing.Size(119, 43);
            this.btn_Remover.TabIndex = 36;
            this.btn_Remover.Tag = "";
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_adicionar.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.Color.White;
            this.btn_adicionar.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btn_adicionar.IconColor = System.Drawing.Color.White;
            this.btn_adicionar.IconSize = 40;
            this.btn_adicionar.Location = new System.Drawing.Point(46, 520);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Rotation = 0D;
            this.btn_adicionar.Size = new System.Drawing.Size(171, 55);
            this.btn_adicionar.TabIndex = 35;
            this.btn_adicionar.Text = "Adicionar ao estoque";
            this.btn_adicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // ltb_precoCusto
            // 
            this.ltb_precoCusto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltb_precoCusto.FormattingEnabled = true;
            this.ltb_precoCusto.Location = new System.Drawing.Point(932, 96);
            this.ltb_precoCusto.Name = "ltb_precoCusto";
            this.ltb_precoCusto.Size = new System.Drawing.Size(113, 377);
            this.ltb_precoCusto.TabIndex = 34;
            this.ltb_precoCusto.SelectedIndexChanged += new System.EventHandler(this.ltb_precoCusto_SelectedIndexChanged);
            this.ltb_precoCusto.DoubleClick += new System.EventHandler(this.ltb_precoCusto_DoubleClick);
            // 
            // ltb_estoque
            // 
            this.ltb_estoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltb_estoque.FormattingEnabled = true;
            this.ltb_estoque.Location = new System.Drawing.Point(831, 96);
            this.ltb_estoque.Name = "ltb_estoque";
            this.ltb_estoque.Size = new System.Drawing.Size(101, 377);
            this.ltb_estoque.TabIndex = 33;
            this.ltb_estoque.SelectedIndexChanged += new System.EventHandler(this.ltb_estoque_SelectedIndexChanged);
            this.ltb_estoque.DoubleClick += new System.EventHandler(this.ltb_estoque_DoubleClick);
            // 
            // ltb_nome
            // 
            this.ltb_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltb_nome.FormattingEnabled = true;
            this.ltb_nome.Location = new System.Drawing.Point(437, 96);
            this.ltb_nome.Name = "ltb_nome";
            this.ltb_nome.Size = new System.Drawing.Size(192, 377);
            this.ltb_nome.TabIndex = 32;
            this.ltb_nome.SelectedIndexChanged += new System.EventHandler(this.ltb_nome_SelectedIndexChanged);
            this.ltb_nome.DoubleClick += new System.EventHandler(this.ltb_nome_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Alatsi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(41, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 30);
            this.label5.TabIndex = 31;
            this.label5.Text = "Valor de revenda:";
            // 
            // txt_ValorRevenda
            // 
            this.txt_ValorRevenda.Location = new System.Drawing.Point(46, 254);
            this.txt_ValorRevenda.Name = "txt_ValorRevenda";
            this.txt_ValorRevenda.Size = new System.Drawing.Size(171, 20);
            this.txt_ValorRevenda.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Alatsi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Preço de custo:";
            // 
            // txt_PrecoCusto
            // 
            this.txt_PrecoCusto.Location = new System.Drawing.Point(46, 187);
            this.txt_PrecoCusto.Name = "txt_PrecoCusto";
            this.txt_PrecoCusto.Size = new System.Drawing.Size(171, 20);
            this.txt_PrecoCusto.TabIndex = 28;
            // 
            // txt_Tela
            // 
            this.txt_Tela.Location = new System.Drawing.Point(46, 469);
            this.txt_Tela.Name = "txt_Tela";
            this.txt_Tela.Size = new System.Drawing.Size(171, 20);
            this.txt_Tela.TabIndex = 27;
            this.txt_Tela.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Alatsi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Bateria:";
            this.label2.Visible = false;
            // 
            // txt_Bateria
            // 
            this.txt_Bateria.Location = new System.Drawing.Point(46, 402);
            this.txt_Bateria.Name = "txt_Bateria";
            this.txt_Bateria.Size = new System.Drawing.Size(171, 20);
            this.txt_Bateria.TabIndex = 25;
            this.txt_Bateria.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label1.Font = new System.Drawing.Font("Alatsi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 30);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome do produto:";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(46, 98);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(171, 20);
            this.txt_produto.TabIndex = 23;
            // 
            // ltb_tela
            // 
            this.ltb_tela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltb_tela.FormattingEnabled = true;
            this.ltb_tela.Location = new System.Drawing.Point(730, 96);
            this.ltb_tela.Name = "ltb_tela";
            this.ltb_tela.Size = new System.Drawing.Size(101, 377);
            this.ltb_tela.TabIndex = 22;
            this.ltb_tela.SelectedIndexChanged += new System.EventHandler(this.ltb_tela_SelectedIndexChanged);
            this.ltb_tela.DoubleClick += new System.EventHandler(this.ltb_tela_DoubleClick);
            // 
            // ltb_bateria
            // 
            this.ltb_bateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ltb_bateria.FormattingEnabled = true;
            this.ltb_bateria.Location = new System.Drawing.Point(629, 96);
            this.ltb_bateria.Name = "ltb_bateria";
            this.ltb_bateria.Size = new System.Drawing.Size(101, 377);
            this.ltb_bateria.TabIndex = 21;
            this.ltb_bateria.SelectedIndexChanged += new System.EventHandler(this.ltb_bateria_SelectedIndexChanged);
            this.ltb_bateria.DoubleClick += new System.EventHandler(this.ltb_bateria_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Alatsi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 30);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tela:";
            this.label3.Visible = false;
            // 
            // btn_especificacao
            // 
            this.btn_especificacao.FlatAppearance.BorderSize = 0;
            this.btn_especificacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_especificacao.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_especificacao.Font = new System.Drawing.Font("Alatsi", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_especificacao.ForeColor = System.Drawing.Color.White;
            this.btn_especificacao.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btn_especificacao.IconColor = System.Drawing.Color.White;
            this.btn_especificacao.IconSize = 30;
            this.btn_especificacao.Location = new System.Drawing.Point(27, 124);
            this.btn_especificacao.Name = "btn_especificacao";
            this.btn_especificacao.Rotation = 0D;
            this.btn_especificacao.Size = new System.Drawing.Size(204, 32);
            this.btn_especificacao.TabIndex = 41;
            this.btn_especificacao.Text = "  Especificação do produto";
            this.btn_especificacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_especificacao.UseVisualStyleBackColor = true;
            this.btn_especificacao.Click += new System.EventHandler(this.btn_especificacao_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label7.Font = new System.Drawing.Font("Alatsi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(438, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 30);
            this.label7.TabIndex = 42;
            this.label7.Text = "Produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label8.Font = new System.Drawing.Font("Alatsi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(624, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 30);
            this.label8.TabIndex = 43;
            this.label8.Text = "Bateria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label9.Font = new System.Drawing.Font("Alatsi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(725, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 30);
            this.label9.TabIndex = 44;
            this.label9.Text = "Tela";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label10.Font = new System.Drawing.Font("Alatsi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(824, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 30);
            this.label10.TabIndex = 45;
            this.label10.Text = "Estoque";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label11.Font = new System.Drawing.Font("Alatsi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(923, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 30);
            this.label11.TabIndex = 46;
            this.label11.Text = "Preço Custo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label12.Font = new System.Drawing.Font("Alatsi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1037, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 30);
            this.label12.TabIndex = 47;
            this.label12.Text = "Valor Revenda";
            // 
            // btn_edicao
            // 
            this.btn_edicao.FlatAppearance.BorderSize = 0;
            this.btn_edicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edicao.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_edicao.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edicao.ForeColor = System.Drawing.Color.White;
            this.btn_edicao.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_edicao.IconColor = System.Drawing.Color.White;
            this.btn_edicao.IconSize = 30;
            this.btn_edicao.Location = new System.Drawing.Point(12, 12);
            this.btn_edicao.Name = "btn_edicao";
            this.btn_edicao.Rotation = 0D;
            this.btn_edicao.Size = new System.Drawing.Size(217, 43);
            this.btn_edicao.TabIndex = 48;
            this.btn_edicao.Tag = "";
            this.btn_edicao.Text = "Sair do modo edição";
            this.btn_edicao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edicao.UseVisualStyleBackColor = true;
            this.btn_edicao.Visible = false;
            this.btn_edicao.Click += new System.EventHandler(this.btn_edicao_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(403, 540);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(101, 49);
            this.richTextBox1.TabIndex = 49;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(510, 540);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(101, 49);
            this.richTextBox2.TabIndex = 50;
            this.richTextBox2.Text = "";
            this.richTextBox2.Visible = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(617, 540);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(101, 49);
            this.richTextBox3.TabIndex = 51;
            this.richTextBox3.Text = "";
            this.richTextBox3.Visible = false;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(724, 540);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(101, 49);
            this.richTextBox4.TabIndex = 52;
            this.richTextBox4.Text = "";
            this.richTextBox4.Visible = false;
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(831, 540);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(101, 49);
            this.richTextBox5.TabIndex = 53;
            this.richTextBox5.Text = "";
            this.richTextBox5.Visible = false;
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(938, 540);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(101, 49);
            this.richTextBox6.TabIndex = 54;
            this.richTextBox6.Text = "";
            this.richTextBox6.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(437, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 32);
            this.panel1.TabIndex = 55;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1213, 603);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_edicao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_especificacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Estoque);
            this.Controls.Add(this.ltb_valorRevenda);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.ltb_precoCusto);
            this.Controls.Add(this.ltb_estoque);
            this.Controls.Add(this.ltb_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ValorRevenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_PrecoCusto);
            this.Controls.Add(this.txt_Tela);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Bateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.ltb_tela);
            this.Controls.Add(this.ltb_bateria);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Estoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.Leave += new System.EventHandler(this.Estoque_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Estoque;
        private System.Windows.Forms.ListBox ltb_valorRevenda;
        private FontAwesome.Sharp.IconButton btn_Remover;
        private FontAwesome.Sharp.IconButton btn_adicionar;
        private System.Windows.Forms.ListBox ltb_precoCusto;
        private System.Windows.Forms.ListBox ltb_estoque;
        private System.Windows.Forms.ListBox ltb_nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ValorRevenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PrecoCusto;
        private System.Windows.Forms.TextBox txt_Tela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Bateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.ListBox ltb_tela;
        private System.Windows.Forms.ListBox ltb_bateria;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btn_especificacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btn_edicao;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Panel panel1;
    }
}