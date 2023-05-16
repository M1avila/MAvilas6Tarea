using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MAvilas6Tarea
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Clicked(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //CREAR UNA VARIABLE TIPO WET CLACEAN
                WebClient cliente =new WebClient();
                //varuable que almacene los datos
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo",txtCodigo.Text);
                parametros.Add("nombre",txtNombre.Text);
                parametros.Add("apellido",txtApellido.Text);
                parametros.Add("edad",txtEdad.Text);

                //esta variable se coinecta para el envio de los datos
                cliente.UploadValues("http://192.168.1.45/Mobiles/post.php","POST", parametros);
                DisplayAlert("Alerta","dato ingresado","cerrar");
                txtCodigo.Text = "";
                txtNombre.Text="";
                txtApellido.Text="";
                 txtEdad.Text ="";


            }
            catch (Exception ex)
            {

                DisplayAlert("ALERTA", ex.Message, "CERRAR");
            }

        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());

        }
    }
}