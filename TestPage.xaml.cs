using System.Diagnostics;

namespace TestMaui;

public partial class TestPage : ContentPage {

    public TestPage() 
    {
        InitializeComponent();
    }

    void LoginButton_Clicked(object sender, EventArgs e) {
        Debug.WriteLine("Clicked !");

    }
}