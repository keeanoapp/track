using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using Navtrack.Api.Services.User;
using Navtrack.DataAccess.Model.Assets;
using Navtrack.DataAccess.Model.Users;
using Navtrack.Shared.Library.DI;

namespace Navtrack.Api.Services.Assets;

[Service(typeof(IAssetAuthorizationService))]
public class AssetAuthorizationService(ICurrentUserAccessor userAccessor) : IAssetAuthorizationService
{
    public async Task<bool> CurrentUserHasRole(AssetRoleType assetRoleType, string assetId)
    {
        UserDocument currentUser = await userAccessor.Get();

        AssetRoleType[] validRoles = assetRoleType == AssetRoleType.Viewer
            ? new[] { AssetRoleType.Owner, AssetRoleType.Viewer }
            : new[] { assetRoleType };

        bool hasRole =
            (currentUser.AssetRoles?.Any(x => x.AssetId == ObjectId.Parse(assetId) && validRoles.Contains(x.Role)))
            .GetValueOrDefault();

        return hasRole;
    }
}