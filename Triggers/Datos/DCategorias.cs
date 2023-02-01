using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Triggers.Modelo;

namespace Triggers.Datos
{
    public class DCategorias
    {
        public static ObservableCollection<MCategorias> MostrarCategorias()
        {
            return new ObservableCollection<MCategorias>()
            {
                new MCategorias()
                {
                    descripcion = "Cena",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/z6BHMzj/cena-de-navidad.png",
                    BackGroundColor = "#EAEDF6",
                    TextColor = "#000000"
                    
                },
                new MCategorias()
                {
                    descripcion = "Hotel",
                    numeroItem = 512,
                    imagen = "https://i.ibb.co/xzZKGf1/hotel.png",
                    BackGroundColor = "#EAEDF6",
                    TextColor = "#000000"
                    
                },
                 new MCategorias()
                {
                    descripcion = "Fiesta",
                    numeroItem = 1815,
                    imagen = "https://i.ibb.co/VYxtDGN/globos-de-aire.png",
                    BackGroundColor = "#EAEDF6",
                    TextColor = "#000000"

                },
                  new MCategorias()
                {
                    descripcion = "Flores",
                    numeroItem = 1815,
                    imagen = "https://i.ibb.co/17KTYMr/flor-de-loto.png",
                    BackGroundColor = "#EAEDF6",
                    TextColor = "#000000"

                },
            };
        }
    }
}
