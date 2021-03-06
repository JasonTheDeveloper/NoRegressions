using System.Threading.Tasks;
using cli.Verbs.Dataset;

namespace cli.Contract
{
    public interface IReadDatasetHandler
    {
        Task Handle(ReadDatasetVerb verb);
    }
}