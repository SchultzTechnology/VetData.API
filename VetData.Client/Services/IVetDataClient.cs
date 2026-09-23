using VetData.Client.Models;
using VetData.Client.Models.SearchParams;

namespace VetData.Client.Services;

public interface IVetDataClient
{
    Task<IReadOnlyList<InstallationListRecord>> GetInstallationsAsync(
        CancellationToken cancellationToken = default);
        
    Task<IReadOnlyList<ClientRecord>> GetClientsAsync(
        Guid installationId,
        ClientSearchParams searchParams,
        CancellationToken cancellationToken = default);
}