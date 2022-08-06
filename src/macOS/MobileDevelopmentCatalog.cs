using Cupboard;
using macOS.Manifests;

public class MobileDevelopmentCatalog : MacOsCatalog
{
    public override void Execute(CatalogContext context)
    {
        context.UseManifest<Homebrew>();
        context.UseManifest<BrewCasks>();
        context.UseManifest<BrewPackages>();
    }
}