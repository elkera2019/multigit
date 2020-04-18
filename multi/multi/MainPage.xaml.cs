using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using multi.Datos;


namespace multi
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
      
        //void Probando(object sender , System.EventArgs e)
        //{
        //    count++;
        //    ((Button)sender).Text=$"Haz clickacado {count}";
        //}
        //async void Probando(object sender, System.EventArgs e)
     private void Probando(object sender, System.EventArgs e)
        {
            if (txtusuario.Text != string.Empty && txtcontraseña.Text != string.Empty)
            {
                var User = new Usuarios { Usuario = txtusuario.Text, Contraseña = txtcontraseña.Text };
                var iniciopage = new Inicio();
                if (User.Usuario == "Ramces" && User.Contraseña == "123")
                {
                    //await Navigation.PushModalAsync(iniciopage);
                    //((NavigationPage)this.Parent).PushAsync(new Inicio());
                    Navigation.InsertPageBefore(iniciopage,this);
                    //Navigation.PushModalAsync(iniciopage);
                    Navigation.PopAsync();
                    

                }
                else
                {
                    //Console.Write("Usuario incorrecto");
                   DisplayAlert("Informacion","Usuario o contraseña incorrecta","Ok");
                }
            }
        }
        
    }
}
