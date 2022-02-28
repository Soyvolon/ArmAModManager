using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmAModManager.Core.Structures.Manifest;

public class Manifest
{
    public string Name { get; set; }
    public int Nodes { get; set; } = 0;

    public List<ManifestNode> ModlistNodes { get; set; } = new();
    public List<ManifestNode> WhitelistNodes { get; set; } = new();
}
