using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace FitnessAdvice.View
{
	public class BicepExeList : ContentPage
	{
		public ObservableCollection<Exercise> Bicepcirses { get; set; }
		public BicepExeList()
		{
			Bicepcirses = new ObservableCollection<Exercise>();
			ListView lstView = new ListView();
			lstView.RowHeight = 60;
			this.Title = "ListView Code Sample";
			lstView.ItemTemplate = new DataTemplate(typeof(BicepExeCell));
			Bicepcirses.Add(new Exercise { Name = "Towel Bicep Curl (1 leg)", Type = "Isolation", });//Image = "BicepCurl.png"
			///exercises.Add(new Exercise { Name = "Romaine Lettuce", Type = "Vegetable", Image = "lettuce.png" });
			///exercises.Add(new Exercise { Name = "Zucchini", Type = "Vegetable", Image = "zucchini.png" });
			lstView.ItemsSource = Bicepcirses;
			Content = lstView;
		}

		public class BicepExeCell : ViewCell
		{
			public BicepExeCell()
			{
				//instantiate each of our views
				var image = new Image();
				var nameLabel = new Label();
				var typeLabel = new Label();
				var verticaLayout = new StackLayout();
				var horizontalLayout = new StackLayout() { BackgroundColor = Color.White };

				//set bindings
				nameLabel.SetBinding(Label.TextProperty, new Binding("Name"));
				typeLabel.SetBinding(Label.TextProperty, new Binding("Type"));
				image.SetBinding(Image.SourceProperty, new Binding("Image"));

				//Set properties for desired design
				horizontalLayout.Orientation = StackOrientation.Horizontal;
				horizontalLayout.HorizontalOptions = LayoutOptions.Fill;
				image.HorizontalOptions = LayoutOptions.End;
				nameLabel.FontSize = 24;

				//add views to the view hierarchy
				verticaLayout.Children.Add(nameLabel);
				verticaLayout.Children.Add(typeLabel);
				horizontalLayout.Children.Add(verticaLayout);
				horizontalLayout.Children.Add(image);

				// add to parent view
				View = horizontalLayout;
			}
		}
	}
}
