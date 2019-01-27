using Android.App;
using Android.Content;
using System;

namespace TestXFApp
{
    /// <summary>
    ///  //With sharedpreferences you can save atomic values(logic, number, string, etc.).
    //With file you can save complexer information.
    //Where MyApp is my file name and the mode has taken the defualt value. MODE_PRIVATE is 
    //the operating mode for the preferences. It is the default mode and means the created 
    //file will be accessed by only the calling application.
    //Get SharedPreferences instance using one of the methods explained above.
    /// </summary>
    /* 
    public class SharedPreference
    {       
        private static  String PREFS_NAME = "MyApp"; //PREFS_NAME is the name of the file.
        private static  String PREFS_KEY = "Notification";//PREFS_NAME is the key .
        private ISharedPreferences prefs;//SharedPreferences instance       

        public SharedPreference() {
             prefs = Application.Context.GetSharedPreferences(PREFS_NAME, FileCreationMode.Private);
        }
        // Store Data in SharedPreferences
        public void StoreData(string SomeValue)
        {
            //Get SharedPreferences.Editor instance by calling edit() method in SharedPreferences instance.      
            var prefEditor = prefs.Edit();
            //Store values by calling one of the putXXXX() methods.
            prefEditor.PutString(PREFS_KEY, SomeValue);
            //Commit the editor object.
            prefEditor.Commit();
        }

        // Retrieve Data from SharedPreferences
        public string RetrieveData()
        {           
            //Call one of the getXXXX() methods using SharedPreferences instance. 
            var somePref = prefs.GetString(PREFS_KEY, null);
            return somePref;            
        }      
    }*/
}
