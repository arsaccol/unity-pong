using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPlayer : MonoBehaviour
{
    private Player thisPlayer;
    public GameObject Ball;
    public float SafeDistance = 3f;

    // Start is called before the first frame update
    void Start()
    {
        thisPlayer = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 fromHereToBall = Ball.transform.position - transform.position;
        //Debug.Log("Vertical distance from ball: " + fromHereToBall.y);

        float verticalDistance = fromHereToBall.y;
        Debug.Log("Vertical distance from ball: " + verticalDistance);


        float verticalMove = Mathf.Clamp01(verticalDistance) * 2 - 1;

        if(Mathf.Abs(fromHereToBall.x) < SafeDistance)
            thisPlayer.Move(verticalMove);
        else
            thisPlayer.Move(0f);
    }
    
}
