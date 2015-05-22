using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uni_RT_SharedStyles;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SplitViewWithAdaptiveTrigger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
		private const string BOX_OFFICE_API_CALL = "http://api.rottentomatoes.com/api/public/v1.0/lists/movies/in_theaters.json?page_limit=15&page=1&country=us&apikey=7ue5rxaj9xn4mhbmsuexug54";
		private const string DVD_API_CALL = "http://api.rottentomatoes.com/api/public/v1.0/lists/dvds/new_releases.json?page_limit=15&page=1&country=us&apikey=7ue5rxaj9xn4mhbmsuexug54";

		public MainPage()
		{
			this.InitializeComponent();
			MainListView.ItemsSource = new MoviesDataSource(BOX_OFFICE_API_CALL);

		}

		private void HamburgerButton_Click(object sender, RoutedEventArgs e)
		{
			//MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
		}
	}
}
