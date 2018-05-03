using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassGen
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PassGen();
        }

        private void PassGen()
        {

            string chars = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string pass = null;


            var chars_A = chars.ToCharArray();
            for (int i = 0; i < 10; i++)
            {
                int count = random.Next(0,3);
                if(count == 0)
                {
                    pass += chars_A[random.Next(0, chars_A.Length)];
                }

                if(count == 1)
                {
                    pass += chars_A[random.Next(0, chars_A.Length)].ToString().ToLower();
                }

                if(count == 2)
                {
                    pass += random.Next(0, 9);
                }
            }
            textBox1.Text = pass;
        }

    }
}
