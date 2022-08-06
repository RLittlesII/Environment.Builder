using Cupboard;

namespace macOS.Manifests;

public class BrewPackages : PackageManifest
{
    public BrewPackages() : base(new[]
    {
        "gh",
        "git",
        "git-flow",
        "git-lfs",
        "git-ssh",
        "gitversion",
        "nodejs",
        "fastlane",
        "pandoc",
        "zsh",
        "zsh-git-prompt",
    })
    {
    }
    protected override void ExecuteResource(ManifestContext context, string package)
    {
        context
            .Resource<HomebrewPackage>(package)
            .Ensure(PackageState.Installed)
            .After<BashScript>("Install Homebrew");
    }
}