using System;
using System.IO;
using Xamarin.Forms;

//add attribute, and that attribute is going to be called Dependency
//MainActivity class is going to used by the dependency system. 
//So with that Xamarin.forms can then use.

[assembly: Dependency(typeof(TestXFApp.Droid.SharedPerferences_IOS_ANDROID))]

namespace TestXFApp.Droid
{
    public class SharedPerferences_IOS_ANDROID : ISharedPreferences
    {

        public string filename="MyAPP";

        public void StoreData( string key, object value)
        {
            var filePath = CreatePathToFile();
            File.WriteAllText(filePath, value.ToString());
        }
        public string GetData()
        {          
            var filePath = CreatePathToFile();
            return File.ReadAllText(filePath);
            //MessagingCenter.Send<ISharedPreferences, string>(this, "GetDataToken", File.ReadAllText(filePath));
        }
        private string CreatePathToFile()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(documentsPath, filename);
        }
        public void FileExists()
        {
            MessagingCenter.Send<ISharedPreferences, bool>(this, "FileExistsToken", File.Exists(CreatePathToFile()));
            //return File.Exists(CreatePathToFile(filename));
        }

       
    }
}