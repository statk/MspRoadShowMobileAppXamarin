using MspRoadShowMobileApp.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(SaveAndLoad))]
namespace MspRoadShowMobileApp.UWP
{
   public class SaveAndLoad : ISaveAndLoad
    {
        public async Task SaveText(string filename, string text)
        {
            StorageFolder localFolder = ApplicationData.Current.LocalFolder;
            var sampleFile = await localFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
            
            await FileIO.WriteTextAsync(sampleFile, text);
        }
        public async Task<string> LoadText(string filename)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            var sampleFile = await storageFolder.GetFileAsync(filename);
            string text = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
            return text;
           
        }

        public async Task<bool> IsFIleExist(string fileName)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            var sampleFile = await storageFolder.TryGetItemAsync(fileName) !=null ? true : false;
            return sampleFile;
        }

        public async Task DeleteFile(string fileName)
        {
            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            var sampleFile = await storageFolder.GetFileAsync(fileName);
            await sampleFile.DeleteAsync();
        }
    }
}
