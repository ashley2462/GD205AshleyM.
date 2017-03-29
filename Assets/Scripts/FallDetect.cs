using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetect : MonoBehaviour {
  GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.y <= -10)
        {
            player.transform.position = new Vector3(0, 10, 0);
        }
	}
}
