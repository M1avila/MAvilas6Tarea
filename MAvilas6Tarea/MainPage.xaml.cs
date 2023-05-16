using MAvilas6Tarea.WS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MAvilas6Tarea
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "http://192.168.1.45/Mobiles/post.php";
        private readonly HttpClient cliente= new HttpClient();
        private ObservableCollection<MAvilas6Tarea.WS.Datos> post;
        public MainPage()
        {
            InitializeComponent();
            obtener();
        }
        public async void obtener() 
        {
        var content= await cliente.GetStringAsync(Url);
            List<MAvilas6Tarea.WS.Datos> posts = JsonConvert.DeserializeObject<List<MAvilas6Tarea.WS.Datos>>(content);
            post= new ObservableCollection<WS.Datos>(posts);
            lista.ItemsSource=post;
        }

        private void btnRegistro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Registro());
        }

        private void btnactualiza_Clicked(object sender, EventArgs e)
        {

        }


     
        private void btnEliminar_Clicked(object sender, EventArgs e)

        {
         // var eli =  DELETE FROM estudiante WHERE codico = eliminar;

        }

        private void lista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
