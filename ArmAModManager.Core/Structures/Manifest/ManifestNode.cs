using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmAModManager.Core.Structures.Manifest;

public class ManifestNode
{
    public string Path { get; set; }
    public string? Checksum { get; set; }
    public bool Folder { get; set; } = false;
    public List<ManifestNode>? ChildNodes { get; set; } = null;
}
