using System.Collections.Generic;
using System.Threading.Tasks;
using Commander.Models;

namespace Commander.Data.Repository {
    public interface ICommanderRepository {
        Task<IEnumerable<Command>> GetAll();
        Task<Command> GetById(short id);
        Task<IEnumerable<Command>> GetByHowToContainsWord(string wordContains);
    }
}
