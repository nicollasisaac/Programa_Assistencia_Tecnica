using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Assistencia_Tecnica
{
    public partial class Form1 : Form
    {
        int x, y;
        Point Point = new Point();
        public Form1()
        {
            InitializeComponent();
        }
        private void AbrirNovoForm(object AbrirForm)
        {
            if (this.panel_troca.Controls.Count > 0)
                this.panel_troca.Controls.RemoveAt(0);
            Form t2 = AbrirForm as Form;
            t2.TopLevel = false;
            t2.Dock = DockStyle.Fill;
            this.panel_troca.Controls.Add(t2);
            this.panel_troca.Tag = t2;
            t2.Show();
        }
        private void iconButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void DesativarBotao()
        {
            iconButton1.ForeColor = Color.White;
            iconButton2.ForeColor = Color.White;
            iconButton3.ForeColor = Color.White;
            iconButton4.ForeColor = Color.White;

            iconButton1.IconColor = Color.White;
            iconButton2.IconColor = Color.White;
            iconButton3.IconColor = Color.White;
            iconButton4.IconColor = Color.White;

            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;

            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }
        private void iconButton7_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton6_MouseMove(object sender, MouseEventArgs e)
        {
            iconButton6.BackColor = Color.Red;
        }

        private void panel_superior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
                Application.DoEvents();
            }
        }

        private void panel_superior_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AbrirNovoForm(new Caixa());
            DesativarBotao();
            iconButton1.IconColor = Color.FromArgb(83, 83, 83);
            iconButton1.ForeColor = Color.FromArgb(83, 83, 83);
            iconButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            label1.Text = "Caixa";
            panel1.Visible = true;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AbrirNovoForm(new Estoque());
            DesativarBotao();
            iconButton2.IconColor = Color.FromArgb(83, 83, 83);
            iconButton2.ForeColor = Color.FromArgb(83, 83, 83);
            iconButton2.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            label1.Text = "Estoque";
            panel2.Visible = true;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            DesativarBotao();
            iconButton3.IconColor = Color.FromArgb(83, 83, 83);
            iconButton3.ForeColor = Color.FromArgb(83, 83, 83);
            iconButton3.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            label1.Text = "Estatísticas";
            panel3.Visible = true;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            DesativarBotao();
            iconButton4.IconColor = Color.FromArgb(83, 83, 83);
            iconButton4.ForeColor = Color.FromArgb(83, 83, 83);
            iconButton4.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            label1.Text = "Ferramentas";
            panel4.Visible = true;
        }

        private void iconButton6_MouseLeave(object sender, EventArgs e)
        {
            iconButton6.BackColor = Color.Transparent;
        }
    }
}
