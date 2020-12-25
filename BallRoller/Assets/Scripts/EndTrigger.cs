using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public bool isFinish = false;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        isFinish = true;
        
       
    }
}
