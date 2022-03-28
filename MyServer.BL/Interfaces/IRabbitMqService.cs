using MyServer.Models;
using System.Threading.Tasks;

namespace MyServer.BL.Interfaces
{
    public interface IRabbitMqService
    {
        Task PublishPersonAsync(Person p);
    }
}
