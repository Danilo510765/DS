namespace ahh_um_projeto_aii
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3;

            lado1 = double.Parse(txtlado1.Text);
            lado2 = double.Parse(txtlado2.Text);
            lado3 = double.Parse(txtlado3.Text);

            string textomensagem = "triangulo Isóceles";

            if (lado1 <= 0 || lado2 <= 0 || lado3 <= 0 || lado1 + lado2 <= lado3
              || lado1 + lado3 <= lado2 || lado3 + lado2 <= lado1)
            {
                textomensagem = "não é um triangulo";
            }
            else if (lado1 == lado2 && lado2 == lado3)
            {
                textomensagem = "Triangulo Equilatero";
            }
            else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                textomensagem = "triangulo ecaleno";
            }
            lblresultado.Text = textomensagem;

        }
    }
}