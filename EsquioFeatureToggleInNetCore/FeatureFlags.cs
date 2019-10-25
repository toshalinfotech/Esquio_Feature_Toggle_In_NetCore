using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsquioFeatureToggleInNetCore
{
    public class FeatureFlags
    {
        public const string SeeDetails = nameof(SeeDetails);

        public const string SeeHostDetails = nameof(SeeHostDetails);

        public const string SeeAdminDetails = nameof(SeeAdminDetails);
    }
}
