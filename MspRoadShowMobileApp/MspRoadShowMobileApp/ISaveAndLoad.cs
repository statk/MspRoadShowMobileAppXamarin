using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MspRoadShowMobileApp
{
    public interface ISaveAndLoad
    {
        Task  SaveText(string filename, string text);
        Task<string> LoadText(string filename);
        Task<bool> IsFIleExist(string fileName);
        Task DeleteFile(string fileName);
    }
}
