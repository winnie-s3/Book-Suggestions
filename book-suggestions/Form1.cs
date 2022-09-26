using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_suggestions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Text == "Livro 3 - Suspense (capa)")
            {
                pictureBox5.Image = Properties.Resources.a_mulher_na_janela;
                pictureBox2.Image = null;
                pictureBox4.Image = null;
                pictureBox3.Image = null;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                pictureBox1.BringToFront();
            }
            else if (listBox1.SelectedIndex == 1)
            {
                label10.BringToFront();
            }
            else if (listBox1.SelectedIndex == 2)
            {
                label15.BringToFront();
            }


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = null;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = Properties.Resources.a_ultima_festa;
                checkBox1.Text = "Livro 1 - Suspense (título/autor)";
                checkBox2.Text = "Livro 2 - Suspense (título/autor)";
                checkBox3.Text = "Livro 3 - Suspense (título/autor)";
                checkBox4.Text = "Livro 4 - Suspense (título/autor)";
                radioButton1.Text = "Livro 1 - Suspense (capa)";
                radioButton2.Text = "Livro 2 - Suspense (capa)";
                radioButton3.Text = "Livro 3 - Suspense (capa)";
                radioButton4.Text = "Livro 4 - Suspense (capa)";
                label10.Text = "Lucy Foley é uma autora britânica de romances contemporâneos, de ficção histórica e de mistério. Seus romances The Paris Apartment e The Guest List são best-sellers do New York Times.";
                label15.Text = "Em uma propriedade muito afastada na Escócia, amigos se reúnem para celebrar a chegada de um novo ano. A MAIS BONITA DA TURMA, O CASAL PERFEITO, O TEMPERAMENTAL, OS NOVOS PAIS, A RESERVADA, O AMBICIOSO, A RECÉM-CHEGADA E nenhum deles tem ideia de que ao fim da festa haverá UMA VÍTIMA E UM ASSASSINO. ";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = Properties.Resources.amor_e_gelato;
                checkBox1.Text = "Livro 1 - Romance (título/autor)";
                checkBox2.Text = "Livro 2 - Romance (título/autor)";
                checkBox3.Text = "Livro 3 - Romance (título/autor)";
                checkBox4.Text = "Livro 4 - Romance (título/autor)";
                radioButton1.Text = "Livro 1 - Romance (capa)";
                radioButton2.Text = "Livro 2 - Romance (capa)";
                radioButton3.Text = "Livro 3 - Romance (capa)";
                radioButton4.Text = "Livro 4 - Romance (capa)";
                label10.Text = "Jenna Evans Welch nasceu nos Estados Unidos, mas passou parte da adolescência na Itália. Ela entrou para a lista do mais vendidos do The New York Times e se tornou uma best-seller com um livro emocionante, que fala de perda, amor e autoconhecimento.";
                label15.Text = "Uma trajetória que fará Lina descobrir o amor, a si mesma e também aprender a lidar com a perda. Amor & gelato é uma deliciosa viagem pelos mais românticos pontos turísticos italianos, com direito a tudo de mais intenso que o lugar tem a oferecer: desde paixões até corações partidos.";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1.Image = Properties.Resources.amor_e_gelato;
                checkBox1.Text = "Livro 1 - Romance (título/autor)";
                checkBox2.Text = "Livro 2 - Romance (título/autor)";
                checkBox3.Text = "Livro 3 - Romance (título/autor)";
                checkBox4.Text = "Livro 4 - Romance (título/autor)";
                radioButton1.Text = "Livro 1 - Romance (capa)";
                radioButton2.Text = "Livro 2 - Romance (capa)";
                radioButton3.Text = "Livro 3 - Romance (capa)";
                radioButton4.Text = "Livro 4 - Romance (capa)";
                label10.Text = "Jenna Evans Welch nasceu nos Estados Unidos, mas passou parte da adolescência na Itália. Ela entrou para a lista do mais vendidos do The New York Times e se tornou uma best-seller com um livro emocionante, que fala de perda, amor e autoconhecimento.";
                label15.Text = "Uma trajetória que fará Lina descobrir o amor, a si mesma e também aprender a lidar com a perda. Amor & gelato é uma deliciosa viagem pelos mais românticos pontos turísticos italianos, com direito a tudo de mais intenso que o lugar tem a oferecer: desde paixões até corações partidos.";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                label6.Text = "";
                label7.Text = "";
            }
            else if (checkBox1.Text == "Livro 1 - Suspense (título/autor)")
            {
                label6.Text = "A corrente";
                label7.Text = "Adrian Mckinty";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                label9.Text = "";
                label8.Text = "";
            }
            else if (checkBox2.Text == "Livro 2 - Suspense (título/autor)")
            {
                label9.Text = "Charlie Donlea";
                label8.Text = "A Garota do Lago";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Text == "Livro 1 - Suspense (capa)")
            {
                pictureBox2.Image = Properties.Resources.a_corrente;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                label14.Text = "";
                label13.Text = "";
            }
            else if (checkBox3.Text == "Livro 3 - Suspense (título/autor)")
            {
                label14.Text = "A Mulher na Janela";
                label13.Text = "A. J. Finn";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                label12.Text = "";
                label11.Text = "";
            }
            else if (checkBox4.Text == "Livro 4 - Suspense (título/autor)")
            {
                label12.Text = "A Paciente Silenciosa";
                label11.Text = "Alex Michaelides";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Text == "Livro 2 - Suspense (capa)")
            {
                pictureBox3.Image = Properties.Resources.a_garota_do_lago;
                pictureBox2.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
            }
            }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Text == "Livro 4 - Suspense (capa)")
            {
                pictureBox4.Image = Properties.Resources.a_paciente_silenciosa;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox5.Image = null;
            }
        }
    }

     //   private void radioButton4_CheckedChanged(object sender, EventArgs e)
      //  {
           //if (radioButton4.Text == "Livro 4 - Suspense (capa)")
           // {
           //     pictureBox4.Image = Properties.Resources.a_paciente_silenciosa;
           // }
      //  }
  //  }
}
