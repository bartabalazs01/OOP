using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermometer
{
    enum Unit
    {
        CELSIUS,
        KELVIN
    }
    class Temperature
    {
        private double _temperature;
        private Unit _unit;

        private const double K = 273.15;

        public double temperature { get => _temperature; set => _temperature = value; }
        internal Unit Unit { get => _unit; set => _unit = value; }

        public Temperature(double temperature, Unit unit)
        {
            _temperature = temperature;
            _unit = unit;
        }
        
        public Temperature(double temperature) : this(temperature, 0)
        {
            
        }

        public override string ToString()
        {
            return $"Temperature: {_temperature}, Unit: {_unit}"; 
        }

        public void ConvertTemp()
        {
            if (_unit == Unit.CELSIUS)
            {
                _temperature += K;
                _unit = Unit.KELVIN;
            }
            else
            {
                _temperature -= K; 
                _unit = Unit.CELSIUS;
            }
        }

        public static Temperature ConvertTempTo(Temperature temp, Unit outUnit)
        {
            if (temp.Unit == outUnit) 
                return temp;
            if (outUnit == Unit.CELSIUS) 
                return new(temp.temperature + K, Unit.KELVIN);
            return new(temp.temperature - K, Unit.CELSIUS);
        }
    }
}
