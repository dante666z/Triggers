using System;
using System.Collections.Generic;
using System.Text;
using Triggers.VistaModelo;

namespace Triggers.Modelo
{
    public class MCategorias : BaseViewModel
    {
        public string descripcion { get; set; }
        public int numeroItem { get; set; }
        public string imagen { get; set; }

        //Objetos que interactuan con la interfaz
        public string _backGroundColor;
        public string _textColor;
        public bool _selected;

        public string BackGroundColor
        {
            get { return _backGroundColor; }
            set { SetProperty(ref _backGroundColor, value); }
        }
        public string TextColor
        {
            get { return _textColor; }
            set { SetProperty(ref _textColor, value); }
        }
        public bool Selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }


    }
}
