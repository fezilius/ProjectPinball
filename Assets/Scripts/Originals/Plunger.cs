using UnityEngine;

public class Plunger : MonoBehaviour
{
    [SerializeField] private float ballSpeed;
    [SerializeField] private GameObject ballPrefab;

 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();
        }
    }

    void FireCannon()
    {
        GameObject ballSpawnPoint = GameObject.Find("BallSpawnPoint");
        GameObject ball = Instantiate(ballPrefab, ballSpawnPoint.transform.position, ballSpawnPoint.transform.rotation);
        ball.transform.GetComponent<Rigidbody>().linearVelocity = ballSpawnPoint.transform.forward * ballSpeed;
    }
}
