using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ResellerWebservice.Helpers
{
    public static class ConversionTool
    {
        public static DateTime? ToDate(string value)
        {
            try
            {
                if (String.IsNullOrEmpty(value))
                {
                    return null;
                }

                string[] formats = new string[4];
                formats[0] = "dd-MMM-yy";
                formats[1] = "dd/MMM/yyyy";
                formats[2] = "dd-MMM-yy;HH:mm:ss";
                formats[3] = "dd/MM/yyyy";
                return DateTime.ParseExact(value, formats, CultureInfo.InvariantCulture,
                                               DateTimeStyles.AssumeUniversal |
                                               DateTimeStyles.AdjustToUniversal);
            }
            catch
            {
                return null;
            }


        }
    }
}