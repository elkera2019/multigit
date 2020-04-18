using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;



namespace multi
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    
    //public partial class Inicio : ContentPage
    public partial class Inicio : MasterDetailPage
    {

        public Inicio()
        {
            InitializeComponent();
            //Navigation.PopModalAsync();
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
            //Detail = new NavigationPage(new HomePage());
            //IsPresented = false;
            NavigationPage.SetHasBackButton(this,false);
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AddEmployee());
            IsPresented = false;
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ListEmployee());
            IsPresented = false;
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutUs());
            IsPresented = false;
        }
        private void Button_Clickded4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ContactUs());
            IsPresented = false;
        }


        //private void Conexion(object sender, System.EventArgs e)
        //{
        //    var current = Connectivity.NetworkAccess;
        //    if (current == NetworkAccess.Internet)
        //    {
        //       DisplayAlert("alerta", "Conexion exitosa", "Ok");
        //    }
        //    else
        //    {
        //       DisplayAlert("alerta", "No posee conexion", "Ok");
        //    }
        //    var profile = Connectivity.ConnectionProfiles;
        //    if (profile.Contains(ConnectionProfile.WiFi))
        //    {
        //         DisplayAlert("alerta", "Conexion exitosa", "Ok");
        //    }
        //    else
        //    {
        //       DisplayAlert("alerta", "No posee conexion", "Ok");
        //    }
        //}


    }
}