using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NuGet.ProjectModel;

namespace NuGet.Commands
{
    public static class RequestRuntimeUtility
    {
        /// <summary>
        /// Combines the project runtimes with the request.RequestedRuntimes.
        /// If those are both empty FallbackRuntimes is returned.
        /// </summary>
        internal static ISet<string> GetRestoreRuntimes(RestoreRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            var runtimes = new SortedSet<string>(StringComparer.Ordinal);

            runtimes.UnionWith(request.Project.RuntimeGraph.Runtimes.Keys);
            runtimes.UnionWith(request.RequestedRuntimes);

            if (runtimes.Count < 1)
            {
                runtimes.UnionWith(request.FallbackRuntimes);
            }

            return runtimes;
        }
    }
}
