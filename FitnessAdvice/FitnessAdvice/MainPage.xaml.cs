﻿using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System;
using Android.Service.Controls;

namespace FitnessAdvice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Exercises(), true);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsBasic(), true);
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Meal(), true);
        }
    }
}