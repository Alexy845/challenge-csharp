using System;
using System.Globalization;

namespace CSharpDiscovery.Quest02
{
    public class FromStringToDateTime_Exercice
    {
        public static DateTime FromStringToDateTime(string dateStr)
        {
            CultureInfo provider = new CultureInfo("fr-FR");
            return DateTime.ParseExact(dateStr, "dd/MM/yyyy HH:mm", provider);
        }
    }
}
