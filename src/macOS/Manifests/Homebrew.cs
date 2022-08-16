using Cupboard;
using Spectre.IO;

namespace macOS.Manifests;

public class Homebrew : Manifest
{
    public override void Execute(ManifestContext context)
    {
        if (!context.Facts.IsMacOS())
        {
            return;
        }

        var directoryPath = new FilePath(AppDomain.CurrentDomain.BaseDirectory + "install-brew.sh");
        context
            .Resource<Download>("Download Homebrew")
            .FromUrl("https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh")
            .Permissions(Chmod.Parse("755"))
            .ToFile(directoryPath);

        context.Resource<BashScript>("Install Homebrew")
            .Script(directoryPath)
            .After<Download>("Download Homebrew");
    }
}