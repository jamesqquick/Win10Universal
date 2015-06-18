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

namespace AdaptiveTriggers_StylesAndTemplates
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
		private const string API_KEY = "7ue5rxaj9xn4mhbmsuexug54";
        private const string IN_THEATERS_API_CALL = "http://api.rottentomatoes.com/api/public/v1.0/lists/movies/in_theaters.json?page_limit=15&page=1&country=us&apikey="+API_KEY;
		private const string ON_DVD_API_CALL = "http://api.rottentomatoes.com/api/public/v1.0/lists/dvds/new_releases.json?page_limit=15&page=1&country=us&apikey="+API_KEY;
		private const string UPCOMING_DVD_CALL = "http://api.rottentomatoes.com/api/public/v1.0/lists/dvds/upcoming.json?page_limit=16&page=1&country=us&apikey=" + API_KEY;
        public MainPage(Frame frame)
        {
            this.InitializeComponent();
			//MoviesDataSource source = new MoviesDataSource(IN_THEATERS_API_CALL);
			this.MySplitView.Content = frame;
			
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			//MainListView.ItemsSource = new MoviesDataSource(IN_THEATERS_API_CALL);
		}

		private void HamburgerButton_Click(object sender, RoutedEventArgs e)
		{
			//MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
		}

		private void InTheatersButton_Click(object sender, RoutedEventArgs e)
		{
			//MainListView.ItemsSource = new MoviesDataSource(IN_THEATERS_API_CALL);
			var frame = this.DataContext as Frame;
			Page page = frame?.Content as Page;
			frame.Navigate(typeof(Views.InTheaters));
		}

		private void OnDVDButton_Click(object sender, RoutedEventArgs e)
		{
			//MainListView.ItemsSource = new MoviesDataSource(ON_DVD_API_CALL);
			var frame = this.DataContext as Frame;
			Page page = frame?.Content as Page;
			frame.Navigate(typeof(Views.InTheaters));
		}

		private void UpcomingDVDButton_Click(object sender, RoutedEventArgs e)
		{
			//MainListView.ItemsSource = new MoviesDataSource(UPCOMING_DVD_CALL);
			var frame = this.DataContext as Frame;
			Page page = frame?.Content as Page;
			frame.Navigate(typeof(Views.InTheaters));
		}
	}
}
