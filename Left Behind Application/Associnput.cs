using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Left_Behind_Application
{
    public partial class Associnput : Form
    {
        Funcpage funcpage = new Funcpage();
        ItemEntry itemEntry = new ItemEntry();

        public Associnput()
        {
            InitializeComponent();
        }

        private void entry_back_button_Click_1(object sender, EventArgs e)
        {

            this.Close();

            funcpage.Show();

        }

        private void entry_enter_button_Click_1(object sender, EventArgs e)
        {
            string regInput = entry_reg_textBox.Text;
            string associnput = entry_oper_textBox.Text;

            if(string.IsNullOrEmpty(entry_reg_textBox.Text) || string.IsNullOrEmpty(entry_oper_textBox.Text))
            {
                MessageBox.Show("Please enter the associate and register #");
                this.Show();
            }
            else
            {
                itemEntry.UpdateRegValue(regInput);
                itemEntry.UpdateAssociateValue(associnput);
                this.Close();
                itemEntry.Show();
            }
            
        }
    }
}
