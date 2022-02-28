using ArmAModManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmAModManager;
public partial class ClientMain : Form
{
    private readonly IManifestService _manifestService;
    private readonly IProfileService _profileService;

    public ClientMain(IManifestService manifestService, IProfileService profileService)
    {
        _manifestService = manifestService;
        _profileService = profileService;

        InitializeComponent();
    }

    private async void CreateProfile_Click(object sender, EventArgs e)
    {

    }

    private async void SyncAllMods_Click(object sender, EventArgs e)
    {


        var remoteManifest = await _manifestService.GetManifestFromRemoteAsync(new()
        {
            Server = syncServer.Text,
            Port = (int)syncPort.Value,
            Username = syncUsername.Text,
            Password = syncPassword.Text,
        });
    }
}
