
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace TaxiPay.Android
{
	public class NormalButtonAndroid : LinearLayout
	{
		public string LabelText { get; set; } = "";
		public bool ArrowPositionRight { get; set; } = false;

		public NormalButtonAndroid (Context context) :
			base (context)
		{
			Initialize (context);
		}

		public NormalButtonAndroid (Context context, IAttributeSet attrs) :
			base (context, attrs)
		{
			Initialize (context);
		}

		public NormalButtonAndroid (Context context, IAttributeSet attrs, int defStyle) :
			base (context, attrs, defStyle)
		{
			Initialize (context);
		}

		void Initialize (Context context)
		{
			Inflate(context, Resource.Drawable.normalButton, this);
		}
	}
}

