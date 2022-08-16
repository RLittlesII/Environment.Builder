using Cupboard;

namespace macOS.Manifests;

public class BrewCasks : PackageManifest
{
    public BrewCasks() : base(new[]
    {
        "airserver",
        "balsamiq-wireframes",
        "basictex",
        "battle-net",
        "beyond-compare",
        "bitwarden",
        "bot-framework-emulator",
        "discord",
        "docker",
        "dotnet-sdk",
        "font-jetbrains-mono-nerd-font",
        "font-jetbrains-mono",
        "gitkraken",
        "gpg-suite",
        "keybase",
        "lastpass",
        "jetbrains-toolbox",
        "microsoft-azure-storage-explorer",
        "microsoft-edge",
        "microsoft-office",
        "mission-control-plus",
        "mongodb-compass",
        "monitorcontrol",
        "mono-mdk",
        "nteract",
        "obs",
        "onedrive",
        "pandora",
        "plex",
        "postgresql@9.5",
        "postman",
        "powershell",
        "pretzel",
        "signal",
        "slack",
        "sqlitestudio",
        "twitch",
        "visual-studio-code",
        "vysor",
        "wowup",
        "zeplin",
        "zoom"
    })
    {
    }

    protected override void ExecuteResource(ManifestContext context, string package)
    {
        context
            .Resource<HomebrewPackage>(package)
            .IsCask()
            .OnError(ErrorOptions.IgnoreErrors)
            .After<BashScript>("Install Homebrew");
    }
}