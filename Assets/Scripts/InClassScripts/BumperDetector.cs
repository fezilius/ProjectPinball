using UnityEngine;

public class BumperDetector : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private int bumperPoints = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManagerTag").GetComponent<ScoreManager>();
    }

    // Checks for ball hitting collider
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ball")
        {
            Debug.Log("ble truffet av ball!");
            scoreManager.AddScore(bumperPoints);
        }
    }
}
