using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleUse : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(ManagerController.instance.GetType<PlayersManager>(typeof(PlayersManager)).PlayersOnline);
    }
	
}
