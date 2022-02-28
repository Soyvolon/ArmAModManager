using ArmAModManager.Core.Structures.Manifest;
using ArmAModManager.Core.Structures.Profile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArmAModManager.Services;

public class ManifestService : IManifestService
{
    public Task<List<string>> GetFilesToRemove(Profile profile, Manifest local, Manifest remote)
    {
        throw new NotImplementedException();
    }

    public Task<List<string>> GetFilesToUpdate(Profile profile, Manifest? local, Manifest remote)
    {
        throw new NotImplementedException();
    }

    public async Task<Manifest> GetManifestFromRemoteAsync(Profile profile)
    {
        var rootPath = $"ftp://{profile.Server}:{profile.Port}";
#pragma warning disable SYSLIB0014 // Web request is obsolete, not FtpWebRequest.
        FtpWebRequest? request = WebRequest.Create(rootPath + "/manifest.a3m3") as FtpWebRequest;
#pragma warning restore SYSLIB0014 // Type or member is obsolete

        if(request is not null)
        {
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.Credentials = new NetworkCredential(profile.Username, profile.Password);

            using FtpWebResponse? response = (await request.GetResponseAsync()) as FtpWebResponse;

            if (response is not null)
            {
                Stream rs = response.GetResponseStream();
                var manifest = await JsonSerializer.DeserializeAsync<Manifest>(rs);

                if (manifest is null)
                    throw new Exception("Failed to parse a manifest from the server.");

                return manifest;
            }

            throw new Exception("A proper response was unable to be parsed.");
        }

        throw new Exception("Failed to generate a valid request.");
    }
}
