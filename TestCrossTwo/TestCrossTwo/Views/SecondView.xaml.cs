﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestCrossTwo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondView : MvxContentPage
	{
		public SecondView ()
		{
			InitializeComponent ();
		}
	}
}