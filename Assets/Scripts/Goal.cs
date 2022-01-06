using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public int playerID;
    public GameObject gameManagerObject;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = gameManagerObject.GetComponent<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Score!!!!");
        gameManager.PlayerScored(playerID);
    }

    // Update is called once per frame
}
