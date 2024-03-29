﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinVentas.Views;
using XamarinVentas.ViewModels;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinVentas
{
    public partial class App : Application
    {
        public App(String filename)
        {
            InitializeComponent();

            VentasViewModel.Inicializador(filename);
            MainPage = new ListaVentas();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
