﻿using Prism;
using Prism.Ioc;
using ViaticosPrism.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Viaticos.Prism.ViewModels;
using Viaticos.Prism.Views;
using Viaticos.Common.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ViaticosPrism
{
    public partial class App
    {

        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/TripPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TripPage,TripPageViewModel>();
            containerRegistry.RegisterForNavigation<TripDetailsPage, TripDetailsPageViewModel>();
        }
    }
}
