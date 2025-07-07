using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Tmds.DBus.Protocol;

namespace AvaloniaTest;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void Home(object sender, RoutedEventArgs e)
    {
        string HelloWorld;
        HelloWorld = "Hello World";
        Console.WriteLine(HelloWorld);
    }
    
}