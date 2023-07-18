using System;
using Produktivkeller.SimpleSaveSystem.Core;
using UnityEngine;

public class TestSaveable : MonoBehaviour, ISaveable
{
    public string loadedData;

    public void OnLoad(string data)
    {
        Debug.Log("I loaded: " + data);
        if (data.Contains("Other Version") == false)
        {
            Debug.LogError("Data did not contain \"Other Version\"");
        }

        loadedData = data;
    }

    public void OnNoDataToLoad()
    {
        throw new NotImplementedException();
    }

    public bool ShouldBeSaved()
    {
        throw new NotImplementedException();
    }

    public string OnSave()
    {
        return DateTime.Now.ToLongTimeString() + " Other Version";
    }

    public bool OnSaveCondition()
    {
        return true;
    }
}