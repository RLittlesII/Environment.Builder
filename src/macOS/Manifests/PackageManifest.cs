using Cupboard;

namespace macOS.Manifests;

public abstract class PackageManifest : Manifest
{
    protected PackageManifest(IEnumerable<string> packages)
    {
        Packages = packages.ToList();
    }

    public sealed override void Execute(ManifestContext context)
    {
        foreach (var package in Packages)
        {
            ExecuteResource(context, package);
        }
    }

    protected virtual void ExecuteResource(ManifestContext context, string package)
    {
        context
            .Resource<HomebrewPackage>(package)
            .Ensure(PackageState.Installed)
            .After<BashScript>("Install Homebrew");
    }

    protected readonly IReadOnlyCollection<string> Packages;
}