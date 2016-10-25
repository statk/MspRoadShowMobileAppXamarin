using MspRoadShowMobileApp.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using MspRoadShowMobileApp;
using System.IO;
using System.Threading.Tasks;

[assembly: Dependency(typeof(SaveAndLoad))]

namespace MspRoadShowMobileApp.iOS
{
   public class SaveAndLoad:ISaveAndLoad
    {
        public async Task SaveText(string filename, string text)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            using (StreamWriter sw = File.CreateText(filePath))
            {
                await sw.WriteAsync(text);
            }
        }
        public async Task<string> LoadText(string filename)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentsPath, filename);
            using (StreamReader sr = File.OpenText(filePath))
            {
                return await sr.ReadToEndAsync();
            }
        }

    }
}
