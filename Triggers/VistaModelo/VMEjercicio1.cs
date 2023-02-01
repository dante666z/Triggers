using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Triggers.Modelo;
using System.Linq;
using Xamarin.Forms.Internals;

namespace Triggers.VistaModelo
{
    public class VMEjercicio1 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        bool _activadorAnimImagen;
        ObservableCollection<MCategorias> _listaCategorias;
        string _imagen;
        #endregion

        #region CONSTRUCTOR
        public VMEjercicio1(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();
        }
        #endregion
        #region OBJETOS
        public string Imagen
        {
            get { return _imagen; }
            set { SetValue(ref _imagen, value); }
        }
        public bool ActivadorAnimImagen
        {
            get { return _activadorAnimImagen; }
            set { SetValue(ref _activadorAnimImagen, value); }
        }
        public ObservableCollection<MCategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetValue(ref _listaCategorias, value); }
        }
        #endregion

        #region PROCESOS
       
        public void Seleccionar(MCategorias modelo)
        {
            var index = ListaCategorias
                .ToList()
                .FindIndex(p => p.descripcion == modelo.descripcion);
            Imagen = modelo.imagen;
            if(index > -1)
            {
                Deseleccionar();
                ActivadorAnimImagen = true;
                ListaCategorias[index].Selected = true;
                ListaCategorias[index].BackGroundColor = "#FF506B";
                ListaCategorias[index].TextColor = "#FFFFFF";
            }
        }
        public void Deseleccionar()
        {
            ListaCategorias.ForEach((item) =>
            {
                ActivadorAnimImagen = false;
                item.Selected = false;
                item.TextColor = "#000000";
                item.BackGroundColor = "#EAEDF6";
            });
        }
        public void MostrarCategorias()
        {
            ListaCategorias = new ObservableCollection<MCategorias>(Datos.DCategorias.MostrarCategorias());
        }
        #endregion

        #region COMANDOS
        //public ICommand ProcesoAsyncCommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand SeleccionarCommand => new Command<MCategorias>((p) => Seleccionar(p));
        #endregion
    }
}
