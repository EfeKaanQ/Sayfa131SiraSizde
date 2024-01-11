using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayfa131SiraSizde
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string[,]takımlar=new string[4, 3] { {" kadir", "Levent"," Efe" }, { "Samed"," Ramazan", "ahmet", }, { "Selehaddin", "yeliz", "eren "}, {" ahmet","yağız","nurihoca"} };
            takımlar[0, 0] = "kadir";
            takımlar[0, 1] = "Levent";
            takımlar[0, 2] = "Efe";
            takımlar[1,0] = "Samed";
            takımlar[1, 1] = "Ramazan";
            takımlar[1, 2] = "Ahmet";
            takımlar[2, 0] = "selehaddin";
            takımlar[2, 1] = "yeliz";
            takımlar[2, 2] = "eren";
            takımlar[3, 0] = "Ahmet";
            takımlar[3, 1] = "Yağız";
            takımlar[3, 2] = "Nuri Hoca";



        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] takımlar = new string[4, 3]
{
                  { "kadir", "Levent", "Efe" },
                  { "Samed", "Ramazan", "Ahmet" },
                  { "Selehaddin", "yeliz", "eren" },
                  { "Ahmet", "Yağız", "Nuri Hoca" }
};
           ;

            for (int i = 0; i < 3; i++)
            {
                listBox1.Items.Add(takımlar[0, i]);
                listBox2.Items.Add(takımlar[1, i]);
                listBox3.Items.Add(takımlar[2, i]);
                listBox4.Items.Add(takımlar[3, i]);
            }

        }
    }
}
