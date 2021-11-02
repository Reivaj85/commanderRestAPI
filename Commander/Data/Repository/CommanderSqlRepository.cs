using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data.Repository {
    internal class CommanderSqlRepository : ICommanderRepository {
        private readonly CommanderContext _contex;

        public CommanderSqlRepository(CommanderContext context) {
            _contex = context;
        }
        
        public async Task<IEnumerable<Command>> GetAll() {
            return await _contex.Commands.ToListAsync();
        }

        public async Task<Command> GetById(short id) {
            return await _contex.Commands.FindAsync(id);
        }

        public async Task<IEnumerable<Command>> GetByHowToContainsWord(string wordContains) {
            return await _contex.Commands.Where(command => command.HowTo.ToUpper().Contains(wordContains.ToUpper()))
                .ToListAsync();
        }
    }
}
