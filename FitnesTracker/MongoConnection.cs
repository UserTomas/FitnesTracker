using System;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FitnesTracker
{
    //internal class MongoConnection
    //{
    //    public static string connectionString = "mongodb://127.0.0.1:27017";
    //    public static MongoClient dbClient = new MongoClient(connectionString);

    //    public static IMongoDatabase db = dbClient.GetDatabase("tracker");
    //    public static IMongoCollection<Shot> collection = db.GetCollection<Shot>("measurement");
    //    public static IMongoCollection<Counter> counterCol = db.GetCollection<Counter>("counters");



    //    public MongoConnection()
    //    {
    //        MainAsync().Wait();
    //        //Task<List<BsonDocument>> data = new Task<List<BsonDocument>>(() => null);
    //        /*data = GetData();
    //        foreach (var var in data)
    //        {

    //        }
    //        Console.ReadLine();*/
    //        var measurements = collection
    //            .Find(d => d.user == "Tomas")
    //            .ToListAsync()
    //            .Result;

    //        Console.WriteLine("All measurements");
    //        foreach (var data in measurements)
    //        {
    //            foreach (var var in data.data)
    //            {
    //                Console.WriteLine("x:{0}", var.x);
    //                Console.WriteLine("y:{0}", var.y);
    //                Console.WriteLine("z:{0}", var.z);
    //                Console.WriteLine("mx:{0}", var.mx);
    //                Console.WriteLine("my:{0}", var.my);
    //                Console.WriteLine("mz:{0}", var.mz);
    //            }
    //            Console.WriteLine("duration {0}", data.duration);
    //            Console.WriteLine("weight {0}", data.weight);
    //        }
    //    }

    //    static async Task MainAsync()
    //    {
    //        await collection.InsertOneAsync(CreateNewMeasurement());
    //    }

    //    static async Task<BsonDocument> GetData()
    //    {
    //        //READ  
    //        var resultDoc = collection.Find(new BsonDocument()).ToList();
    //        foreach (var item in resultDoc)
    //        {
    //            Console.WriteLine(item.ToString());
    //        }
    //        var filter = "{ date: '23.10.2018 19:50'}";
    //        BsonDocument data = new BsonDocument();
    //        await collection.Find(filter)
    //            .ForEachAsync(document => Console.WriteLine(data));
    //        return data;
    //    }




    //    private static Shot CreateNewMeasurement()
    //    {
    //        var Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();


    //        Sensor sensor = new Sensor
    //        {
    //            x = 100,
    //            y = 200,
    //            z = 300,
    //            mx = 10,
    //            my = 20,
    //            mz = 30,
    //            ts = 123.45
    //        };

    //        var shot = new Shot
    //        {
    //            data = new Sensor[] {sensor, sensor},
    //            date = Timestamp,
    //            duration = 25,
    //            user = "Tomas",
    //            weight = 60,
    //            Id = 2
    //        };

    //        return shot;
    //    }



    //    public class Counter
    //    {
    //        public string Id { get; set; }
    //        public int Value { get; set; }
    //    }


    //    public class Shot
    //    {
    //        public int shot_id { get; set; }
    //        public int Id { get; set; }
    //        public Sensor[] data { get; set; }
    //        public long date { get; set; }
    //        public string user { get; set; }
    //        public int weight { get; set; }
    //        public int duration { get; set; }
    //    }

    //    public class Sensor
    //    {
    //        public int x { get; set; }
    //        public int y { get; set; }
    //        public int z { get; set; }
    //        public int mx { get; set; }
    //        public int my { get; set; }
    //        public int mz { get; set; }
    //        public double ts { get; set; }
    //    }

    //    public class Exercise
    //    {

    //    }
    //}
}
