using Olympiad.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework.Cmd.Implementation_of_windows
{
    public partial class FormShowPlayer : Form
    {
        public FormShowPlayer()
        {
            InitializeComponent();
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                item.TextChanged += InitGridView;
            }
            var list = ShowServices.GridViewPlayers();
            foreach (var item in list)
            {
                dataGridView1.Rows.Add(item.Name, item.Surname, item.MidleName, item.DateBirth, item.Country);
            }
        }
        private void InitGridView(object sender, EventArgs e)
        {
            var list = ShowServices.GridViewPlayers();
            var like = from l in list
                       where l.Name.ToLower().StartsWith(textBox1.Text.ToLower()) &&
                       l.Surname.ToLower().StartsWith(textBox2.Text.ToLower()) &&
                       l.MidleName.ToLower().StartsWith(textBox3.Text.ToLower()) &&
                       l.Country.ToLower().StartsWith(textBox4.Text.ToLower())
                       select l;
            dataGridView1.Rows.Clear();
            foreach (var item in like)
            {
                dataGridView1.Rows.Add(item.Name, item.Surname, item.MidleName, item.DateBirth, item.Country);
            }
                       

            
        }
    }
}
