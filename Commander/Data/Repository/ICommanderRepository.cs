using System.Collections.Generic;
using System.Threading.Tasks;
using Commander.Models;

namespace Commander.Data.Repository {
    public interface ICommanderRepository {
        Task<Command> AddAsync(Command command);
        Task<IReadOnlyCollection<Command>> GetAllAsync();
        Task<Command> GetByIdAsync(short id);
        Task<IReadOnlyCollection<Command>> GetByHowToContainsWordAsync(string wordContains);
    }
}
