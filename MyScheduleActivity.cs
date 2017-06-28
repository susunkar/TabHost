﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace com.xamarin.example.tabhostwalkthrough
{
    [Activity(Label = "MyScheduleActivity", Icon = "@drawable/ic_launcher")]
    public class MyScheduleActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            TextView textview = new TextView(this);
            textview.Text = "This is the My Schedule tab";
            SetContentView(textview);
        }
    }
}