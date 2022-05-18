using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thermometer
{
    class TempTest
    {
        int t;
        Temperature[] temp = new Temperature[4];
        Console.Write("Add the temperature: ");
            bool ok = Int32.TryParse(Console.ReadLine(), out t);
            if (!ok) Environment.Exit(77);
            Console.Write("Add the unit: ");
            Unit unit = (Unit)Enum.Parse(typeof(Unit), Console.ReadLine());
        temp[0] = new(t, unit);
    }
}
