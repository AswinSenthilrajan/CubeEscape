using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ 
    bool isGameOver = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void EndGame() 
    {
        if (isGameOver == false)
        {
            Debug.Log("Game Over");
            isGameOver = true;
            Invoke("RestartGame", restartDelay);
        }
    }

    void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel() 
    {
        //Klasse EndTrigger --> Bei Kollision EndBildschirm starten
        completeLevelUI.SetActive(true);
    }
}
