using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace SampleUniversalApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

			Message = "Hello x:Bind";
		}

		public string Message { get; private set; }
		

		private void button_Click(object sender, RoutedEventArgs e)
		{
			var random = new Random();

			textBlock.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255,
				(byte)random.Next(255),
				(byte)random.Next(255),
				(byte)random.Next(255)));
        }

		private void textBlock_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
		{
			(textBlock.FindName("beginStoryBoard") as Windows.UI.Xaml.Media.Animation.Storyboard).Begin();
        }

		private void RealEnterButton_Click(object sender, RoutedEventArgs e)
		{
			frame.Navigate(typeof(VideoPage2));
		}
	}
}
