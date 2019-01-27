using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestXFApp
{
    class PostCell : ViewCell
    {
        public PostCell()
        {                      
            var titleLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            titleLabel.SetBinding(Label.TextProperty, new Binding("Title"));

            var authorLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                //XAlign = TextAlignment.End,
                //HorizontalOptions = LayoutOptions.FillAndExpand
            };
            authorLabel.SetBinding(Label.TextProperty, new Binding("Author"));

            var contentLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                //HorizontalOptions = LayoutOptions.FillAndExpand,
                //VerticalOptions = LayoutOptions.End
            };
            contentLabel.SetBinding(Label.TextProperty, new Binding("Description"));

            //titleLabel.SetBinding(Label.TextProperty, new Binding("Title"));
            View = new StackLayout
            {
                Padding = new Thickness(0,10,0,10),
                //Spacing = 21,
                Children = { titleLabel, authorLabel, contentLabel },
                Orientation = StackOrientation.Vertical
            };
        }
    }
}
