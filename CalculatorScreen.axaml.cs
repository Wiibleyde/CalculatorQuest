using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace CalculatorQuest;

public partial class CalculatorScreen : Window
{
    public string Calcul { get; set; }
    private Label inputLabel;
    
    public CalculatorScreen()
    {
        this.Width = 250;
        this.Height = 550;
        InitializeComponent();
        inputLabel = this.FindControl<Label>("InputLabelCalc");
    }

    private void Button0(object? sender, RoutedEventArgs e)
    {
        Calcul += "0";
        inputLabel.Content = Calcul;
    }

    private void ButtonC(object? sender, RoutedEventArgs e)
    {
        Calcul = "";
        inputLabel.Content = Calcul;
    }

    private void ButtonCE(object? sender, RoutedEventArgs e)
    {
        Console.WriteLine("Button CE Pressed");
        inputLabel.Content = Calcul;
    }

    private void ButtonDel(object? sender, RoutedEventArgs e)
    {
        Calcul = Calcul.Remove(Calcul.Length - 1);
        inputLabel.Content = Calcul;
    }

    private void ButtonPercent(object? sender, RoutedEventArgs e)
    {
        Calcul += "%";
        inputLabel.Content = Calcul;
    }

    private void ButtonApprox(object? sender, RoutedEventArgs e)
    {
        Console.WriteLine("Button +/- Pressed");
        inputLabel.Content = Calcul;
    }

    private void ButtonAdd(object? sender, RoutedEventArgs e)
    {
        Calcul += "+";
        inputLabel.Content = Calcul;
    }

    private void ButtonSub(object? sender, RoutedEventArgs e)
    {
        Calcul += "-";
        inputLabel.Content = Calcul;
    }

    private void Button1(object? sender, RoutedEventArgs e)
    {
        Calcul += "1";
        inputLabel.Content = Calcul;
    }

    private void Button2(object? sender, RoutedEventArgs e)
    {
        Calcul += "2";
        inputLabel.Content = Calcul;
    }

    private void Button3(object? sender, RoutedEventArgs e)
    {
        Calcul += "3";
        inputLabel.Content = Calcul;
    }

    private void Button4(object? sender, RoutedEventArgs e)
    {
        Calcul += "4";
        inputLabel.Content = Calcul;
    }

    private void Button5(object? sender, RoutedEventArgs e)
    {
        Calcul += "5";
        inputLabel.Content = Calcul;
    }

    private void Button6(object? sender, RoutedEventArgs e)
    {
        Calcul += "6";
        inputLabel.Content = Calcul;
    }

    private void Button7(object? sender, RoutedEventArgs e)
    {
        Calcul += "7";
        inputLabel.Content = Calcul;
    }

    private void Button8(object? sender, RoutedEventArgs e)
    {
        Calcul += "8";
        inputLabel.Content = Calcul;
    }

    private void Button9(object? sender, RoutedEventArgs e)
    {
        Calcul += "9";
        inputLabel.Content = Calcul;
    }

    private void ButtonPoint(object? sender, RoutedEventArgs e)
    {
        Calcul += ".";
        inputLabel.Content = Calcul;
    }

    private void ButtonEqual(object? sender, RoutedEventArgs e)
    {
        string result = Calcul;
        Calc calc = new CalculatorQuest.Calc();
        try 
        {
            result = calc.Operator(Calcul).ToString();
            if (result == "666")
            {
                Calcul = "DEVIL";
            }
            else
            {
                Calcul = result;   
            }
        }
        catch (DivideByZeroException)
        {
            Calcul = "Error";
        }
        catch (ArgumentException)
        {
            Calcul = "Error";
        }
        inputLabel.Content = Calcul;
    }

    private void ButtonDivide(object? sender, RoutedEventArgs e)
    {
        Calcul += "/";
        inputLabel.Content = Calcul;
    }

    private void ButtonMultiply(object? sender, RoutedEventArgs e)
    {
        Calcul += "x";
        inputLabel.Content = Calcul;
    }
}