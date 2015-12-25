using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLI_Auto.Helpers
{
    public class TileView : ContentView
    {
        Label label;
        string Title;
        Image Image;

        public TileView(string title, string image)
        {
            this.Title = title;
            this.Image= new Image { Aspect = Aspect.AspectFit };
            // A Frame surrounding image
            this.Image.Source=image;
            Image.HorizontalOptions = LayoutOptions.Center;
            Image.VerticalOptions = LayoutOptions.CenterAndExpand;

            
            

            Label tinyLabel = new Label
            {
                Text = this.Title,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.End
            };

            this.Padding = new Thickness(3);
            this.Content = new Frame
            {
                OutlineColor = Color.Accent,
                Padding = new Thickness(5, 10, 5, 0),
                Content = new StackLayout
                {
                    Spacing = 0,
                    Children = {
                        Image,
                        tinyLabel,
                    }
                }
            };

            // Don't let touch pass us by.
            this.BackgroundColor = Color.Transparent;
        }


        public async Task AnimateWinAsync(bool isReverse)
        {
            uint length = 150;
            await Task.WhenAll(this.ScaleTo(3, length), this.RotateTo(180, length));
            //label.Text = isReverse ? Title : Image;
            await Task.WhenAll(this.ScaleTo(1, length), this.RotateTo(360, length));
            this.Rotation = 0;
        }

        //public void SetLabelFont(double fontSize, FontAttributes attributes)
        //{
        //    Image.FontSize = fontSize;
        //    label.FontAttributes = attributes;
        //}
    }
}
