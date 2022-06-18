using Produktivkeller.SimpleSaveSystem.ComponentSaveSystem.Data;
using Produktivkeller.SimpleSaveSystem.Migration;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MigrationToCheckDate", menuName = "PRODUKTIVKELLER/Simple Save System/MigrationToCheckDate")]
public class MigrationToCheckDate : Migration
{
    private string[] testSaveableIDs = new string[]
    {
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
            saveGame.Set(testSaveableIDs[i], data, "Global");
        }

        return saveGame;
    }
}
