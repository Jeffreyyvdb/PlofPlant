

using PlofPlantData.Context;
using PlofPlantData.Models;

namespace PlofPlantConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //using(var db = new PlofPlantDbContext())
            //{
            //    var verdieping1 = db.Verdiepingen.Find(1);

            //    var startDatum = DateTime.Now.AddDays(-1);

            //    for (int i = 0; i < 24 * 12; i++)
            //    {
            //        var ph = GetRandomNumber(4,7.5d);
            //        var ec = GetRandomNumber(0,10);
            //        var waterLevel = GetRandomNumber(0,10);
            //        var LichtLevel = GetRandomNumber(0,10);

            //        var datum = startDatum.AddMinutes(i * 5);

            //        var verdiepingData = new VerdiepingData()
            //        {
            //        Ph = ph ,
            //        Ec = ec,
            //        WaterLevel= waterLevel ,
            //        LichtLevel = LichtLevel,
            //        DatumToegevoegd = datum
            //        };

            //        verdieping1.VerdiepingData.Add(verdiepingData);
            //    }
            //    db.SaveChanges();

            //using (var db = new PlofPlantDbContext())
            //{
            //    var kas1 = db.Kassen.Find(1);

            //    var startDatum = DateTime.Now.AddDays(-1);

            //    for (int i = 0; i < 24 * 12; i++)
            //    {

            //        var datum = startDatum.AddMinutes(i * 5);

            //        var kasData = new KasData()
            //        {
            //            Temp = GetRandomNumber(15, 25),
            //            Co2 = GetRandomNumber(200, 1100),
            //            Luchtvochtigheid = GetRandomNumber(50, 70),
            //            IsDeurOpen = false,
            //            DatumToegevoegd = datum
            //        };

            //        kas1.KasData.Add(kasData);
            //    }
            //    db.SaveChanges();

            //}

            double GetRandomNumber(double minimum, double maximum)
            {
                Random random = new Random();
                return random.NextDouble() * (maximum - minimum) + minimum;
            }
        }

    }
}






