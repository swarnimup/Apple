using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Method to restart the game
    public void RestartGame()
    {
        // Load the currently active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
