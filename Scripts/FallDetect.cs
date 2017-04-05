using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetect : MonoBehaviour {
    Vector3 gameobjOrigin;
	// Use this for initialization
	void Start () {
        gameobjOrigin = gameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y <= -100)
        {
            gameObject.transform.position = gameobjOrigin;
        }
	}
}
