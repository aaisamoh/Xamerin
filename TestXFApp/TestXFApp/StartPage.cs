using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace  TestXFApp

{
    class StartPage : ContentPage
    {
        Button button1;
        bool Authenticated;
        public StartPage()
        {
            Authenticated = Login1("password");
            var button1 = new Button { Text = "Login" };

            button1.Clicked += (o, e) =>
            {
                var page = new TabbedPage();
                page.Title = "Pages";

                var detailedListPage = new DetailedListPage();

                List<Post> allPosts = Post.GetPostList();
                var mainListPage = new MainListPage();
                //mainListPage.BindingContext = allPosts;

                Post firstPost = Post.GetPostList().FirstOrDefault();
                var mainMasterDetailPage = new MainMasterDetailPage();
                mainMasterDetailPage.BindingContext = firstPost;

                var considInfo = ConsidInformation.GetPostList();
                var aboutPage = new AboutPage();
                var settingsPage = new SettingsPage();
                aboutPage.BindingContext = considInfo;

                //page.Children.Add(detailedListPage);
                //page.Children.Add(new NavigationPage(mainListPage));
                page.Children.Add(mainListPage);
                //page.Children.Add(mainMasterDetailPage);
                page.Children.Add(aboutPage);
                page.Children.Add(settingsPage);
                Navigation.PushAsync(page);
            };
            Content = new StackLayout
            {
                Spacing = 10,
                Children = { button1 }
            };
        }
        private bool Login1(string PassWord)
        {
            if (PassWord == "password")
            {
                return true;
            }
            return false;
        }
    }
}
