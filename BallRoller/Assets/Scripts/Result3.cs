using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result3 : MonoBehaviour
{

    
    public Text textHigh;
    public Text textCurrent;
    public EndTrigger endTrigger;
    public CountdownController countdownController;
    float time = 0;

    private void Update()
    {
        try
        {
            if (endTrigger.isFinish)
            {

                LoadPlayer();

                if (time < countdownController.finishTime)
                {
                    SavePlayer();
                    LoadPlayer();
                    textHigh.text = time.ToString(".000");
                    textCurrent.text = countdownController.finishTime.ToString(".000");
                }
                else
                {
                    textHigh.text = time.ToString(".00");
                    textCurrent.text = countdownController.finishTime.ToString(".000");
                }



            }
        }

        catch
        {
            SavePlayer();
            LoadPlayer();

            if (time < countdownController.finishTime)
            {
                SavePlayer();
                LoadPlayer();
                textHigh.text = time.ToString(".000");
                textCurrent.text = countdownController.finishTime.ToString(".000");
            }
            else
            {
                textHigh.text = time.ToString(".00");
                textCurrent.text = countdownController.finishTime.ToString(".000");
            }
        }
    }

    public void SavePlayer()
    {
        SystemSave3.SavePlayer(countdownController);
    }


    public void LoadPlayer()
    {
        PlayerData data = SystemSave3.LoadPlayer();

        //Debug.Log("This is saved time:" + data.time);

        time = data.time;
        //Debug.Log("this is assigned time" + time);
    }


}
