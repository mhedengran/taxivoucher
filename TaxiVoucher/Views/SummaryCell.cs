using System;
using Xamarin.Forms;

namespace TaxiPay
{
	public class SummaryCell : ViewCell
	{
		public SummaryCell ()
		{
			var dateLabel = new Label
			{
				HorizontalOptions= LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.Start
			};
			dateLabel.SetBinding(Label.TextProperty, "DateString");

			var priceLabel = new Label
			{
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,

			};
			priceLabel.SetBinding(Label.TextProperty, "TotalEarnings");

			var numberLabel = new Label
			{
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Center,

			};
			numberLabel.SetBinding(Label.TextProperty, "Number");

			var voucherLabel = new Label
			{
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,

			};
			voucherLabel.SetBinding(Label.TextProperty, "TotalVoucherEarnings");

			var voucherNumberLabel = new Label
			{
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Center,

			};
			voucherNumberLabel.SetBinding(Label.TextProperty, "VoucherNumber");

			var fromLabel = new Label
			{
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,

			};
			fromLabel.SetBinding(Label.TextProperty, "From");

			var toLabel = new Label
			{
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center,

			};
			toLabel.SetBinding(Label.TextProperty, "To");

			var grid = new Grid () {
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.End
			};
			grid.RowDefinitions.Add (new RowDefinition {
				Height = GridLength.Auto
			});
			grid.RowDefinitions.Add (new RowDefinition {
				Height = GridLength.Auto
			});
			grid.ColumnDefinitions.Add (new ColumnDefinition {
				Width = new GridLength(60, GridUnitType.Absolute)
			});
			grid.ColumnDefinitions.Add (new ColumnDefinition {
				Width = new GridLength(80, GridUnitType.Absolute)
			});
			grid.Children.Add (priceLabel, 0, 0);
			grid.Children.Add (numberLabel, 1, 0);
			grid.Children.Add (voucherLabel, 0, 1);
			grid.Children.Add (voucherNumberLabel, 1, 1);

			var gridAddress = new Grid () {
				VerticalOptions = LayoutOptions.Start,
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			gridAddress.RowDefinitions.Add (new RowDefinition {
				Height = GridLength.Auto
			});
			gridAddress.RowDefinitions.Add (new RowDefinition {
				Height = GridLength.Auto,
			});
			gridAddress.ColumnDefinitions.Add (new ColumnDefinition {
				Width = new GridLength(1, GridUnitType.Star)
			});
			gridAddress.ColumnDefinitions.Add (new ColumnDefinition {
				Width = new GridLength(1, GridUnitType.Star)
			});
			gridAddress.Children.Add (new Label { 
				Text = "Fra",
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center
			}, 0, 0);
			gridAddress.Children.Add (new StackLayout() {
				Padding = new Thickness(7, 0, 0, 0),
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.Center,
				Children = {fromLabel}
			}, 0, 1);
			gridAddress.Children.Add (new Label { 
				Text = "Til",
				HorizontalOptions = LayoutOptions.Start,
				VerticalOptions = LayoutOptions.Center
			}, 1, 0);
			gridAddress.Children.Add (new StackLayout() {
				Padding = new Thickness(7, 0, 0, 0),
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.Center,
				Children = {toLabel}
			}, 1, 1);

			var cellLayout = new StackLayout()
			{
				Padding = new Thickness(5, 5, 5, 5),
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Orientation = StackOrientation.Vertical,
				Children = { new StackLayout() {
					HorizontalOptions = LayoutOptions.FillAndExpand,
					VerticalOptions = LayoutOptions.Center,
					Orientation = StackOrientation.Horizontal,
					Children = { dateLabel, grid }
					},
					gridAddress
				}
			};

			Height = 150;

			View = cellLayout;
		}
	}
}

