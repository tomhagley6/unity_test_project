using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void GameOver() 
    {
        
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game over.");
            Invoke("Restart", restartDelay);
        }
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
