using Coursework.Cmd.Implementation_of_windows;
using Olympiad.Data.Data;
using Olympiad.Data.Data.Models;
using Olympiad.Services;

namespace Coursework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void AddOlypBtm_Click(object sender, EventArgs e)
        {
            AddForm formAdd = new AddForm();
            this.Visible = false;
            if (formAdd.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
            else
            {
                this.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            FormShow formShow = new FormShow();
            if (formShow.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }
    }
}