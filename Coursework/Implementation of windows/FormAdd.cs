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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void applyBtm_Click(object sender, EventArgs e)
        {
            if (NameOlympTexBox.Text.Length < 3)
            {
                MessageBox.Show("Add the Name of the Olympiad!!!");
            }
            else
            {
                this.Visible = false;
                int countTable = 0;
                int endadd = (int)countCountryNumD.Value;
                do
                {
                    endadd--;
                    countTable++;
                    FormAddCountryAgents formAddCountryAgents = new FormAddCountryAgents(countTable, NameOlympTexBox.Text);
                    formAddCountryAgents.ShowDialog();

                } while (endadd != 0);
                this.Close();
            }
        }

        private void CancelBtm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
