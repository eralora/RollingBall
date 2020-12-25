using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float time;

    public PlayerData(CountdownController countdownController)
    {
        time = countdownController.finishTime;

    }
}


