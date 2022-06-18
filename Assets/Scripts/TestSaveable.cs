using Produktivkeller.SimpleSaveSystem.ComponentSaveSystem.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
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

    public string OnSave()
    {
        return DateTime.Now.ToLongTimeString() + " Other Version";
    }

    public bool OnSaveCondition()
    {
        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
