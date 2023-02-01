using System;
using Triggers.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Triggers
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Ejercicio1();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
