using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_zad_2_w62952
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(listBox1.SelectedItem=="Harry Potter")
            {
                listBox2.Visible = true;
                listBox2.Items.Clear();
                listBox2.Items.Add("Harry Potter i kamień filozoficzny");
                listBox2.Items.Add("Harry Potter i komnata tajemnic");
                listBox2.Items.Add("Harry Potter i więzień Azkabanu");
                listBox2.Items.Add("Harry Potter i Czara Ognia");
                listBox2.Items.Add("Harry Potter i Zakon Feniksa");
                listBox2.Items.Add("Harry Potter i Książę Półkrwi");
                listBox2.Items.Add("Harry Potter i Insygnia Śmierci");
            }
            if (listBox1.SelectedItem == "Hobbit")
            {
                listBox2.Visible = true;
                listBox2.Items.Clear();
                listBox2.Items.Add("Niezwykła podróż");
                listBox2.Items.Add("Pustkowie Smauga");
                listBox2.Items.Add("Bitwa Pięciu Armii");
            }
            if (listBox1.SelectedItem == "Władca Pierścieni")
            {
                listBox2.Visible = true;
                listBox2.Items.Clear();
                listBox2.Items.Add("Drużyna Pierścienia");
                listBox2.Items.Add("Dwie Wieże");
                listBox2.Items.Add("Powrót Króla");
            }
            if (listBox1.SelectedItem == "Saga Zmierzch")
            {
                listBox2.Visible = true;
                listBox2.Items.Clear();
                listBox2.Items.Add("Zmierzch");
                listBox2.Items.Add("Księżyc w nowiu");
                listBox2.Items.Add("Zaćmienie");
                listBox2.Items.Add("Przed świtem");
                listBox2.Items.Add("Drugie życie Bree Tanner");
            }
            if (listBox1.SelectedItem == "Harry Potter")
            {
                textBox1.Text = "Wybrałeś serię: Harry Potter";
            }
            if (listBox1.SelectedItem == "Władca Pierścieni")
            {
                textBox1.Text = "Wybrałeś serię: Władca Pierścieni";
            }
            if (listBox1.SelectedItem == "Hobbit")
            {
                textBox1.Text = "Wybrałeś serię: Hobbit";
            }
            if (listBox1.SelectedItem == "Saga Zmierzch")
            {
                textBox1.Text = "Wybrałeś serię: Saga Zmierzch";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {


            //textBox2.Text = "";
            //textBox3.Text = "";
            //textBox4.Text = "";
            //textBox5.Text = "";
            //textBox6.Text = "";
            //textBox6.Text = "";
            //textBox2.Text = Convert.ToString(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Rezerwacja przebiegła pomyślnie, dziękujemy i zapraszamy ponownie :)", "Komunikat");
                this.Close();
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.Text = "Wolna";

            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                //---------------------
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
            }
        }
    }
}
