using Produktivkeller.SimpleSaveSystem.ComponentSaveSystem.Data;
using Produktivkeller.SimpleSaveSystem.Migration;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MigrationAddedOneComponent", menuName = "PRODUKTIVKELLER/Simple Save System/MigrationAddedOneComponent")]
public class MigrationAddedOneComponent : Migration
{
    public override SaveGame Migrate(SaveGame saveGame)
    {
        string data = saveGame.Get("Test-Saveable-Prefab_3-TestSaveable-12345");
        saveGame.Set("Test-Saveable-Prefab_3-TestSaveable-123456", data);

        return saveGame;
    }
}
