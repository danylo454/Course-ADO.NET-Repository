using Olympiad.Data.Data.Models;
using Olympiad.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework.Cmd.Implementation_of_windows
{
    public partial class FormAddPeople : Form
    {
        static Random random = new Random();
        int countPlayer = 0;
        private string nameCountryInit = null;
        private string NameOlimpiada = null;
        public FormAddPeople(decimal count,string nameCounty,string NameOlimpiada)
        {
            InitializeComponent();
            CountryTexb.Text = nameCounty;
            this.nameCountryInit = nameCounty;
            this.NameOlimpiada = NameOlimpiada;
            countPlayer = (int)count;
            InitLabel();
            foreach (var item in this.Controls.OfType<TextBox>())
            {
                    item.Text = null;
                    item.BackColor = Color.IndianRed;
            }
            dateTextBox1.BackColor = Color.IndianRed;
            CountryTexb.Text = nameCounty;
            CountryTexb.BackColor = Color.White;
        }
        public void InitLabel()
        {
            labelPlayer.Text = $"Player: {countPlayer}";
        }
        private void nameTexb_TextChanged(object sender, EventArgs e)
        {
            if (nameTexb.Text.Length > 3)
            {
                nameTexb.BackColor = Color.White;
            }
            else
            {
                nameTexb.BackColor = Color.IndianRed;
            }
        }
        private void surnameTexB_TextChanged(object sender, EventArgs e)
        {
            if (surnameTexB.Text.Length > 3)
            {
                surnameTexB.BackColor = Color.White;
            }
            else
            {
                surnameTexB.BackColor = Color.IndianRed;
            }
        }
        private void midllenameTexB_TextChanged(object sender, EventArgs e)
        {
            if (midllenameTexB.Text.Length > 3)
            {
                midllenameTexB.BackColor = Color.White;
            }
            else
            {
                midllenameTexB.BackColor = Color.IndianRed;
            }
        }
        private void dateTextBox1_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(0?[1-9]|[12]\d|3[01])\.(0?[1-9]|1[0-2])\.(19|20)\d{2}$");
            if (regex.IsMatch(dateTextBox1.Text) == true)
            {
                dateTextBox1.BackColor = Color.White;
            }
            else
            {
                dateTextBox1.BackColor = Color.IndianRed;

            }
        }
        private void AddInDataBase()
        {
            Player player = new Player()
            {
                Name = nameTexb.Text,
                Surname = surnameTexB.Text,
                MiddleName = surnameTexB.Text,
                Country = CountryTexb.Text,
                DateBirth = DateTime.Parse(dateTextBox1.Text)
            };
            PlayerService.AddPlayer(player);
            CountryAgent countryAgent = new CountryAgent()
            {
                Name = nameCountryInit,
                IdPlayerAgent = PlayerService.GetUSer(player.Name,player.Surname,player.MiddleName)
            };
            CountryServices.AddCountry(countryAgent);
            int idPlayer = PlayerService.GetUSer(player.Name, player.Surname, player.MiddleName);
            int idCountry = CountryServices.GetIdByAddTableWithPlayer(idPlayer, countryAgent.Name);
            OlympiadaTable table = new OlympiadaTable()
            {
                IdCountryAgent = idCountry,
                Gold = random.Next(1,50),
                Silver = random.Next(1,50),
                Bronze = random.Next(1,50)
            };
            TableOlympiadaService.AddTableOlympiada(table);
            int idTableOlimp = TableOlympiadaService.GetIdTable(idCountry);
            Olympiada olympiada1 = new Olympiada()
            {
                IdTableOlypida = idTableOlimp,
                NameOlypiada = this.NameOlimpiada
            };
            OlympiadaService.AddOlympiada(olympiada1);
        }
        private void ApplyBtm_Click(object sender, EventArgs e)
        {
            if (nameTexb.BackColor != Color.IndianRed &&
                surnameTexB.BackColor != Color.IndianRed &&
                midllenameTexB.BackColor != Color.IndianRed &&
                dateTextBox1.BackColor != Color.IndianRed)
            {
                AddInDataBase();
                this.Close();
            }
            else
            {
                ApplyBtm.BackColor = Color.IndianRed;
                ApplyBtm.Update();
                Thread.Sleep(500);
                ApplyBtm.BackColor = Color.White;

            }
        }
    }
}
