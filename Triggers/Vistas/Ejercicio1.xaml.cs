using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Triggers.VistaModelo;
namespace Triggers.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ejercicio1 : ContentPage
    {
        public Ejercicio1()
        {
            InitializeComponent();
            BindingContext = new VMEjercicio1(Navigation);
        }
    }
}