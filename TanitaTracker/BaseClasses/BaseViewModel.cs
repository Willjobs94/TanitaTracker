﻿using System;
using Prism;
using Prism.Mvvm;

namespace TanitaTracker.BaseClasses
{
		public class BaseViewModel : BindableBase
		{
			public string Title
			{
				get { return _title; }
				set { SetProperty(ref _title, value); }
			}
			public bool IsBusy
			{
				get { return _isBusy; }
				set { SetProperty(ref _isBusy, value); }
			}
			private string _title;
			private bool _isBusy;
		}
}
