using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Recall;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void ButtonClicked(object source, RoutedEventArgs args)
    {
        if (double.TryParse(Celsius.Text, out double C))
        {
            var f = C * (9d / 5d) + 32;
            Fahrenheit.Text = f.ToString("0.0");
        }
        else
        {
            Celsius.Text = "0";
            Fahrenheit.Text = "0";
        }

        Debug.WriteLine($"Click! Celsius={Celsius.Text}");
    }
}