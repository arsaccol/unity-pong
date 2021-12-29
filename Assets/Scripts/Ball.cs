using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rigidBody;

    public float StartingSpeed;


    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody2D>();


        Vector2 startingForce = Random.insideUnitCircle.normalized * StartingSpeed;
        rigidBody.AddForce(startingForce);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ball speed: " + rigidBody.velocity.magnitude);
    }
}
