using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebView2Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var editorInfo = string.Format("{0}{1}", tbShowNRKIllustration, tbShowNRKIllustrationFocus);

            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            wv2.Source = new Uri(tbUrl.Text);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEditorInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRun2_Click(object sender, EventArgs e)
        {
            wv2.Source = new Uri(tbKaleidoUrl.Text + tbShowNRKIllustration);
        }
    }
}
