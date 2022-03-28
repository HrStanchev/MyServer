using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MyServer.Models;

namespace MyServer.DL
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IMongoCollection<Person> _collection;

        public PersonRepository(IOptions<MongoDbConfiguration> mongoOptions)
        {
            var client = new MongoClient(mongoOptions.Value.ConnectionString);
            var database = client.GetDatabase(mongoOptions.Value.DatabaseName);

            _collection = database.GetCollection<Person>("Persons");
        }

        public async Task Add(Person p)
        {
            await _collection.InsertOneAsync(p);
        }
        public async Task <IEnumerable<Person>> GetAll()
        {
            var result = await _collection.FindAsync(p => true);

            return result.ToList();
        }

        public async Task<IEnumerable<Person>> GetAllByDate(DateTime lastAdded)
        {
            var result = await _collection.FindAsync(p=>p.LastUpdated >= lastAdded);

            return result.ToList();
        }
    }
}
