using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ColorProcesador
{
    public partial class Second : ContentPage
    {
        public Second(string colorName, Color backgoundColor)
        {
            //InitializeComponent();
            var layout = new AbsoluteLayout();

            var centerLabel = new Label { Text = colorName, TextColor = Color.White, FontSize = 20};
            AbsoluteLayout.SetLayoutBounds(centerLabel, new Rectangle(180, 159, 120, 100));
            layout.BackgroundColor = backgoundColor;
            this.Content = layout;

            layout.Children.Add(centerLabel);

        }
    }
}
