using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TestXFApp
{
    class DetailedListPage : ContentPage
    {
        public DetailedListPage()
        {
            this.Title = "List2";
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            var listView = new ListView();
            listView.HasUnevenRows = true;
            listView.ItemsSource = Post.GetPostList();
            listView.ItemTemplate = new DataTemplate(typeof(PostCell));

            Content = listView;


            //List<Post> postList;
            //ListView listView;
            //List<PostPage> pageList;

            //pageList = new List<PostPage>();
            //listView = new ListView();
            //postList = Post.GetPostList();

            //foreach (var item in postList)
            //{
            //    pageList.Add(new PostPage(item));
            //}
            //listView.ItemsSource = pageList;
            //Content = listView;
        }
    }
}
