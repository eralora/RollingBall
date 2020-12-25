
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public GameObject highUI;
    public GameObject currentUI;
    public GameObject gameOver;
 
    
    public float time;
    public void CompleteLevel() 
    {
        
        highUI.SetActive(true);
        currentUI.SetActive(true);
        completeLevelUI.SetActive(true);

    }
    public void EndGame()
    
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");
            gameOver.SetActive(true);
        }
        
    }


    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
