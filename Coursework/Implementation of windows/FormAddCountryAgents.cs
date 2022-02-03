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
    public partial class FormAddCountryAgents : Form
    {
        private int countTable = 0;
        private readonly string? nameOlympiada = null;
        public FormAddCountryAgents(int countCountry, string nameCountry)
        {
            InitializeComponent();
            this.countTable = countCountry;
            this.nameOlympiada = nameCountry;
            this.Text = $"Country namber: {countCountry}";
        }
        public static bool ISEndAdd()
        {
            return true;
        }

        private void ApplyBtm_Click(object sender, EventArgs e)
        {
            if (nameCountryTxb.Text.Length > 3)
            {
                this.Visible = false;
                int a = 0;
                int countpeople = (int)countPeopleNumD.Value;
                do
                {
                    countpeople--;
                    a++;
                    FormAddPeople formAddPeople = new FormAddPeople(a, nameCountryTxb.Text, nameOlympiada);
                    formAddPeople.ShowDialog();
                } while (countpeople != 0);
            }
        }
    }
}
