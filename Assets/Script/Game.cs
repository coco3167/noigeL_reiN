using System;
using System.Collections;
using System.Collections.Generic;
using Options;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    private TextAsset jsonFile;

    Options.Room testRoom = new Room();

    private void Start()
    {
        //testMain
        //Options.Option optionChild = new Options.Option("optionChild", "des trucs enfants", null);
        //Options.Option optionParent = new Options.Option("optionParent", "des trucs parents", new List<Options.Option>{optionChild});

        //testJson
        ReadJson();
    }

    private void ReadJson()
    {
        //Test
        testRoom = JsonUtility.FromJson<Options.Room>(jsonFile.text);
        foreach (Option option in testRoom.Options)
        {
            Debug.Log(option.Name);
            Debug.Log(option.OptionTextDescription);
            Debug.Log(option.ParentOption);
            Debug.Log("====================================");
        }
        Debug.Log(testRoom.Options.Count);
    }
}
