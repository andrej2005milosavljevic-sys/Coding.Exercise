using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataAnalyzer
{
    internal class WeatherDataAnalyzer
    {
        public (int Day, int TempRange, bool IsUnusual) Analyze(List<(int Day, int MinTemp, int MaxTemp)> data)
        {
            if (data == null || data.Count == 0)
            {
                return (0, 0, false);
            }
            var result = data
                .Where(d => d.MaxTemp >= d.MinTemp)
                .Select(d => new
                {
                    d.Day,
                    TempRange = d.MaxTemp - d.MinTemp,
                    IsUnusual = d.MaxTemp - d.MinTemp > 15
                })
                .OrderByDescending(d => d.TempRange)
                .FirstOrDefault();
            if (result == null)
            {
                return (0, 0, false);
            }
            return (result.Day, result.TempRange, result.IsUnusual);





        }
    }
}
