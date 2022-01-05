using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerOneGoal;
    public GameObject playerTwoGoal;
    // Start is called before the first frame update
    void Start()
    {
        Collider2D collider = playerOneGoal.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
