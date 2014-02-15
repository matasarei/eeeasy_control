using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace EeeasyControl
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            AboutText.Text = "Eeeasy Control 1.1\nEugene Matasar\nmatasar.ei@gmail.com\nDesigned for EeePC T101";
        }

        private void About_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutText_Click(object sender, EventArgs e)
        {
            Process.Start("https://plus.google.com/115888794829282114753/posts");
        }
    }
}
