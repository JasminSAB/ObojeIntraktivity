namespace Shared;

public interface IStringListService
{
    Task<List<string>> GetStringList();
}