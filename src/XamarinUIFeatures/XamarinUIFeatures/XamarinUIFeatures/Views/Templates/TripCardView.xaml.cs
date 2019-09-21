using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinUIFeatures.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TripCardView : ContentView
    {
        public TripCardView()
        {
            InitializeComponent();
        }
    }
}