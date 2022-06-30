using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadButton();
        }

        void LoadButton()
        {

        }

        int i = 0;
        void AddButton()
        {
            Button btn = new Button() { Text = i.ToString() };
            Random rand = new Random();
            btn.Location = new Point(rand.Next(0, this.Size.Width), rand.Next(0, this.Size.Height));
            btn.Click += btn_Click;

            this.Controls.Add(btn);

            i++;
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddButton();
        }
    }
}
