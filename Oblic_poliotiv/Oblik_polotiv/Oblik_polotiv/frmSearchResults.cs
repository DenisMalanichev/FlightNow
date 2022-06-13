using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Oblik_polotiv
{
    public partial class frmSearchResults : UserControl
    {               
        public frmSearchResults()
        {
            InitializeComponent();            
        }
        public void printResults(List<Flight> res)
        {
            foreach (Flight flight in res)
            {
                lstBoxSearchResults.Items.Add(flight);                
            }
        }       

        private void lstBoxSearchResults_DoubleClick(object sender, EventArgs e)
        {            
            Form1 f1 = new Form1();
            if (lstBoxSearchResults.SelectedItems.Count > 0)
            {
                f1.receiveSearched(lstBoxSearchResults.SelectedItems[0].ToString());
                frmFlightDetails.Visible = true;
                frmFlightDetails.flight = (Flight)lstBoxSearchResults.SelectedItems[0];
                frmFlightDetails.EnterData();
            }      
        }

       public void ClearList()
        {
            lstBoxSearchResults.Items.Clear();
        }

        private void btnSaveFlights_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                string text = "";
                foreach (string line in lstBoxSearchResults.Items)
                    text += line +"\n";
                File.WriteAllText(name, text);
            }
        }

    }
}
