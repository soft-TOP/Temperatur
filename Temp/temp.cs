#define opAnzeige

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Temperatur
{
    public enum TemperaturEinheit { Celsius, Kelvin, Fahrenheit }

    [System.AttributeUsage(System.AttributeTargets.Method, Inherited = false, AllowMultiple = true)]
    public class TempCalcAttribute : Attribute
    {
        //TODO Sortierreihenfolge festlegen
        private Boolean isCcalculationMethod = false;

        /// <summary>
        /// Kennzeichnet eine Methode als 
        /// </summary>
        /// <param name="IsCalculationMethod"></param>
        public TempCalcAttribute(Boolean IsCalculationMethod)
        {
            isCcalculationMethod = IsCalculationMethod;
        }

        /// <summary>
        /// Gibt TRUE zurück, wenn die Methode für eine Kalkulation vorgesehen ist
        /// </summary>
        public Boolean IsCalculationMethod => isCcalculationMethod;
    }

    public class Temperature
    {
        #region private Felder
        private const Single diffKelvinCelsius = 273.15f;
        private TemperaturEinheit einheit = TemperaturEinheit.Kelvin;
        /// <summary>
        /// Die tatsächlich gespeicherte Temperatur
        /// </summary>
        private Single kelvin = 0;
        private String sFahrenheit => $"{Fahrenheit,2}°F";
        private String sKelvin => $"{Kelvin,2}K";
        private String sCelsius => $"{Celsius,2}°C";
        #endregion

        public Temperature()
        {
        }

        /// <summary>
        /// nur für internen Gebrauch des MinValue
        /// </summary>
        /// <param name="Kelvin">kleinstmögliche Temperatur über dem absoluten Nullpunkt</param>
        private  Temperature(Single Kelvin)
        {
            this.kelvin = Kelvin;
        }

        /// <summary>
        /// Die minimal zulässige Temperatur (mit 2 Nachkommastellen)
        /// </summary>
        public static Temperature MinValue = new Temperature(0.01f);

        /// <summary>
        /// Die Temperatur in K (mit 2 Nachkommastellen)
        /// </summary>
        public Single Kelvin
        {
            get
            {
                return kelvin;
            }

            set
            {
                if (value < MinValue.Kelvin)
                {
                    throw new ArgumentOutOfRangeException($"Temperatur nicht möglich! Der Minimalwert ist {MinValue.ToString(einheit)}");
                }
                else
                {
                    kelvin = value;
                    einheit = TemperaturEinheit.Kelvin;
                }
            }
        }

        /// <summary>
        /// Die Temperatur in °C (mit 2 Nachkommastellen)
        /// </summary>
        public Single Celsius
        {
            get
            {
                return kelvin - diffKelvinCelsius;
            }

            set
            {
                einheit = TemperaturEinheit.Celsius;
                Kelvin = value + diffKelvinCelsius;
            }
        }

        /// <summary>
        /// Die Temperatur in °F (mit 2 Nachkommastellen)
        /// </summary>
        public Single Fahrenheit
        {
            get
            {
                return (Single)Math.Round(Celsius * 9 / 5 + 32, 2);
            }

            set
            {
                einheit = TemperaturEinheit.Fahrenheit;
                Celsius = (Single)Math.Round((value - 32) * 5 / 9, 2);
            }
        }

#if opAnzeige
        [TempCalc(true)]
#endif
        public static Temperature operator +(Temperature a, Temperature b) 
            => new Temperature() { Kelvin = a.Kelvin + b.Kelvin };

#if opAnzeige
        [TempCalc(true)]
#endif
        public static Temperature operator -(Temperature a, Temperature b) 
            => new Temperature() { Kelvin = a.Kelvin - b.Kelvin };


        /// <summary>
        /// fügt einer Temperatur einen Wert hinzu
        /// </summary>
        /// <param name="Temperatur">Die zu addierende Temperaturdifferenz</param>
        /// <param name="Einheit">Die Einheit der hinzugefügten Temperaturdifferenz</param>
        /// <returns>Summe aus ursprünglicher Temperatur und Temperaturdifferenz</returns>
        public Temperature Add(Single Temperatur, TemperaturEinheit Einheit)
        {
            switch (Einheit)
            {
                case TemperaturEinheit.Kelvin: 
                    return new Temperature() { Kelvin = Kelvin + Temperatur };
                case TemperaturEinheit.Celsius:
                    return new Temperature() { Celsius = Celsius + Temperatur }; // separat Ermitteln wegen der Einheit bei der Fehlermeldung
                case TemperaturEinheit.Fahrenheit:
                    return new Temperature() { Fahrenheit = Fahrenheit + Temperatur };
                default:
                    return new Temperature() { Kelvin = Kelvin };
            }
        }

        /// <summary>
        /// fügt einer Temperatur einen Wert in Kelvin hinzu
        /// </summary>
        /// <param name="Temperatur">Die zu addierende Temperaturdifferenz in Kelvin</param>
        /// <returns>Summe aus ursprünglicher Temperatur und Temperaturdifferenz</returns>
        [TempCalc(true)]
        public Temperature AddKelvin(Single Temperatur) => Add(Temperatur, TemperaturEinheit.Kelvin);

        /// <summary>
        /// fügt einer Temperatur einen Wert in Kelvin hinzu
        /// </summary>
        /// <param name="Temperatur">Die zu addierende Temperaturdifferenz in Kelvin</param>
        /// <returns>Summe aus ursprünglicher Temperatur und Temperaturdifferenz</returns>
        [TempCalc(true)]
        public Temperature AddCelsius(Single Temperatur) => Add(Temperatur, TemperaturEinheit.Celsius);

        /// <summary>
        /// fügt einer Temperatur einen Wert in °Fahrenheit hinzu
        /// </summary>
        /// <param name="Temperatur">Die zu addierende Temperaturdifferenz in °Fahrenheit</param>
        /// <returns>Summe aus ursprünglicher Temperatur und Temperaturdifferenz</returns>
        [TempCalc(true)]
        public Temperature AddFahrenheit(Single Temperatur) => Add(Temperatur, TemperaturEinheit.Fahrenheit);

        /// <summary>
        /// gibt die Temperatur aus (mit 2 Nachkommastellen)
        /// wählt die Einheit länderabhängig aus
        /// </summary>
        /// <returns>Zeichenkette mit Temperatur in landestypischer Einheit</returns>
        public override String ToString()
        {
            if (CultureInfo.InstalledUICulture == CultureInfo.GetCultureInfo("en-US"))
                return sFahrenheit;
            else
                return sCelsius;
        }

        /// <summary>
        /// gibt die Temperatur in der gewünschten Einheit aus (mit 2 Nachkommastellen)
        /// </summary>
        /// <param name="Einheit">Einheit, in welcher die Temperatur ausgegebenen werden soll</param>
        /// <returns>Zeichenkette mit Temperatur und Einheit</returns>
        public String ToString(TemperaturEinheit Einheit)
        {
            switch (Einheit)
            {
                case TemperaturEinheit.Kelvin:
                    return sKelvin;
                case TemperaturEinheit.Celsius:
                    return sCelsius;
                case TemperaturEinheit.Fahrenheit:
                    return sFahrenheit;
                default:
                    throw new Exception("nicht definierte Temperatureinheit");
            }
        }

        /// <summary>
        /// gibt die Temperatur in der gewünschten Einheit aus (mit 2 Nachkommastellen)
        /// erlaubte Werte sind:
        ///"K"
        ///"Kelvin"
        ///"C"
        ///"°C"
        ///"Celsius"
        ///"°Celsius"
        ///"F"
        ///"°F"
        ///"Fahrenheit"
        ///"°Fahrenheit"
        /// löste anderenfalls eine Exception aus
        /// </summary>
        /// <param name="Einheit">Einheit, in welcher die Temperatur ausgegebenen werden soll</param>
        /// <returns>Zeichenkette mit Temperatur und Einheit</returns>
        public String ToString(String Einheit)
        {
            //string s = System.Reflection.MethodInfo.GetCurrentMethod().Name;
            switch (Einheit)
            {
                case "K":
                case "Kelvin": return ToString(TemperaturEinheit.Kelvin);
                case "C":
                case "°C":
                case "Celsius":
                case "°Celsius":return ToString(TemperaturEinheit.Celsius);
                case "F":
                case "°F":
                case "Fahrenheit":
                case "°Fahrenheit":return ToString(TemperaturEinheit.Fahrenheit);
                default:
                    throw new Exception($@"""{Einheit}"" ist eine nicht definierte Temperatureinheit");
            }
        }
    }
}
