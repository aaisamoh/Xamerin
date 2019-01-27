using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;
using Windows.Storage;
using Xamarin.Forms;


[assembly: Dependency(typeof(TestXFApp.WinPhone.SharedPreferences_WinPhone))]

namespace TestXFApp.WinPhone
{

    // it here on the WinPhon side
    class SharedPreferences_WinPhone : ISharedPreferences
    {
        //private string CreatePathToFile(string filename)
        //{
        //    var  docsPath = Windows.Storage.ApplicationData.Current.LocalFolder;
        //    return Path.Combine(docsPath.ToString(),filename);
        //}
        public static string filename = "MyAPP.txt";
        public void FileExists()
        {
            //return IsFileExists(filename).Result;
            IsFileExists();
            bool res = true;
            MessagingCenter.Send<ISharedPreferences, bool>(this, "FileExistsToken", res);

        }
        bool IsFileExists()
        {
            StorageFolder localFolder = ApplicationData.Current.LocalFolder;
            try
            {
                localFolder.GetFileAsync(filename).AsTask().Wait();
                return true;
            }
            catch
            {
                return false;
            }
          
        }
        string GetNotificationsKey()
        {
            var type = this.GetType();
            var assembly = type.GetTypeInfo().Assembly;

            var resource = type.Namespace + "." +
             /* Device.OnPlatform("iOS", "Droid", "WinPhone") +*/ ".Settings.xml";
            using (var stream = assembly.GetManifestResourceStream(resource))
            using (var reader = new StreamReader(stream))
            {
                var doc = XDocument.Parse(reader.ReadToEnd());
                return doc.Element("config").Element("notification_value").Value;


            }
        }
        public string GetData()
        {

            var task = LoadTextAsync();

            return task.Result.ToString();
           
        }

        async Task<object> LoadTextAsync()
        {
            var local =
                Windows.ApplicationModel.Package.Current.InstalledLocation;
              
            //  ApplicationData.Current.LocalFolder;Get the file instance from the current folder
          StorageFolder assetsFolder = await StorageFolder.GetFolderFromPathAsync(local.Path);
            StorageFile file =await assetsFolder.GetFileAsync(filename);
                //get all the properties associated  with the file
                var fileProperties = await file.Properties.RetrievePropertiesAsync(new List<string>());

            var latitude = fileProperties["notifictaionToken"];
            return latitude;

        }
        public async void StoreData(string Key,object  Value)
        {
            //Using WPS you can store and retrieve properties of the items such as folders, files, contacts or emails
            //Get the app's local folder
            var local =
                Windows.ApplicationModel.Package.Current.InstalledLocation;
            //Create new file  in the current folder
            //replace if the file is already exists

            var file = await local.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);

            IEnumerable<KeyValuePair<string, object>> propertiesToSave = 
                 new KeyValuePair<string, object>[] {

                     new KeyValuePair<string, object>("df","ere")

                 } ;

            try {
                   await file.Properties.SavePropertiesAsync();

            }catch(ArgumentException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
               
           
        }
    }
}
