using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public float totalTime = 0;
    public float finishTime = 0;
    public Text text = null;

    private float second = 0;
    private float millisec = 0;
    

    public PlayerMovement movement = null;
    public EndTrigger endTrigger = null;
    public GameManager gameManager = null;



    // Update is called once per frame
    void Update()
    {
        if (totalTime >= 0)
        {
            if (endTrigger.isFinish)
            {
                Debug.Log(finishTime);
                finishTime = totalTime;
                movement.enabled = false;
                
            }
            else
            {
                totalTime -= Time.deltaTime;
                second = (int)(totalTime % 60);

                millisec = (int)(totalTime * 1000) % 1000;

                text.text = second.ToString("00");

                if (totalTime <= 0)
                {
                    movement.enabled = false;

                    gameManager.gameOver.SetActive(true);
                }
            }
            
        }
        
    }
}
