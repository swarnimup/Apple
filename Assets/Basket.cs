using UnityEngine;
using UnityEngine.SceneManagement; // For loading the game over scene

public class Basket : MonoBehaviour
{
    public ScoreCounter scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreCounter = scoreGO.GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos2d = Input.mousePosition;
        mousePos2d.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2d);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.CompareTag("Apple"))
        {
            Destroy(collidedWith);
            scoreCounter.score += 100;
            HighScore.TRY_SET_HIGH_SCORE(scoreCounter.score);
        }
        else if (collidedWith.CompareTag("Branch")) // For branches that cause game over
        {
            // Call the GameOver function when a branch is caught
            GameOver();
        }
    }

    // Define the GameOver method
    void GameOver()
    {
        // Show game over message or reset the game
        Debug.Log("Game Over!");

        // Optionally, reload the scene or transition to a game over screen
        SceneManager.LoadScene("GameOverScene"); // Replace with actual game over scene name or restart the game
    }
}
