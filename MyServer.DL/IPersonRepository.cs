using MyServer.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyServer.DL
{
    public interface IPersonRepository
    {
        async Task Add(Person p)
        {
            var result = 
        }
        async Task GetAll()
        {

        }

        async Task<IEnumerable<Person>> GetAllByDate(DateTime lastAdded)
        {

        }
    }
}
