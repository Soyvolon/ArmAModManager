using ArmAModManager.Core.Structures.Manifest;
using ArmAModManager.Core.Structures.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmAModManager.Services;

public interface IManifestService
{
    public Task<Manifest> GetManifestFromRemoteAsync(Profile remote);
    public Task<List<string>> GetFilesToUpdate(Profile profile, Manifest? local, Manifest remote);
    public Task<List<string>> GetFilesToRemove(Profile profile, Manifest local, Manifest remote);
}
