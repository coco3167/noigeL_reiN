using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private void Start()
    {
        //test
        Options.Option optionChild = new Options.Option("optionChild", "des trucs enfants", null);
        Options.Option optionParent = new Options.Option("optionParent", "des trucs parents", new List<Options.Option>{optionChild});
        Debug.Log("oui");
    }
}
