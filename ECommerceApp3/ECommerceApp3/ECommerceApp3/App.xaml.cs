using ECommerceApp3.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ECommerceApp3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class App : Application
	{
        #region Propierties
        public static NavigationPage Navigator { get; internal set; }
        public static MasterPage Master { get; internal set; }
        #endregion

        #region Constructors
        public App()
        {
            InitializeComponent();
            MainPage = new MasterPage();
        }
        #endregion

        #region Methods
        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
        #endregion

    }
}