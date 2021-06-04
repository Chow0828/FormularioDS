using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
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

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox10.Text);
            string nome = textBox9.Text;
            int rg = Convert.ToInt32(textBox8.Text);
            int cpf = Convert.ToInt32(textBox7.Text); 
            int tel = Convert.ToInt32(textBox6.Text);
            bool sexoM = radioButton4.Checked;
            bool sexoF = radioButton3.Checked;
            int cep = Convert.ToInt32(textBox1.Text);
            int numeroCasa = Convert.ToInt32(textBox3.Text);
            string logradouro = textBox2.Text;
            string bairro = textBox4.Text;
            string cidade = textBox5.Text;
            string email = textBox11.Text;
            string facebook = textBox12.Text;
            string twitter = textBox13.Text;

            
            if (sexoM == true)
            {
               MessageBox.Show("Masculino");            
            }
            else
            {
                MessageBox.Show("Feminino");
            }

            MessageBox.Show("Codigo: "+codigo+"\r\nNome: "+nome+"\r\nRG: "+rg+ "\r\nCPF: "+cpf+
                "\r\nTEL: "+tel+ "\r\nSexo M: "+sexoM+ "\r\nSexo F: "+sexoF+"\r\nCEP: " +cep+ "\r\nNumero: "+numeroCasa+
                "\r\nLogradouro: "+logradouro+ "\r\nBairro: "+bairro+ "\r\nCidade: "+cidade+ "\r\nEmail: "+email+
                "\r\nFacebook: "+facebook+ "\r\nTwitter: "+twitter+ "\r\n");

            /*if (sexoM == true)
            {
                MessageBox.Show("Masculino");
            }
            else
            {
                MessageBox.Show("Feminino");
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = file.FileName;
            }
        }

        private void limparTextBox(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = null;
                }
            }

            foreach (Control ctrl in controles)
            {
                if (ctrl is CheckBox)
                {
                    ((CheckBox)(ctrl)).Checked = false;
                }
            }

            foreach (Control ctrl in controles)
            {
                if (ctrl is PictureBox)
                {
                    ((PictureBox)(ctrl)).Image = null;
                }
            }

            foreach (Control ctrl in controles)
            {
                if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)(ctrl)).Text = null;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            limparTextBox(groupBox1.Controls);
            limparTextBox(groupBox2.Controls);
            limparTextBox(groupBox3.Controls);
            limparTextBox(pictureBox1.Controls);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox10.Text);
            string nome = textBox9.Text;
            int rg = Convert.ToInt32(textBox8.Text);
            int cpf = Convert.ToInt32(textBox7.Text);
            int tel = Convert.ToInt32(textBox6.Text);
            bool sexoM = radioButton4.Checked;
            bool sexoF = radioButton3.Checked;
            int cep = Convert.ToInt32(textBox1.Text);
            int numeroCasa = Convert.ToInt32(textBox3.Text);
            string logradouro = textBox2.Text;
            string bairro = textBox4.Text;
            string cidade = textBox5.Text;
            string email = textBox11.Text;
            string facebook = textBox12.Text;
            string twitter = textBox13.Text;

            textBox9.Text = "Andrey Moura";
            textBox10.Text = "007";
            // this.data.Text = "03/08/2000";
            textBox8.Text = "1327504800";
            textBox7.Text = "537961048";
            textBox6.Text = "981834795";

            radioButton4.Checked = true;

            textBox2.Text = "Rua Bernadino Silva";
            textBox3.Text = "879";
            textBox4.Text = "Liberdade";
            textBox5.Text = "São Paulo";
            textBox1.Text = "11999666";

            textBox11.Text = "andreygouveia.05@gmail.com";
            textBox12.Text = "andreymouragouvea";
            textBox13.Text = "@andreymoura5";
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
        }
    }
}
