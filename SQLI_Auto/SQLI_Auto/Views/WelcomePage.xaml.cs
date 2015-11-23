using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLI_Auto.Helpers;
using Xamarin.Forms;

namespace SQLI_Auto.Views
{
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();
            menu1.Content=new TileView("Itineraire", "itineraire_logo.png");
            menu2.Content = new TileView("Profil", "profile_logo.png");
            menu3.Content = new TileView("Reservation", "ParkReserve.jpg");
            menu4.Content = new TileView("NDF", "NDF_logo.png");
		}
	}
}
