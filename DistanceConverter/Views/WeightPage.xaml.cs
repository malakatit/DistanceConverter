namespace DistanceConverter.Views;

public partial class WeightPage : ContentPage
{
    private double KeyValue = 0;

    private double kg2g = 1000;
    private double kg2lb = 2.20462;
    private double kg2oz = 35.274;
    private double kg2t = 0.001;
    private double kg2kg = 1;

    public WeightPage()
    {
        InitializeComponent();
        Title = "Weight DistanceConverter";
    }

    private void Convert_OnClicked(object sender, EventArgs e)
    {
        txtKilograms.Text = (KeyValue * kg2kg).ToString("g9");
        txtGrams.Text = (KeyValue * kg2g).ToString("g9");
        txtPounds.Text = (KeyValue * kg2lb).ToString("g9");
        txtOunces.Text = (KeyValue * kg2oz).ToString("g9");
        txtTons.Text = (KeyValue * kg2t).ToString("g9");
    }

    private void Clear_OnClicked(object sender, EventArgs e)
    {
        txtKilograms.Text = "";
        txtGrams.Text = "";
        txtPounds.Text = "";
        txtOunces.Text = "";
        txtTons.Text = "";
    }

    private void TxtKilograms_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        if (Double.TryParse(txtKilograms.Text, out number) && number != 0)
            KeyValue = number / kg2kg;
        else
            KeyValue = 0;
    }

    private void TxtGrams_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        if (Double.TryParse(txtGrams.Text, out number) && number != 0)
            KeyValue = number / kg2g;
        else
            KeyValue = 0;
    }

    private void TxtPounds_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        if (Double.TryParse(txtPounds.Text, out number) && number != 0)
            KeyValue = number / kg2lb;
        else
            KeyValue = 0;
    }

    private void TxtOunces_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        if (Double.TryParse(txtOunces.Text, out number) && number != 0)
            KeyValue = number / kg2oz;
        else
            KeyValue = 0;
    }

    private void TxtTons_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        double number;
        if (Double.TryParse(txtTons.Text, out number) && number != 0)
            KeyValue = number / kg2t;
        else
            KeyValue = 0;
    }
}