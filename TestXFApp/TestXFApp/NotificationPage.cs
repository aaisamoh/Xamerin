﻿using Android.OS;
using System;
using Xamarin.Forms;

namespace TestXFApp
{
    class NotificationPage:ContentPage
    {      
        private Label header;
        private string entry;
        //private SharedPreference pref = new SharedPreference();
        ISharedPreferences prefs = DependencyService.Get<ISharedPreferences>();

        public NotificationPage()
        {
            //Retrieve the old settings value from SharedPreferences
           prefs.GetData();
            //Retrieve the old settings value from SharedPreferences
            MessagingCenter.Subscribe<ISharedPreferences, string>(this, "GetDataToken",
             (sender, arg) => {
                 entry = arg;
             });

            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            Title = "Notification";

            var nLabel = new Label {
                Text = "Enter Notifications value:",
                FontSize =Device.GetNamedSize(NamedSize.Medium,typeof(Label)),              
                HorizontalOptions = LayoutOptions.Center               
            };
          
              header = new Label
            {
                Text = entry,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions =LayoutOptions.Center
                
            };

            //Stepper allows you to set a number of properties that customize its behavior:
            //Minimum and Maximum set the minimum and maximum values, 
            //the Increment sets the increment value.
            var stepper = new Stepper
            {
                Minimum=1,
                Maximum=24,
                Increment=1,
                Value= double.Parse(entry),
                HorizontalOptions=LayoutOptions.Center               
            };

               stepper.ValueChanged += Stepper_ValueChanged;
               var saveButton = new Xamarin.Forms.Button
                {
                     Text = "Save",
                     BackgroundColor=Color.Red
                 };

             saveButton.Clicked += SaveButton_Clicked;

            Content = new StackLayout
            {
                Spacing = 10,
                Children = { nLabel,header, stepper, saveButton}
            };
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            header.Text = e.NewValue.ToString();
            entry = header.Text;
        }
       
        // Save settings in mobile into file
        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            // Storing the new value into SharedPreferences
            prefs.StoreData("notifictaionToken",entry);
           
            DisplayAlert("Completed", "The value has been saved successfully..."+entry, "Ok");

        }
    }
}