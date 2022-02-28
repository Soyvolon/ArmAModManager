using ArmAModManager.Core.Structures.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmAModManager.Services;

public class ProfileService : IProfileService
{
    public Task CreateProfileAsync(Profile data)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProfileAsync(string name)
    {
        throw new NotImplementedException();
    }

    public Task<List<Profile>> GetProfileList(string rootFolder)
    {
        throw new NotImplementedException();
    }

    public Task UpdateProfileAsync(string name, Profile data)
    {
        throw new NotImplementedException();
    }
}
