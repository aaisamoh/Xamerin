using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestXFApp
{
    class MainMasterDetailPage : MasterDetailPage
    {
        public MainMasterDetailPage()
        {
            this.Title = "MasterDetail";
            //ContentPage.TitleProperty = "";
            var listView = new ListView();
            listView.ItemsSource = Post.GetPostList();

            listView.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Detail.BindingContext = e.SelectedItem;

                    IsPresented = false;
                }
            };
            Master = new ContentPage
            {
                Title = "Posts",
                Content = listView
            };

            Detail = new PostPage();
            Detail.BindingContext = Post.GetPostList();
        }

    }
}

