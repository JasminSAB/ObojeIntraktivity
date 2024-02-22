using Shared;

namespace ObojeIntraktivity
{
    public class ServerStringListService : IStringListService
    {
        public Task<List<string>> GetStringList()
        {
            return Task.FromResult(new List<string>
            {
                "Ovo je",
                "dikretno iz server renderinga",
                "lista stringova.."
            });
        }
    }
}
