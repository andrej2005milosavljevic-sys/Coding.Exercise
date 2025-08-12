using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class FitnessTracker
    {
        public (
            string MostPerformedActivity,
            double RunningTotal,
            double CyclingTotal,
            double AvgCalorieIntake,
            double AvgCalorieBurned,
            int OverIntakeDays
            ) AnalyzeData(string filename)
        {
            double runningTotal = 0;
            double cyclingTotal = 0;

            Dictionary<DateTime, double> calorieIntakePerDay = new Dictionary<DateTime, double>();
            Dictionary<DateTime, double> calorieBurnedPerDay = new Dictionary<DateTime, double>();

            foreach (var line in System.IO.File.ReadLines(filename))
            {
                var parts = line.Split(',');

                DateTime date = DateTime.ParseExact(parts[0], "yyyy-MM-dd",CultureInfo.InvariantCulture);
                string activity = parts[1];
                double distance = double.Parse(parts[2], CultureInfo.InvariantCulture);
                double calories = double.Parse(parts[3], CultureInfo.InvariantCulture);

                switch(activity)
                {
                    case "Running":
                        runningTotal += distance;
                        if (!calorieBurnedPerDay.ContainsKey(date))
                        {
                            calorieBurnedPerDay[date] = 0;
                        }
                        calorieBurnedPerDay[date] += calories;
                        break;
                    case "Cycling":
                        cyclingTotal += distance;
                        if (!calorieBurnedPerDay.ContainsKey(date))
                        {
                            calorieBurnedPerDay[date] = 0;
                        }
                        calorieBurnedPerDay[date] += calories;
                        break;
                    case "Eating":
                        if (!calorieIntakePerDay.ContainsKey(date))
                        {
                            calorieIntakePerDay[date] = 0;
                        }
                        calorieIntakePerDay[date] += calories;
                        break;



                }
            }
            string mostPerformedActivity = runningTotal > cyclingTotal ? "Running" : "Cycling";

            var allDates = new HashSet<DateTime>(calorieIntakePerDay.Keys.Concat(calorieBurnedPerDay.Keys));
            double totalIntake = 0;
            double totalBurned = 0;
            int overIntakeDays = 0;

            foreach (var date in allDates)
            {
                double intake = calorieIntakePerDay.ContainsKey(date) ? calorieIntakePerDay[date] : 0;
                double burned = calorieBurnedPerDay.ContainsKey(date) ? calorieBurnedPerDay[date] : 0;

                totalIntake += intake;
                totalBurned += burned;

                if (intake > burned)
                {
                    overIntakeDays++;
                }
            }

            int totalDays = allDates.Count;
            double avgIntake = totalDays > 0 ? totalIntake / totalDays : 0;
            double avgBurned = totalDays > 0 ? totalBurned / totalDays : 0;

            return (
                mostPerformedActivity,
                runningTotal,
                cyclingTotal,
                avgIntake,
                avgBurned,
                overIntakeDays
            );


        }
        }
    }
}
