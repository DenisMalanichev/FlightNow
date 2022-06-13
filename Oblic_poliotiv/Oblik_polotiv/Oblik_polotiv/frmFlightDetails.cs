using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oblik_polotiv
{
    public partial class frmFlightDetails : UserControl
    {
        public Flight flight { get; set; }
        public frmFlightDetails()
        {
            InitializeComponent();
            
        }
        public void EnterData()
        {
            if (flight != null)
            {
                flightRoute.Text = flight.from_City + "( " + flight.from_Country + " ) - "
                     + flight.to_City + "( " + flight.to_Country + " ) ";
                lblCarrier.Text = flight.carrier;
                lblRoute.Text = flight.from_Airport + " " + flight.from_City + "( " + flight.from_Country +
                    " ) → " + flight.to_Airport + flight.to_City + "( " + flight.to_Country + " ) ";
                lblPrice.Text = lblPrice.Text + " " + flight.from_Price + "$";
                lblDepart.Text = flight.depart.Hour + ":" + flight.depart.Minute;
                lblArrive.Text = flight.arrive.Hour + ":" + flight.arrive.Minute;
                lblFliTime.Text = (flight.arrive.Hour - flight.depart.Hour) + "h " + (flight.arrive.Minute - flight.depart.Minute);
            }
        }       
    }
}
