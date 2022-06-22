using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;

namespace Oblik_polotiv
{
    public partial class Form1 : Form
    {
        static List<Flight> searched = new List<Flight>();
        BindingSource searchedBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            Text = "FlightNow";

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

            DepartBox.Text = "10.11.2022";
        }

        internal void receiveSearched(Flight flight)
        {
            searched.Insert(0, flight);
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
        public List<Flight> Search()
        {
            FlightsReader flightsReader = new FlightsReader(ClassBox.Text);
            List<Flight> res = flightsReader.flights;            
            for(int i = 0; i < res.Count; i++)
            {
                Flight fl = res[i];
                switch (SearchFilter.Text) {
                    case "Country":
                        if (fl.direction.from_Country != Validate_Input(FromBox.Text) || fl.direction.to_Country != Validate_Input(ToBox.Text))
                        {
                            res.Remove(fl);
                            i--;
                        }
                        break;
                    case "City":
                        if (fl.direction.from_City != Validate_Input(FromBox.Text) || fl.direction.to_City != Validate_Input(ToBox.Text))
                        {
                            res.Remove(fl);
                            i--;
                        }
                        break;
                    case "Airport":
                        if (fl.direction.from_Airport != Validate_Input(FromBox.Text) || fl.direction.to_Airport != Validate_Input(ToBox.Text))
                        {
                            res.Remove(fl);
                            i--;
                        }
                        break;
                }
            }
            res.Sort((x, y) => x.depart.CompareTo(y.depart));
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
            {
                frmSearchResults.frmFlightDetails.Visible = true;
                frmSearchResults.frmFlightDetails.flight = (Flight)ResentlyWatchedLst.SelectedItems[0];
                frmSearchResults.frmFlightDetails.EnterData();
                frmSearchResults.Visible = true;
                btnfSearchResBack.Visible = true;
            }
                
        }
        public void btnfSearchResBack_Click(object sender, EventArgs e)
        {
            frmSearchResults.ClearList();
            frmSearchResults.Visible = false;
            btnfSearchResBack.Visible = false;
            frmSearchResults.frmFlightDetails.Visible = false;
            searchedBindingSource.ResetBindings(false);
        }        
    }
}
