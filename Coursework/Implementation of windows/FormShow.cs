using Microsoft.Data.SqlClient;
using Olympiad.Services;
using Olympiad.Services.NewFolder;
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
    public partial class FormShow : Form
    {
        public FormShow()
        {
            InitializeComponent();
            InitGridView();
        }
        private void InitGridView()
        {
            List<GridViewShoww> list = ShowServices.GridViewTable();
            foreach (var item in list)
            {
                table.Rows.Add(item.NameOlympiada, item.NameCountry, item.Gold, item.Silver, item.Bronze, item.Count);
            }
        }
        private int a = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            List<GridViewShoww> list = ShowServices.GridViewTable();
            table.Rows.Clear();
            var top5 = list.OrderByDescending(t => t.Count).Take(5);
            foreach (var item in top5)
            {
                table.Rows.Add(item.NameOlympiada, item.NameCountry, item.Gold, item.Silver, item.Bronze, item.Count);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                a = 2;
                List<GridViewShoww> list = ShowServices.GridViewTable();
                table.Rows.Clear();
                var sort = list.OrderByDescending(t => t.Count);
                foreach (var item in sort)
                {
                    table.Rows.Add(item.NameOlympiada, item.NameCountry, item.Gold, item.Silver, item.Bronze, item.Count);
                }
            }
            else
            {
                a = 1;
                List<GridViewShoww> list = ShowServices.GridViewTable();
                table.Rows.Clear();
                var sort = list.OrderBy(t => t.Count).AsQueryable();
                foreach (var item in sort)
                {
                    table.Rows.Add(item.NameOlympiada, item.NameCountry, item.Gold, item.Silver, item.Bronze, item.Count);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormShowPlayer formShowPlayer = new FormShowPlayer();
            this.Visible = false;
            if (formShowPlayer.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }
    }
}
