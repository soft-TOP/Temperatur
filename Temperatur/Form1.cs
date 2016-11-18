using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatur
{
    public partial class Form1 : Form
    {
        private Temperature tA = new Temperature();

        public Form1()
        {
            InitializeComponent();
            numericUpDownTempA.Minimum = numericUpDownTempB.Minimum = numericUpDownRechne.Minimum = numericUpDownRechneErgebnis.Minimum = Decimal.MinValue;
            numericUpDownTempA.Maximum = numericUpDownTempB.Maximum = numericUpDownRechne.Maximum = numericUpDownRechneErgebnis.Maximum = Decimal.MaxValue;

            foreach (var item in Enum.GetValues(typeof(TemperaturEinheit)))
            {
                comboBoxEinheitA.Items.Add(item);
                comboBoxEinheitB.Items.Add(item);
            }

            foreach (var item in typeof(Temperature).GetMethods())
            {
                if (item.MemberType == System.Reflection.MemberTypes.Method)
                {
                    var attributs = item.GetCustomAttributes(false);
                    foreach (var att in attributs)
                    {
                        if ((att as TempCalcAttribute)?.IsCalculationMethod != null)
                        {
                            comboBoxRechne.Items.Add(item.Name);
                        }
                    }
                }
            }
            comboBoxEinheitA.SelectedIndex = comboBoxEinheitB.SelectedIndex = comboBoxRechne.SelectedIndex = 0;
        }

        private void konvertiere()
        {
            if (null != this && Created)
            {
                switch ((TemperaturEinheit)comboBoxEinheitA.SelectedItem)
                {
                    case TemperaturEinheit.Kelvin: tA.Kelvin = (Single)numericUpDownTempA.Value; break;
                    case TemperaturEinheit.Celsius: tA.Celsius = (Single)numericUpDownTempA.Value; break;
                    case TemperaturEinheit.Fahrenheit: tA.Fahrenheit = (Single)numericUpDownTempA.Value; break;
                }

                switch ((TemperaturEinheit)comboBoxEinheitB.SelectedItem)
                {
                    case TemperaturEinheit.Kelvin: numericUpDownTempB.Value = (Decimal)tA.Kelvin; break;
                    case TemperaturEinheit.Celsius: numericUpDownTempB.Value = (Decimal)tA.Celsius; break;
                    case TemperaturEinheit.Fahrenheit: numericUpDownTempB.Value = (Decimal)tA.Fahrenheit; break;
                }
            }
        }

        private void rechne()
        {
            if (null != this && Created)
            {
                String op = comboBoxRechne.SelectedItem.ToString();
                Temperature tErgebnis;
                /* Bei op... werden zwei Temperaturen benötigt, die addiert werden
                 * Die Anzahl und den Typ könnte man natürlich ebenfalls über die Reflection abfragen
                 * Bei den anderen Methoden wird nur eine Zahl im Single-Format benötigt
                 * Der Einfachheit halber wurde daher eine einfach if-Abfrage mit den passenden
                 * und bekannten Parametern verwendet
                 */
                if (op.StartsWith("op"))
                    tErgebnis = (Temperature)typeof(Temperature).GetMethod(op).Invoke(tA, new Temperature[] { tA, new Temperature() { Kelvin = Math.Max(Temperature.MinValue.Kelvin, (Single)numericUpDownRechne.Value) } });
                else
                    tErgebnis = (Temperature)typeof(Temperature).GetMethod(op).Invoke(tA, new object[] { (Single)numericUpDownRechne.Value });
                switch ((TemperaturEinheit)comboBoxEinheitA.SelectedItem)
                {
                    case TemperaturEinheit.Kelvin: numericUpDownRechneErgebnis.Value = (Decimal)tErgebnis.Kelvin; break;
                    case TemperaturEinheit.Celsius: numericUpDownRechneErgebnis.Value = (Decimal)tErgebnis.Celsius; break;
                    case TemperaturEinheit.Fahrenheit: numericUpDownRechneErgebnis.Value = (Decimal)tErgebnis.Fahrenheit; break;
                }
            }
        }

        private void numericUpDownTempA_ValueChanged(Object sender, EventArgs e)
        {
            konvertiere();
            rechne();
        }

        private void comboBoxEinheitA_SelectedIndexChanged(Object sender, EventArgs e)
        {
            labelErgebnisEinheit.Text = ((ComboBox)sender).SelectedItem.ToString();
            konvertiere();
            rechne();
        }

        private void numericUpDownB_ValueChanged(Object sender, EventArgs e)
        {
            konvertiere();
        }

        private void comboBoxEinheitB_SelectedIndexChanged(Object sender, EventArgs e)
        {
            konvertiere();
        }

        private void comboBoxRechne_SelectedIndexChanged(Object sender, EventArgs e)
        {
            rechne();
        }

        private void numericUpDownRechne_ValueChanged(Object sender, EventArgs e)
        {
            rechne();
        }

        private void comboBoxRechne_SelectedIndexChanged_1(Object sender, EventArgs e)
        {
            rechne();
        }
    }
}
