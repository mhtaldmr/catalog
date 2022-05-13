
using System.Threading.Tasks;

namespace Vega.Core.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }

}