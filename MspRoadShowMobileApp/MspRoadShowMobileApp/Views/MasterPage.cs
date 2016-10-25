using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MspRoadShowMobileApp.Views
{
    public class MasterPage : MasterDetailPage
    {
        public MasterPage( ContentPage page)
        {
            Master = new MenuView();
            Detail = page;
        }
    }
}
