using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageNumber : MonoBehaviour {
    static int number;

    void Start()
    {
        number = 1;
    }

    public void InputStageNum(int data)
    {
        number = data;
    }

    public void NextStageNum()
    {
        number++;
    }

    public int GetStageNumber()
    {
        return number;
    }
}
