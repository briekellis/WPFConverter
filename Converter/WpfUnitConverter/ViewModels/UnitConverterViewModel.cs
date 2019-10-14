using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfUnitConverter.ViewModels
{
    
    public class UnitConverterViewModel : ObservableObject
    {
        public ICommand ButtonConvertCommand {get; set;}
        private double _result;

        public double Operand { get; set; }
        public string OperandUnit { get; set; }

        public string ResultUnit { get; set; }

        public double Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        public List<string> Units { get; set; }

        private List<string> BuildOutUnitComboBoxSource()
        {
            return new List<string>() { "Inches", "Feet", "Miles", "Millimeters", "Centimeters", "Meters", "Kilometers" };
        }
        private void PerformCalculation(object obj)
        {
           // inches
            if (OperandUnit== "Inches" && ResultUnit == "Feet")
            {
                Result = Operand / 12;
            }
            else if (OperandUnit == "Inches" && ResultUnit == "Miles")
                {
                Result = Operand / 63360;
                }
            else if (OperandUnit == "Inches" && ResultUnit == "Millimeters")
            {
                Result = Operand * 25.4;
            }
            else if (OperandUnit == "Inches" && ResultUnit == "Centimeters")
            {
                Result = Operand * 2.54;
            }
            else if (OperandUnit == "Inches" && ResultUnit == "Meters")
            {
                Result = Operand * 39.37;
            }
            else if (OperandUnit == "Inches" && ResultUnit == "Kilometers")
            {
                Result = Operand * 39370.079;
            }
            //new
            if (OperandUnit == "Feet" && ResultUnit == "Inches")
            {
                Result = Operand / 12;
            }
            else if (OperandUnit == "Feet" && ResultUnit == "Miles")
            {
                Result = Operand / 5280;
            }
            else if (OperandUnit == "Feet" && ResultUnit == "Millimeters")
            {
                Result = Operand * 304.8;
            }
            else if (OperandUnit == "Feet" && ResultUnit == "Centimeters")
            {
                Result = Operand * 30.48;
            }
            else if (OperandUnit == "Feet" && ResultUnit == "Meters")
            {
                Result = Operand * 3.281;
            }
            else if (OperandUnit == "Feet" && ResultUnit == "Kilometers")
            {
                Result = Operand * 3280.84;
            }
            //miles
            if (OperandUnit == "Miles" && ResultUnit == "Feet")
            {
                Result = Operand * 5280;
            }
            else if (OperandUnit == "Miles" && ResultUnit == "Inches")
            {
                Result = Operand * 63360;
            }
            else if (OperandUnit == "Miles" && ResultUnit == "Millimeters")
            {
                Result = Operand * 1609344;
            }
            else if (OperandUnit == "Miles" && ResultUnit == "Centimeters")
            {
                Result = Operand * 160934.4;
            }
            else if (OperandUnit == "Miles" && ResultUnit == "Meters")
            {
                Result = Operand * 1609.344;
            }
            else if (OperandUnit == "Miles" && ResultUnit == "Kilometers")
            {
                Result = Operand * 1.609;
            }
            //millimeters
            
            if (OperandUnit == "Millimeters" && ResultUnit == "Feet")
            {
                Result = Operand / 304.8;
            }
            else if (OperandUnit == "Millimeters" && ResultUnit == "Inches")
            {
                Result = Operand / 25.4;
            }
            else if (OperandUnit == "Millimeters" && ResultUnit == "Miles")
            {
                Result = Operand / 1609344;
            }
            else if (OperandUnit == "Millimeters" && ResultUnit == "Centimeters")
            {
                Result = Operand / 10;
            }
            else if (OperandUnit == "Millimeters" && ResultUnit == "Meters")
            {
                Result = Operand * 1000;
            }
            else if (OperandUnit == "Millimeters" && ResultUnit == "Kilometers")
            {
                Result = Operand * 1000000;
            }
            //Centimeters
            if (OperandUnit == "Centimeters" && ResultUnit == "Feet")
            {
                Result = Operand / 30.48;
            }
            else if (OperandUnit == "Centimeters" && ResultUnit == "Inches")
            {
                Result = Operand / 2.54;
            }
            else if (OperandUnit == "Centimeters" && ResultUnit == "Miles")
            {
                Result = Operand / 160934.4;
            }
            else if (OperandUnit == "Centimeters" && ResultUnit == "Millimeters")
            {
                Result = Operand * 10;
            }
            else if (OperandUnit == "Centimeters" && ResultUnit == "Meters")
            {
                Result = Operand / 100;
            }
            else if (OperandUnit == "Centimeters" && ResultUnit == "Kilometers")
            {
                Result = Operand * 100000;
            }
            //meters
            if (OperandUnit == "Meters" && ResultUnit == "Feet")
            {
                Result = Operand * 3.281;
            }
            else if (OperandUnit == "Meters" && ResultUnit == "Inches")
            {
                Result = Operand * 39.37;
            }
            else if (OperandUnit == "Meters" && ResultUnit == "Miles")
            {
                Result = Operand / 1609.344;
            }
            else if (OperandUnit == "Meters" && ResultUnit == "Millimeters")
            {
                Result = Operand * 1000;
            }
            else if (OperandUnit == "Meters" && ResultUnit == "Centimeters")
            {
                Result = Operand * 100;
            }
            else if (OperandUnit == "Meters" && ResultUnit == "Kilometers")
            {
                Result = Operand / 1000;
            }
            //Kilometers
            if (OperandUnit == "Kilometers" && ResultUnit == "Feet")
            {
                Result = Operand * 3280.84;
            }
            else if (OperandUnit == "Kilometers" && ResultUnit == "Inches")
            {
                Result = Operand * 39370.079;
            }
            else if (OperandUnit == "Kilometers" && ResultUnit == "Miles")
            {
                Result = Operand / 1.609;
            }
            else if (OperandUnit == "Kilometers" && ResultUnit == "Millimeters")
            {
                Result = Operand * 1000000;
            }
            else if (OperandUnit == "Kilometers" && ResultUnit == "Centimeters")
            {
                Result = Operand * 100000;
            }
            else if (OperandUnit == "Kilometers" && ResultUnit == "Meters")
            {
                Result = Operand / 1000;
            }
            

        }

        public UnitConverterViewModel()
        {
            //Operand = 44; //value to confirm binding of property
            Units = BuildOutUnitComboBoxSource();
            ButtonConvertCommand = new RelayCommand(new Action<object>(PerformCalculation));
        }
    }

}

