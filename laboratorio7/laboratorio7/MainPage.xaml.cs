using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace laboratorio7
{
    public partial class MainPage : ContentPage
    {
        public IList<Estudiantes> Estudiantes { get; private set; }
        public MainPage()
        {
            InitializeComponent();

            Estudiantes = new List<Estudiantes>();

            Estudiantes.Add(new Estudiantes
            {
                Name = "Ariana",
                Ciclo = "5",
                seccion = "A",
                Edad = "20"
            });

            Estudiantes.Add(new Estudiantes
            {
                Name = "Nicol",
                Ciclo = "5",
                seccion = "A",
                Edad = "20"
            });

            Estudiantes.Add(new Estudiantes
            {
                Name = "Jose",
                Ciclo = "5",
                seccion = "A",
                Edad = "20"
            });
            BindingContext = this;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}
