using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_BattleManager : MonoBehaviour
 {

    public Script_GameManager GameManager;


    void Start () 
	    {

	
	
	    }
	
	
	
    void Update () 
	    {
		
	
	
	    }

   public void CombatEnd()
    {
        GameManager.SwitchToOverworld();
    }


}
