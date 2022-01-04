using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rigidBody;

    public float StartingSpeed;
    public float LaunchAngleSpan = 60f;


    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();


        Vector2 startingForce = getBallLaunchVector(60f * Mathf.Deg2Rad) * StartingSpeed;

        rigidBody.AddForce(startingForce);
    }


    Vector2 getBallLaunchVector(float angleSpan)
    {
        float launchAngle = Random.value * angleSpan - angleSpan / 2;

        return new Vector2(Mathf.Cos(launchAngle), Mathf.Sin(launchAngle));
    }
}
