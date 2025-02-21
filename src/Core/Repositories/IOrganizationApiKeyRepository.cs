﻿using Bit.Core.Entities;
using Bit.Core.Enums;

namespace Bit.Core.Repositories
{
    public interface IOrganizationApiKeyRepository : IRepository<OrganizationApiKey, Guid>
    {
        Task<IEnumerable<OrganizationApiKey>> GetManyByOrganizationIdTypeAsync(Guid organizationId, OrganizationApiKeyType? type = null);
    }
}
