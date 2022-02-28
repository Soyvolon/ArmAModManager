using ArmAModManager.Core.Structures.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmAModManager.Services;

public interface IProfileService
{
    public Task CreateProfileAsync(Profile data);
    public Task DeleteProfileAsync(string name);
    public Task UpdateProfileAsync(string name, Profile data);
    public Task<List<Profile>> GetProfileList(string rootFolder);
}
