using System;

namespace Thermometer
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            Temperature[] temp = new Temperature[4];
            Console.Write("Add the temperature: ");
            bool ok = Int32.TryParse(Console.ReadLine(), out t);
            if (!ok) Environment.Exit(77);
            Console.Write("Add the unit: ");
            Unit unit = (Unit)Enum.Parse(typeof(Unit), Console.ReadLine());
            temp[0] = new(t, unit);

            Console.Write("Add the temperature: ");
            ok = Int32.TryParse(Console.ReadLine(), out t);
            if (!ok) Environment.Exit(77);
            Console.Write("Add the unit: ");
            unit = (Unit)Enum.Parse(typeof(Unit), Console.ReadLine());
            temp[1] = new(t, unit);

            Random rnd = new();
            temp[2] = new(rnd.Next(100), 0);
            temp[3] = new(rnd.Next(100), 0);
            temp[0].ConvertTemp();
            temp[1].ConvertTemp();

            Console.WriteLine(Temperature.ConvertTempTo(temp[0], Unit.KELVIN).ToString());
            

            double s = AvargeTempKelvin(temp);
            Console.WriteLine( s );
        }

        static void WriteOut(Temperature[] temp)
        {
            foreach (Temperature t in temp)
            {
                Console.WriteLine(t.ToString());
            }
        }

        static double AvargeTempKelvin(Temperature[] temp)
        {
            double sum = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Unit == Unit.CELSIUS) sum += Temperature.ConvertTempTo(temp[i], Unit.KELVIN).temperature;
                else sum += temp[i].temperature;
            }
            return sum / temp.Length;
        }
    }
}
