using System;
using System.Windows.Forms;

namespace Left_Behind_Application
{
    public partial class Funcpage : Form
    {
        public Funcpage()
        {
            InitializeComponent();
        }

        private void func_button1_Click(object sender, EventArgs e)
        {
            Associnput associnput = new Associnput();

            this.Hide();

            associnput.Show();
        }

        private void func_button2_Click(object sender, EventArgs e)
        {

        }
    }
}
