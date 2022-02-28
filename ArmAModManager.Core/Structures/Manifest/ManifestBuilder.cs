using ArmAModManager.Core.Extensions;

namespace ArmAModManager.Core.Structures.Manifest;

public class ManifestBuilder
{
    public string RootFolder { get; set; }
    public string? WhitelistFolder { get; set; }
    public string Name { get; set; } = "";

    public ManifestBuilder(string root)
    {
        RootFolder = root;
    }

    public ManifestBuilder WithName(string name)
    {
        Name = name;
        return this;
    }

    public ManifestBuilder WithWhitelist(string whitelistPath)
    {
        WhitelistFolder = whitelistPath;
        return this;
    }

    public async Task<Manifest> BuildAsync()
    {
        var manifest = new Manifest()
        {
            Name = Name,
        };

        Stack<string> folders = new();
        folders.Push(RootFolder);

        Stack<ManifestNode> prevNodes = new();
        var topnode = new ManifestNode();
        prevNodes.Push(topnode);

        while(folders.TryPop(out var folder))
        {
            var files = Directory.GetFileSystemEntries(folder);

            if (files.Length > 0 
                && prevNodes.TryPop(out var lastNode))
            {
                if (lastNode.ChildNodes is null)
                    lastNode.ChildNodes = new();

                foreach (var file in files)
                {
                    if (Directory.Exists(file))
                    {
                        var node = new ManifestNode()
                        {
                            Path = file,
                            Folder = true,
                            ChildNodes = new()
                        };

                        prevNodes.Push(node);
                        lastNode.ChildNodes.Add(node);
                    }
                    else
                    {
                        var checksum = await file.GetChecksumAsync();

                        lastNode.ChildNodes.Add(new()
                        {
                            Checksum = checksum,
                            Path = file
                        });
                    }
                }
            }
            else
            {
                throw new ManifestException("No child node was registered for the next directory.");
            }
        }

        if(topnode.ChildNodes is not null)
            manifest.ModlistNodes = topnode.ChildNodes;

        if(!string.IsNullOrWhiteSpace(WhitelistFolder))
        {
            ManifestBuilder builder = new(WhitelistFolder);
            var res = await builder.BuildAsync();
            manifest.WhitelistNodes = res.ModlistNodes;
        }

        return manifest;
    }
}

public class ManifestException : Exception
{
    public ManifestException() : base() { }
    public ManifestException(string message) : base(message) { }
}
