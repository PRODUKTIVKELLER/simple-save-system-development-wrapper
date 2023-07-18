using Produktivkeller.SimpleSaveSystem.Core.SaveGameData;
using Produktivkeller.SimpleSaveSystem.Migration;
using UnityEngine;

[CreateAssetMenu(fileName = "MigrationToCheckDate",
    menuName = "PRODUKTIVKELLER/Simple Save System/MigrationToCheckDate")]
public class MigrationToCheckDate : Migration
{
    private string[] testSaveableIDs = {
        "Test-Saveable-Prefab-TestSaveable-12345",
        "Test-Saveable-Prefab_2-TestSaveable-12345",
        "TEstSaveable2-TestSaveableComponent"
    };

    public override SaveGame Migrate(SaveGame saveGame)
    {
        for (int i = 0; i < testSaveableIDs.Length; i++)
        {
            string data = saveGame.Get(testSaveableIDs[i]);
            data = data.Replace("Other", "Different");
            saveGame.Set(testSaveableIDs[i], data);
        }

        return saveGame;
    }
}