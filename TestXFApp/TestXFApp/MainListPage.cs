using System;
using Xamarin.Forms;

namespace TestXFApp
{   
    class MainListPage : ContentPage
    {
      
     ///one second
      private  object NOTIFICATIONS_VALUE="1";
        static int count = 0;
    
        public MainListPage()
        {

           
            this.Title = "List";
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);

            if (!Application.Current.Properties.ContainsKey("NotificationToken"))
            {
                Application.Current.Properties["NotificationToken"] = 1;
              
            }
                ISharedPreferences prefs = DependencyService.Get<ISharedPreferences>();
            //prefs.StoreData(NOTIFICATIONS_VALUE);
            //prefs.GetData();

            //MessagingCenter.Subscribe<ISharedPreferences, bool>(this, "FileExistsToken",
            //    (sender, arg) => {
            //        exists = arg;
            //    });

            //if (exists) {

            //    prefs.GetData();

            //    MessagingCenter.Subscribe<ISharedPreferences, string>(this, "GetDataToken",
            //   (sender, arg) => {
            //       NOTIFICATIONS_VALUE = arg;
            //   });
            //}
            //    else 
            //prefs.StoreData("notifictaionToken", "dd3");
            //prefs.GetData();
            NOTIFICATIONS_VALUE = Application.Current.Properties["NotificationToken"];
           
       
            ScheduleTest stest = new ScheduleTest(1, int.Parse(NOTIFICATIONS_VALUE.ToString()) * 1000);
          
           
            stest.ScheduledThread(new performCallback(updating), new object());

            //Save START_PREFS_VALUE in the file within the mobile
            // in case it is not created earlier and again retrieve
            //data from file and save it in static variable NOTIFICATIONS_VALUE.

            //var retrieveData = prefs.RetrieveData();
            //if (retrieveData == null || retrieveData == "") prefs.StoreData(START_PREFS_VALUE);
            //  else NOTIFICATIONS_VALUE = prefs.RetrieveData();

            //(24/int.Parse(NOTIFICATIONS_VALUE))*60*60
            // Start class that we  need to update databases och 
            //appear notification about the last article
            //var activateOfData= new ActivateOfUpdatingData("notification");
            //activateOfData.ScheduleAtFixedRate(new performClass(), 1000,1000* long.Parse(NOTIFICATIONS_VALUE));
            //new ScheduleTest(long.Parse(NOTIFICATIONS_VALUE)).ScheduledThread();

            ListView allPosts = new ListView();
            allPosts.ItemsSource = Post.GetPostList();

            allPosts.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    var page = new PostPage();
                    page.BindingContext = Post.GetPostById(1);
                    Navigation.PushAsync(page);
                    var s = e.SelectedItem;
                    allPosts.SelectedItem = null;
                }
            };
                       Content = allPosts;
        }

        private void updating(object state)
        {
        
         System.Diagnostics.Debug.WriteLine("Test about databases uppdatering  ....! {0}", count++);
        }
    }
}
