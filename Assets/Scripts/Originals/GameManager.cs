using UnityEngine;
using UnityEngine.SceneManagement; // Needed for reloading scenes
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int ballsLeft = 3; // How many balls you start with
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private Transform spawnPoint;

    [SerializeField] private TMP_Text ballCountText;
    [SerializeField] private GameObject gameOverScreen;

    private void Start()
    {
        ballCountText.text = ballsLeft.ToString();
        Debug.Log("ballsleft: " + ballsLeft);
    }

    public void BallLost()
    {
        ballsLeft--;
        ballCountText.text = ballsLeft.ToString();

        if (ballsLeft > 0)
        {
            // Spawn a new ball
            //Instantiate(ballPrefab, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            // No balls left — show game over screen
            gameOverScreen.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
