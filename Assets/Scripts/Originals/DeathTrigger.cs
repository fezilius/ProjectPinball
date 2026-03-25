using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    // Reference to your GameManager in the scene
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering is the ball
        if (other.CompareTag("Ball"))
        {
            // Destroy the ball so it disappears
            Destroy(other.gameObject);

            // Tell the GameManager the ball is lost
            gameManager.BallLost();       
        }
    }
}
