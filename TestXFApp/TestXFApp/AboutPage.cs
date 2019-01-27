using Xamarin.Forms;

namespace TestXFApp
{
    class AboutPage : ContentPage
    {
        public AboutPage()
        {
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            //BackgroundColor = Color.Gray;

            //this.Title = course.TitleShort;
            this.SetBinding(ContentPage.TitleProperty, "TitleShort");

            var titleLabel = new Label
            {
                //Text = course.Title,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            titleLabel.SetBinding(Label.TextProperty, "Title");

            var authorLabel = new Label
            {
                //Text = course.Author,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };
            authorLabel.SetBinding(Label.TextProperty, "Author");

            var descriptionLabel = new Label
            {
                //Text = course.Description,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };
            descriptionLabel.SetBinding(Label.TextProperty, "Description");


            var addressLabel = new Label
            {
                //Text = course.Description,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };
            addressLabel.SetBinding(Label.TextProperty, "Address");

            var phoneNrLabel = new Label
            {
                //Text = course.Description,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };
            phoneNrLabel.SetBinding(Label.TextProperty, "PhoneNr");

            var EmailLabel = new Label
            {
                //Text = course.Description,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
            };
            EmailLabel.SetBinding(Label.TextProperty, "Email");

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Spacing = 10,
                    Children = { titleLabel, authorLabel, descriptionLabel, addressLabel, phoneNrLabel, EmailLabel }
                }
            };

          
        }
    }
}
