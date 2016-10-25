using MspRoadShowMobileApp.WinPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(SaveAndLoad))]
namespace MspRoadShowMobileApp.WinPhone
{
    public class SaveAndLoad : ISaveAndLoad
    {
        public void SaveText(string filename, string text)
        {
            StorageFolder localFolder = ApplicationData.Current.LocalFolder;
            var sampleFile = localFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting).GetResults();
            FileIO.WriteTextAsync(sampleFile, text).GetResults();
        }
        public string LoadText(string filename)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile sampleFile = storageFolder.GetFileAsync(filename).GetResults();
            string text = Windows.Storage.FileIO.ReadTextAsync(sampleFile).GetResults();
            return text;
        }

    }
}