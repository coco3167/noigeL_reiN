using System;
using System.Collections;
using System.Collections.Generic;
using Options;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    private TextAsset jsonFileTest;
    [SerializeField]
    private TextAsset[] jsonRoom;

    //Options.Room testRoom = new Room();
    private Room Room1 = new Room();

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
        /*testRoom = JsonUtility.FromJson<Options.Room>(jsonFileTest.text);
        foreach (Option option in testRoom.Options)
        {
            Debug.Log(option.Name);
            Debug.Log(option.OptionTextDescription);
            Debug.Log(option.ParentOption);
            Debug.Log("====================================");
        }
        Debug.Log(testRoom.Options.Count);*/
        
        //Room 1
        Room1 = JsonUtility.FromJson<Room>(jsonRoom[0].text);

        Debug.Log(Room1.Options[0].FindOption("Ouvrir la porte").OptionTextDescription);
        
        SetLogic();

        Debug.Log(Room1.Options[0].FindOption("Ouvrir la porte").OptionTextDescription);
    }

    public void SetLogic()
    {
        Options.Option Key = Room1.Options[0].FindOption("Récupérer la clé");
        List<Options.Option> Doors = new List<Option>(){Room1.Options[0].FindOption("Ouvrir la porte"), Room1.Options[0].FindOption("Ouvrir la porte", true)};
        Key.UnblockOptions.AddRange(Doors);
        Key.Selected();
    }
}
