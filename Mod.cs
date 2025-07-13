using Game;
using Game.Modding;
using Game.SceneFlow;
using System.IO;

namespace AirportNext
{
    public class Mod : IMod
    {
        private string pathToModFolder;

        public void OnLoad(UpdateSystem updateSystem)
        {
            if (!GameManager.instance.modManager.TryGetExecutableAsset(this, out var asset)) return;

            pathToModFolder = $"{new FileInfo(asset.path).DirectoryName}";

            ExtraAssetsImporter.EAI.LoadCustomAssets(pathToModFolder);

        }

        public void OnDispose()
        {
        }
    }
}
