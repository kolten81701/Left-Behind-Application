using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Left_Behind_Application
{
    public partial class ItemEntry : Form
    {
        public ItemEntry()
        {
            InitializeComponent();
        }

        private void ItemEntry_Load(object sender, EventArgs e)
        {

        }
        public void UpdateAssociateValue(string value)
        {
            associateVal_label.Text = value;
        }
        public void UpdateRegValue(string value)
        {
            registerVal_label.Text = value;
        }

        private void enterItem_button_Click(object sender, EventArgs e)
        {
            string connstr = "datasource=localhost;port=3306;username=root;password=testPass123";

            string datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


            int quantity = int.Parse(quant_textBox.Text);

            string query = "INSERT INTO walmartdb.leftbehind(date, register, associate, upc, quantity) VALUES (@Date, @Register, @Associate, @UPC, @Quantity)";

            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Date", datetime);
                    command.Parameters.AddWithValue("@Register", registerVal_label.Text);
                    command.Parameters.AddWithValue("@Associate", associateVal_label.Text);
                    command.Parameters.AddWithValue("@UPC", enterUPC_textBox.Text);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
