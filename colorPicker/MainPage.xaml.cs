using System.Diagnostics;

namespace colorPicker;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
   
    string Hex_value = "";

    void r_slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        var color = Color.FromRgb((int)r_slider.Value, (int)g_slider.Value, (int)b_slider.Value);

        main_container.BackgroundColor = color;
        Hex_value =string.Format("#{0:X2}{1:X2}{2:X2}", (int)r_slider.Value, (int)g_slider.Value, (int)b_slider.Value);
        hex_value_button.Text = Hex_value;
        Debug.WriteLine((int)r_slider.Value);

    }

    void g_slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        var color = Color.FromRgb((int)r_slider.Value, (int)g_slider.Value, (int)b_slider.Value);

        main_container.BackgroundColor = color;
        Hex_value = string.Format("#{0:X2}{1:X2}{2:X2}", (int)r_slider.Value, (int)g_slider.Value, (int)b_slider.Value);
        hex_value_button.Text = Hex_value;
        Debug.WriteLine((int)g_slider.Value);


    }

    void b_slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        var color = Color.FromRgb((int)r_slider.Value, (int)g_slider.Value, (int)b_slider.Value);

        main_container.BackgroundColor = color;
        Hex_value = string.Format("#{0:X2}{1:X2}{2:X2}", (int)r_slider.Value, (int)g_slider.Value, (int)b_slider.Value);
        hex_value_button.Text = Hex_value;
        Debug.WriteLine((int)b_slider.Value);
    }

    void Random_color_button_Clicked(System.Object sender, System.EventArgs e)
    {
        Random rnd = new Random();
        r_slider.Value = rnd.Next(0, 256);
        g_slider.Value = rnd.Next(0, 256);
        b_slider.Value = rnd.Next(0, 256);
    }

    void hex_value_button_Clicked(System.Object sender, System.EventArgs e)
    {
        Clipboard.SetTextAsync(Hex_value);
    }
}


