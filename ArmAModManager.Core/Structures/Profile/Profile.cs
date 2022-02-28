using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmAModManager.Core.Structures.Profile;

public class Profile
{
    public string Name { get; set; }
    public string ManifestPath { get; set; }
    public List<string> EnabledWhitelist { get; set; } = new();
    public string CustomLaunchArguments { get; set; } = "";
    public bool SyncOnLaunch { get; set; } = true;

    public string Server { get; set; }
    public int Port { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}
