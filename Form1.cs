using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oef3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<string> mijnLijst = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            mijnLijst.Add("skjsdkj");
            mijnLijst.Add("Roseline");
            mijnLijst.Add("Scott");
            mijnLijst.Add("Fulvio");
            mijnLijst.Add("Sergio");

            foreach (var item in mijnLijst)
            {
                //comboBox1.Items.Add(item);
                listBox1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in mijnLijst)
            {
                if (item.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    //comboBox1.Items.Add(item);
                    listBox1.Items.Add(item);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in mijnLijst)
            {
                if (item.ToLower().Contains(textBox1.Text.ToLower()))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
