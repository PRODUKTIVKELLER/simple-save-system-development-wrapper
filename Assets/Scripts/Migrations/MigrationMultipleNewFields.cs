using Produktivkeller.SimpleSaveSystem.ComponentSaveSystem.Data;
using Produktivkeller.SimpleSaveSystem.Migration;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MigrationMultipleNewFields", menuName = "PRODUKTIVKELLER/Simple Save System/MigrationMultipleNewFields")]
public class MigrationMultipleNewFields : Migration
{
    private string[] testSaveableIDs = new string[]
    {
        "Test-Saveable-Prefab-TestSaveable-12345",
        "Test-Saveable-Prefab_2-TestSaveable-12345",
        "TEstSaveable2-TestSaveableComponent"
    };

    public override SaveGame Migrate(SaveGame saveGame)
    {
        // Rename of prefab_2
        string dataOfPrefab2 = saveGame.Get("Test-Saveable-Prefab_2-TestSaveable-12345");
        saveGame.Set("Test-Saveable-Prefab_3-TestSaveable-12345", dataOfPrefab2, "Global");

        saveGame.Set(string.Format("BVar-{0}", "has-game-been-loaded-once"), true.ToString(), "Global");
        saveGame.Set(string.Format("IVar-{0}", "deaths-amount"), ((int)0).ToString(), "Global");

        return saveGame;
    }
}
