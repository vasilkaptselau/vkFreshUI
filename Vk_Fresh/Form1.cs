using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vk_Fresh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var newButton = new Bunifu.Framework.UI.BunifuFlatButton();

            this.Controls.Add(newButton);
        }

        private void btn1_OnClick(object sender, EventArgs e)
        {
            btn1.selected = false;
            btn2.selected = false;
            btn3.selected = false;
            btn4.selected = false;
            btn5.selected = false;

            
            //((this.bunifuFlatButton1)sender).selected  = true;

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }
        private void Btnclose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
