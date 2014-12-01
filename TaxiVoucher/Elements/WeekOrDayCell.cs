using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class WeekOrDayCell : ViewCell
	{
		public WeekOrDayCell ()
		{
			var dayOrWeekLabel = new Label
			{
				HorizontalOptions= LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.Center
			};
			dayOrWeekLabel.SetBinding(Label.TextProperty, "DateString");

			var totalEarningsLabel = new Label
			{
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,

			};
			totalEarningsLabel.SetBinding(Label.TextProperty, "TotalEarnings");

			var numberLabel = new Label
			{
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Center,

			};
			numberLabel.SetBinding(Label.TextProperty, "Number");

			var grid = new Grid () {
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.End
			};
			grid.RowDefinitions.Add (new RowDefinition {
				Height = GridLength.Auto
			});
			grid.ColumnDefinitions.Add (new ColumnDefinition {
				Width = new GridLength(90, GridUnitType.Absolute)
			});
			grid.ColumnDefinitions.Add (new ColumnDefinition {
				Width = new GridLength(90, GridUnitType.Absolute)
			});
			grid.Children.Add (totalEarningsLabel, 0, 0);
			grid.Children.Add (numberLabel, 1, 0);

			var cellLayout = new StackLayout()
			{
				Padding = new Thickness(10, 0, 10, 0),
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.Center,
				Orientation = StackOrientation.Horizontal,
				Children = { dayOrWeekLabel, grid }
			};

			View = cellLayout;
		}
	}
}

