﻿using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Xamarin.Forms;

namespace ExampleMaterialDesignControls.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        public delegate Task DisplayAlertType(string title, string message, string cancel);

        public DisplayAlertType DisplayAlert { get; set; }

        public INavigation Navigation { get; set; }

        [ICommand]
        private async Task Back()
        {
            await Navigation.PopAsync();
        }
    }
}