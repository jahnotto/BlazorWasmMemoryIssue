using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BlazorMem;

namespace WpfMem;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private MemTest _memTest = new MemTest();

    public MainWindow()
    {
        InitializeComponent();
        MeasureMem();
    }

    private void AllocateClick(object sender, RoutedEventArgs e)
    {
        try
        {
            _memTest.AllocateMemory();
        }
        catch (Exception ex)
        {
            ExceptionTextBlock.Text = ex.ToString();
        }

        MeasureMem();
    }

    private void FreeClick(object sender, RoutedEventArgs e)
    {
        _memTest.FreeMemory();

        if (GCCheckBox.IsChecked.Value)
        {
            GC.Collect();
        }

        MeasureMem();
    }

    private void MeasureMem()
    {
        MemTextBox.Text = $"{Process.GetCurrentProcess().PrivateMemorySize64 / (1024 * 1024)} MB";
    }

}