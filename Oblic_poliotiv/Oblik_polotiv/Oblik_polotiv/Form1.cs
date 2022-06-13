using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Oblik_polotiv
{
    public partial class Form1 : Form
    {
        static List<string> searched = new List<string>();
        BindingSource searchedBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            this.Text = "FlightNow";

            SearchFilter.Items.Add("Country");
            SearchFilter.Items.Add("City");
            SearchFilter.Items.Add("Airport");
            
            SearchFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            SearchFilter.Text = SearchFilter.Items[0].ToString();

            

            ClassBox.Items.Add("First");
            ClassBox.Items.Add("Business");
            ClassBox.Items.Add("Economy");

            ClassBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassBox.Text = ClassBox.Items[0].ToString();

            DepartBox.Text = DateTime.Now.ToString("MM/dd/yyyy");

            ReturnBox.Text = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");

        }

        internal void receiveSearched(string text)
        {
            searched.Insert(0, text);
        }       

        private void SearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SearchFilter.SelectedIndex == 0)
            {
                FromBox.Text = "Ukraine";
                ToBox.Text = "Poland";
            }
            else if(SearchFilter.SelectedIndex == 1)
            {
                FromBox.Text = "Kyiv";
                ToBox.Text = "Lviv";
            }
            else
            {
                FromBox.Text = "Boryspil International Airport";
                ToBox.Text = "Lviv Danylo Halytskyi International Airport";
            }
        }

        private void SearchFlightsBtn_Click(object sender, EventArgs e)
        {
            DateTime dt;
            if (string.IsNullOrEmpty(FromBox.Text.Trim()))
                FromBoxErrorProvider.SetError(FromBox, "Enter correct " + SearchFilter.Text);
            else if (string.IsNullOrEmpty(ToBox.Text.Trim()))
                ToBoxErrorProvider.SetError(ToBox, "Enter correct " + SearchFilter.Text);
            else if (!DateTime.TryParse(DepartBox.Text, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt) 
                || Convert.ToDateTime(DepartBox.Text).Year < DateTime.Now.Year)
                DepartBoxErrorProvider.SetError(DepartBox, "Enter valid date \"MM/dd/yyyy\"");
            else if (!DateTime.TryParse(ReturnBox.Text, CultureInfo.InvariantCulture, DateTimeStyles.None, out dt) 
                || Convert.ToDateTime(ReturnBox.Text).Year < DateTime.Now.Year)
                ReturnBoxErrorProvider.SetError(ReturnBox, "Enter valid date \"MM/dd/yyyy\"");
            else
            {
                if (ResentlyWatchedLst.Items.Count > 7)
                    ResentlyWatchedLst.Items.RemoveAt(7);
                
                int search_Count = Search().Count;
                if (search_Count == 0)
                    MessageBox.Show("No flights found!");
                else
                {
                    frmSearchResults.Visible = true;
                    btnfSearchResBack.Visible = true;
                    btnfSearchResBack.BringToFront();
                    frmSearchResults.printResults(Search());
                }
            }
            if (DateTime.TryParse(ReturnBox.Text, out dt) && Convert.ToDateTime(ReturnBox.Text).Year > DateTime.Now.Year)
                ReturnBoxErrorProvider.Clear();
            if (DateTime.TryParse(DepartBox.Text, out dt) && Convert.ToDateTime(DepartBox.Text).Year > DateTime.Now.Year)
                DepartBoxErrorProvider.Clear();
        }
        private string Validate_Input(string input)
        {
            string valid = "";
            for(int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]) || (i > 0 && i < input.Length-1 && Char.IsWhiteSpace(input[i]) && !Char.IsWhiteSpace(input[i-1])))
                    valid += input[i];
            }
            return valid.Trim();
        }
        private List<Flight> Search()
        {
            List<Flight> res = new List<Flight>();
            Flight fl_Kyiv_Lviv = new Flight("Ukraine", "Kyiv", "Boryspil International Airport", "Ukraine",
                "Lviv", "Lviv Danylo Halytskyi International Airport", 
                DateTime.Parse("10/11/2022 12:00", CultureInfo.InvariantCulture), 
                DateTime.Parse("11/11/2022 13:30", CultureInfo.InvariantCulture), "UkrAir", ClassBox.Text, 200);
            Flight fl_Kyiv_Odesa = new Flight("Ukraine", "Kyiv", "Boryspil International Airport", "Ukraine",
                "Odesa", "Odesa International Airport", 
                DateTime.Parse("12/10/2022 5:50", CultureInfo.InvariantCulture), 
                DateTime.Parse("12/10/2022 6:55", CultureInfo.InvariantCulture), "UkrAir", ClassBox.Text, 120);
            Flight fl_London_Kyiv = new Flight("United Kingdom", "London", "London City Airport", "Ukraine",
               "Kyiv", "Boryspil International Airport", 
               DateTime.Parse("12/10/2022 0:10", CultureInfo.InvariantCulture), 
               DateTime.Parse("12/10/2022 2:45", CultureInfo.InvariantCulture), "British Trans", ClassBox.Text, 345);
            Flight fl_Lviv_Warsaw = new Flight("Ukraine", "Lviv", "Lviv Danylo Halytskyi International Airport", 
               "Poland", "Warsaw", "Warsaw Chopin Airport",
               DateTime.Parse("12/10/2022 0:10", CultureInfo.InvariantCulture),
               DateTime.Parse("12/10/2022 2:45", CultureInfo.InvariantCulture), "Polskie Linie Lotnicze", ClassBox.Text, 409);
            res.Add(fl_Kyiv_Lviv);
            res.Add(fl_Kyiv_Odesa);
            res.Add(fl_London_Kyiv);
            res.Add(fl_Lviv_Warsaw);
            for(int i = 0; i < res.Count; i++)
            {
                Flight fl = res[i];
                switch (SearchFilter.Text) {
                    case "Country":
                        if (fl.from_Country != FromBox.Text || fl.to_Country != ToBox.Text)
                        {
                            res.Remove(fl);
                            i--;
                        }
                        break;
                    case "City":
                        if (fl.from_City != FromBox.Text || fl.to_City != ToBox.Text)
                        {
                            res.Remove(fl);
                            i--;
                        }
                        break;
                    case "Airport":
                        if (fl.from_Airport != FromBox.Text || fl.to_Airport != ToBox.Text)
                        {
                            res.Remove(fl);
                            i--;
                        }
                        break;
                }
            }                            
            return res;
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            searchedBindingSource.DataSource = searched;

            ResentlyWatchedLst.DataSource = searchedBindingSource;
        }   
        
        private void ResentlyWatchedLst_DoubleClick(object sender, EventArgs e)
        {
            if(ResentlyWatchedLst.SelectedItems.Count > 0)
                MessageBox.Show(ResentlyWatchedLst.SelectedItems[0].ToString());
        }
        private void btnfSearchResBack_Click(object sender, EventArgs e)
        {
            frmSearchResults.ClearList();
            frmSearchResults.Visible = false;
            btnfSearchResBack.Visible = false;
            frmSearchResults.frmFlightDetails.Visible = false;
            searchedBindingSource.ResetBindings(false);
        }
    }
}
