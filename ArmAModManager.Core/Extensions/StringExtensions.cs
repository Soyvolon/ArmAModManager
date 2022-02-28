using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArmAModManager.Core.Extensions;

public static class StringExtensions
{
    public static async Task<string> GetChecksumAsync(this string filePath)
    {
        using var md5 = MD5.Create();
        await using var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        var hash = await md5.ComputeHashAsync(fs);
        return BitConverter.ToString(hash).Replace("-", "").ToLower();
    }
}
