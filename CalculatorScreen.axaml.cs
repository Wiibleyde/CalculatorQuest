using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CalculatorQuest;

public partial class CalculatorScreen : Window
{
    public CalculatorScreen()
    {
        this.Width = 250;
        this.Height = 550;
        TextBlock label = new TextBlock
        {
            Text = "Test!",
            FontSize = 16,
            FontWeight = Avalonia.Media.FontWeight.Bold,
            Margin = new Thickness(10)
        };
        this.Content = label; 
        InitializeComponent();
    }

    private void Button0(object? sender, RoutedEventArgs e)
    {
        Console.WriteLine("Button Pressed");
    }

    private void ButtonC(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ButtonCE(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ButtonDel(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ButtonPercent(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ButtonApprox(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ButtonAdd(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ButtonSub(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Button1(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Button2(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Button3(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Button4(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Button5(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Button6(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Button7(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Button8(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Button9(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ButtonPoint(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ButtonEqual(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ButtonDivide(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ButtonMultiply(object? sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }
}