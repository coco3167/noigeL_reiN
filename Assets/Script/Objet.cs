using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class Objet
{
    public List<Objet> insideObjets = new List<Objet>();
    public Objet parentObj;

    public List<Option> Options = new List<Option>();
    
    public string name;
    public bool isGettable;
    public bool hidden = false;

    public Objet(string name, bool isGettable = false, Objet parentObj = null)
    {
        this.name = name;
        this.isGettable = isGettable;
        this.parentObj = parentObj;
    }

    public void AddObjet(string name, bool isGettable = false)
    {
        insideObjets.Add(new Objet(name, isGettable, this));
    }

    public void AddOption(string ActionName, string ActionDescription, bool insideGettable = false, bool hidden = false)
    {
        Options.Add(new Option(this, ActionName, ActionDescription, hidden, insideGettable));
    }

    public void SetRetour()
    {
        Game.optionsTexts[Option.index].text = "Retour";
        Game.Options[Option.index].onClick.RemoveAllListeners();
        Game.Options[Option.index].onClick.AddListener(Retour);
    }

    private void Retour()
    {
        if (parentObj == null)
            return;
        Player.currentPosition = parentObj;
        Game.AreOptionsSet = false;

    }
}
