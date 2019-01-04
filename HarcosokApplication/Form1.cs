using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarcosokApplication
{
    public partial class Form1 : Form
    {
        private Adatbazis adatok = new Adatbazis();

        public Form1()
        {
            InitializeComponent();
            this.adatok.tablakLetrehozas();
            this.adatok.tesztAdatok();
            this.adatokUjraToltes();
        }

        private void harcosBtn_Click(object sender, EventArgs e)
        {
            string harcosNeve = HarcosNeveTextBox.Text;
            this.adatok.harcosLetrehozasa(harcosNeve);
            adatokUjraToltes();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int kepessegId = ((KeyValuePair<int, string>)kepessegekListBox.SelectedItem).Key;
            int sikerult = adatok.torles(kepessegId);
            
            adatokUjraToltes();
            
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            string leiras = keppesegLeirasTextBox.Text;
            int id = ((KeyValuePair<int, string>)kepessegekListBox.SelectedItem).Key;
            int sikerult = adatok.modosit(id, leiras);
            if (sikerult > 0)
            {
                MessageBox.Show("Sikerült a Módosítás!");
            }
            else
            {
                MessageBox.Show("Nem sikerült a Módosítás!");
            }
            adatokUjraToltes();
        }

        private void kepessegAddBtn_Click(object sender, EventArgs e)
        {
            string kepessegNev = kepessegNeveTextBox.Text;
            string kepessegLeiras = leirasTextBox.Text;
            int harcosId = ((KeyValuePair<int, string>)hasznaloComboBox.SelectedItem).Key;
            adatok.kepessegHozzaadas(kepessegNev, kepessegLeiras, harcosId);
        }

        private void HosListBoxChange(object sender, EventArgs e)
        {
            kepessegekListBoxBetolt();
        }

        private void kepessegListBoxChange(object sender, EventArgs e)
        {
            leirasBetolt();
        }

        private void HarcosokComboBoxBetolt()
        {
            //https://stackoverflow.com/questions/3063320/combobox-adding-text-and-value-to-an-item-no-binding-source
            Dictionary<int, string> hosnevek = adatok.selectHarcosokComboBox();
            hasznaloComboBox.DataSource = new BindingSource(hosnevek, null);
            hasznaloComboBox.DisplayMember = "Value";
            hasznaloComboBox.ValueMember = "Key";          
        }

        private void HarcosokListBoxBetolt()
        {
            Dictionary<int, string> hosnevek = adatok.selectHarcosokListBox();
            harcosokListBox.DataSource = new BindingSource(hosnevek, null);
            harcosokListBox.DisplayMember = "Value";
            harcosokListBox.ValueMember = "Key";
        }

        private void kepessegekListBoxBetolt()
        {
            int harcosId = ((KeyValuePair<int, string>)harcosokListBox.SelectedItem).Key;
            Dictionary<int, string> kepessegNev = adatok.selectKepessegListBox(harcosId);
            kepessegekListBox.DataSource = new BindingSource(kepessegNev, null);
            kepessegekListBox.DisplayMember = "Value";
            kepessegekListBox.ValueMember = "Key";
        }

        private void leirasBetolt()
        {
            KeyValuePair<int, string> kepessegSelected = (KeyValuePair<int, string>)kepessegekListBox.SelectedItem;
            int id = kepessegSelected.Key;
            if (id != 0)
            {                
                string leiras = adatok.kepessegLeiras(id);
                keppesegLeirasTextBox.Text = leiras;
            }
            else
            {
                keppesegLeirasTextBox.Text = "Nincs képessége!!";
            }
        }
        

        private void adatokUjraToltes()
        {
            HarcosokComboBoxBetolt();
            HarcosokListBoxBetolt();
            kepessegekListBoxBetolt();
            leirasBetolt();
        }

        
    }
}
