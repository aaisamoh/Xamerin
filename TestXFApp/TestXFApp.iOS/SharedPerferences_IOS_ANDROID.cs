using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(TestXFApp.iOS.SharedPerferences_IOS_ANDROID))]
namespace TestXFApp.iOS
{
    class SharedPerferences_IOS_ANDROID : ISharedPreferences
    {
        public string filename = "MyAPP";

        public void StoreData(string key, object value)
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
