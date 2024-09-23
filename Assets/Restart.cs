using UnityEngine;
using UnityEngine.SceneManagement; // Ensure this namespace is added

public class Restart : MonoBehaviour // Class definition
{
    // Method to restart the game
    public void RestartGame() // This must be inside a class
    {
        // Load the currently active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
