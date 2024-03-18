using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace AllAboutCatsApp.Data
{
    internal class DB
    {
        public static MongoClient GetClient()
        {
            string connectionString = "mongodb+srv://dwina83:dwina0707!@cluster0.9pgnac0.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";

            MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
            settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };

            var mongoClient = new MongoClient(settings);

            return mongoClient;
        }

        public static IMongoCollection<Models.CatsBreed2> BreedsCollection()
        {
            var client = GetClient();
            var database = client.GetDatabase("BreedData");
            var breedCollection = database.GetCollection<Models.CatsBreed2>("Breeds");
            return breedCollection;
        }

        public static IMongoCollection<Models.Users> UserCollection()
        {
            var client = GetClient();
            var database = client.GetDatabase("CatUserDb");
            var userCollection = database.GetCollection<Models.Users>("Users");
            return userCollection;
        }
        
       
    }
}
