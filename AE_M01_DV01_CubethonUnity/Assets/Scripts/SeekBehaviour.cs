using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekBehaviour : MonoBehaviour
{
    public Vector3 velocity;
    public Rigidbody rb;

    //public Vector3 rotation;
    public float current;

    public float maxSpeed = 10f;

    public Transform target;
    public Transform character;


    // Update is called once per frame
    void Update()
    {
        //get the direction to the target
        velocity = target.position - character.position;

        //move along this direction at full speed
        velocity.Normalize();
        velocity *= maxSpeed;

        rb.AddForce(velocity * Time.deltaTime);

        //face the direction we want to move
        float targetAngle = newOrientation(character.rotation.eulerAngles.y, velocity);
        character.eulerAngles = new Vector3(0, targetAngle, 0);
    }

    public float newOrientation(float current, Vector3 velecity)
    {
        if (velocity.magnitude > 0)
        {
            float targetAngle = Mathf.Atan2(velocity.x, velocity.z);
            targetAngle *= Mathf.Rad2Deg;
            return targetAngle;
        }

        else //unsure
        {
            return current;
        }
    }
}
