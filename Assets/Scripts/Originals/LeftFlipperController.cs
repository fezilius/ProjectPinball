using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftFlipperController : MonoBehaviour {

    public float restPosition_F = 0f;
    public float pressedPosition_F = 45f;
    public float hitStrength_F = 100000f;
    public float flipperDamper_F = 150f;

    private HingeJoint hinge_HJ;


	// Use this for initialization
	void Start ()
    {
        //Get the HingeJoint component of our hinge gameObject and activate the spring on it.
        hinge_HJ = GetComponent<HingeJoint>();
        GetComponent<HingeJoint>().useSpring = true;		
	}
	
	// Update is called once per frame
	void Update ()
    {
        JointUpdate();
    }

    //Make a spring variable.
    //Adjust it with our values in our variables.
    //Store it into the spring of our hinge joint variable we created above, which is actually the hinge joint component on our hinge gameObject
    private void JointUpdate ()
    {
        JointSpring spring_JS = new JointSpring();
        spring_JS.spring = hitStrength_F;
        spring_JS.damper = flipperDamper_F;

        //Press either left arrow or A to move the flipper
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            spring_JS.targetPosition = pressedPosition_F;
        }
        else //Otherwise go to resting position
        {
            spring_JS.targetPosition = restPosition_F;
        }

        hinge_HJ.spring = spring_JS;
        hinge_HJ.useLimits = true;
    }
}
