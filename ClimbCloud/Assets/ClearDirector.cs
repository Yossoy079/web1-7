using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour {
    StageNumber stage = new StageNumber();

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if (stage.GetStageNumber() == 1)
            {
                SceneManager.LoadScene("GameScene2");
                stage.NextStageNum();
            }
            else
            {
                SceneManager.LoadScene("GameScene1");
                stage.InputStageNum(1);
            }
        }
	}

}
