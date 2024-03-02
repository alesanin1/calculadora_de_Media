using System.Drawing;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //calcular
        {
            float soma, media, valor;
            soma = 0;
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                    soma += valor;
                }
                media = soma / 4;
                this.Controls["label7"].Text = media.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e) //resetar
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }
                this.Controls["label7"].Text = "...";
            }
        }

        
    }


}

