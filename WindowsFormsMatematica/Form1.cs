using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAprendizado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Mudou";
        }

        private void BTNResultado_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int resut = 0;


            //Aqui no TRY será colado um suposto código que dará erro, se o erro acontecer vai aparecer no CATCH.
            try
            {
                num1 = Convert.ToInt32(textBox2.Text);
                num2 = Convert.ToInt32(textBox1.Text);


            }
            catch (Exception ex)
            {

                MessageBox.Show("Favor não digitar letras PRECIOSO");
            }
            
            resut = num1 + num2;
            label5.Text = resut.ToString();
            





        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            int num3 = 0;
            int num4 = 0;
            int result = 0;


            //Aqui no TRY será colado um suposto código que dará erro, se o erro acontecer vai aparecer no CATCH.
            try
            {
                num3 = Convert.ToInt32(textBox3.Text);
                num4 = Convert.ToInt32(textBox4.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Favor não digitar letras PRECIOSO");
            }

            
            result = num3 - num4;
            label8.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num5 = 0;
            int num6 = 0;
            int result = 0;


            //Aqui no TRY será colado um suposto código que dará erro, se o erro acontecer vai aparecer no CATCH.
            try
            {
                num5 = Convert.ToInt32(textBox5.Text);
                num6 = Convert.ToInt32(textBox6.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Favor não digitar letras PRECIOSO");
            }

            
            
            //Aqui no TRY será colado um suposto código que dará erro, se o erro acontecer vai aparecer no CATCH.
            try
            {
                result = num5 / num6;
                label10.Text = result.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Não é possivel dividir por zero");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num7 = 0;
            int num8 = 0;
            int result = 0;


            //Aqui no TRY será colado um suposto código que dará erro, se o erro acontecer vai aparecer no CATCH.
            try
            {
                num7 = Convert.ToInt32(textBox7.Text);
                num8 = Convert.ToInt32(textBox8.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Não é possivel dividir por zero");
            }

           
            result = num7 * num8;
            label12.Text = result.ToString();

        }
    }
}
