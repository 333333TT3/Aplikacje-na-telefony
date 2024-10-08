using System;
using Microsoft.Maui.Controls;

namespace UnitConverterApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnConvertClicked(object sender, EventArgs e)
        {
            if (double.TryParse(InputValue.Text, out double value))
            {
                string fromUnit = FromUnitPicker.SelectedItem.ToString();
                string toUnit = ToUnitPicker.SelectedItem.ToString();

                double convertedValue = ConvertUnits(value, fromUnit, toUnit);
                ResultLabel.Text = $"{value} {fromUnit} = {convertedValue:F2} {toUnit}"; //gdzie "convertedValue:F2" zmienia numeracje do drugiego miejsca po przecinku(formatuje).
            }
            else
            {
                ResultLabel.Text = "Enter a valid number.";
            }
        }

        private double ConvertUnits(double value, string fromUnit, string toUnit)
        {
            double valueInMeters = value;

            switch (fromUnit)
            {
                case "mm":
                    valueInMeters = value / 1000;
                    break;
                case "cm":
                    valueInMeters = value / 100;
                    break;
                case "m":
                    valueInMeters = value; 
                    break;
            }
            switch (toUnit)
            {
                case "mm":
                    return valueInMeters * 1000;
                case "cm":
                    return valueInMeters * 100;
                case "m":
                    return valueInMeters;
            }
            return value;
        }
    }
}