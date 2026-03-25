using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public float launchForce = 500f; //How strong to launch the ball
    private Rigidbody ballRb;
    private bool shouldLaunch = false;
    private float minLaunchSpeed = 0.1f;

    void Start()
    {
        //Find the ball in the scene (make sure it’s tagged "Ball")
        //This only works once, at the start of the scene. Else you have to find the ball again after spawning it.
        ballRb = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>();
    }

    void Update()
    {
        //When you press space, launch the ball
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shouldLaunch = true;
        }
    }

    private void FixedUpdate()
    {
        //If there is no rigidbody, don't do any of the physics.
        if (ballRb == null)
            return;

        //Prevent adding force if it is already moving
        //Can also wait for a signal from the GameManager
        if (ballRb.linearVelocity.magnitude > minLaunchSpeed)
        {
            return;
        }

        if(shouldLaunch == true)
        {
            LaunchBall();
            shouldLaunch = false;
        }
    }

    //Call this after spawning the ball. From the GameManager f.x.
    public void SetBall(GameObject ball)
    {
        ballRb = ball.GetComponent<Rigidbody>();
    }

    void LaunchBall()
    {
        
        //Ensure consistent launch behavior
        ballRb.linearVelocity = Vector3.zero;
        ballRb.angularVelocity = Vector3.zero;

        //Add a push forward (along Z axis)
        ballRb.AddForce(Vector3.forward * launchForce);
        
    }
}
