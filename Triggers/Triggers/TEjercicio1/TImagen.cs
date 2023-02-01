using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Triggers.Triggers.TEjercicio1
{
    public class TImagen : TriggerAction<Image>
    {
        public bool activacion { get; set; }
        protected override async void Invoke(Image sender)
        {
            if (activacion == true)
            {
                //sender.BackgroundColor = Color.Red;
                await sender.RelRotateTo(360, 5000, Easing.BounceOut);
            }
            if (activacion == false)
            {
                //sender.BackgroundColor = new Image().BackgroundColor;
                sender.Rotation = new Image().Rotation;
            }
        }
    }
}
