using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXFApp
{
    /// <summary>
    /// Create our interface public
    /// inside of here is add 4 methods called
    ///  StoreData-save notifictation value into file
    ///  GetData -retrieve that value from file
    ///  FileExists- if the file is existing in mobile return true overwise return false
    ///  Exposing and accessing platform specific implementations
    /// </summary>
    //Use DependencyService to access device orientation from shared code
    public interface ISharedPreferences
    {    
        void StoreData(string key, object value);
        string GetData();
        void FileExists();      
        
    }
}
