using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MspRoadShowMobileApp.Droid;
using MspRoadShowMobileApp;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.IO;

[assembly: Dependency(typeof(SaveAndLoad))]
namespace MspRoadShowMobileApp.Droid
{
    public class SaveAndLoad : ISaveAndLoad
    {
        public async Task SaveText(string filename, string text)
        {
            var docsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(docsPath, filename);

            using (StreamWriter sw = File.CreateText(path))
            {
                await sw.WriteAsync(text);
            }
        }
        public async Task<string> LoadText(string filename)
        {
            var text = "";
            var docsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(docsPath, filename);
            using (StreamReader sr = File.OpenText(path))
            {
                text = await sr.ReadToEndAsync();
            }
            return text;
        }

        public Task<bool> IsFIleExist(string fileName)
        {
            var docsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(docsPath, fileName);

            return new Task<bool>(() => File.Exists(path));
        }

        public async Task DeleteFile(string fileName)
        {
            var docsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(docsPath, fileName);
            File.Delete(path);
            
        }
    }
}