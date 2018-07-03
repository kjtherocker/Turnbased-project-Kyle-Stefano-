using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Thief : Script_PartyMember
{

	// Use this for initialization
	void Start ()
    {
        CurrentHealth = 32;
        MaxHealth = 32;
        CurrentMana = 32;
        MaxMana = 43;
        Strength = 24;
        Magic = 32;
        Dexterity = 60;
        Speed = 90;
        Name = "Thiefboy";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
