using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    GameObject gameManager;
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        ball = GameObject.FindGameObjectWithTag("Ball");
        
    }

    private void OnTriggerEnter(Collider other) {
        
    }

    // Update is called once per frame
}
