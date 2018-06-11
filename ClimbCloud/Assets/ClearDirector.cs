using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour {
    int stage = 1;

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if (stage == 1)
            {
                SceneManager.LoadScene("GameScene2");
                stage++;
            }
            else
            {
                SceneManager.LoadScene("GameScene1");
                stage = 1;
            }
        }
	}
}
