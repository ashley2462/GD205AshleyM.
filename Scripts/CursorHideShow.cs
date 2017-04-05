using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHideShow : MonoBehaviour {
    bool CursorLockedVar;

    // Use this for initialization
    void Start()
    {
        CursorLockedVar = (true);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = (false);
    }
    
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("escape")&& !CursorLockedVar)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = (false);
            CursorLockedVar = (true);
        }
        else if (Input.GetKeyDown("escape") && !CursorLockedVar)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = (true);
            CursorLockedVar = (false);
        }
    }
}
