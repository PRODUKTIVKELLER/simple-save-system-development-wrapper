using Produktivkeller.SimpleSaveSystem.Core.SaveGameData;
using Produktivkeller.SimpleSaveSystem.Migration;
using UnityEngine;

namespace Migrations
{
    [CreateAssetMenu(fileName = "MigrationMultipleNewFields",
        menuName = "PRODUKTIVKELLER/Simple Save System/MigrationMultipleNewFields")]
    public class MigrationMultipleNewFields : Migration
    {
        public override SaveGame Migrate(SaveGame saveGame)
        {
            // Rename of prefab_2
            string dataOfPrefab2 = saveGame.Get("Test-Saveable-Prefab_2-TestSaveable-12345");
            saveGame.Set("Test-Saveable-Prefab_3-TestSaveable-12345", dataOfPrefab2);

            saveGame.Set(string.Format("BVar-{0}", "has-game-been-loaded-once"), true.ToString());
            saveGame.Set(string.Format("IVar-{0}", "deaths-amount"), ((int)0).ToString());

            return saveGame;
        }
    }
}