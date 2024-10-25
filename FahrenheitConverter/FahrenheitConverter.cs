using FahrenheitConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenheitConverter
{
    public class TemperatureConverterViewModel : BindableObject
    {
        public string SelectedUnit { get; set; }
        public double InputTemperature { get; set; }
        private double convertedTemperature;
        public double ConvertedTemperature
        {
            get
            {
                return convertedTemperature;
            }
            set
            {
                convertedTemperature = value;
                OnPropertyChanged();
            }
        }

        public string[] Units { get; } = { "Fahrenheit", "Celsius" };
        public Command ConvertTemperatureCommand { get; set; }
        public TemperatureConverterViewModel()
        {
            ConvertTemperatureCommand = new Command(ConvertTemperature);
        }
        public void ConvertTemperature()
        {
            if (SelectedUnit == "Fahrenheit")
            {
                ConvertedTemperature = (InputTemperature - 32) * 5 / 9;
            }
            else if (SelectedUnit == "Celsius")
            {
                ConvertedTemperature = (InputTemperature * 9 / 5) + 32;
            }
        }
    }
}