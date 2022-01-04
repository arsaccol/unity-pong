using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    PlayerControls controls;

    public float MoveSpeed = 10f;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update

    private float inputSpeed = 0;

    private void Awake() 
    {
        rigidBody = GetComponent<Rigidbody2D>();
        controls = new PlayerControls();

        controls.Gameplay.Move.performed += ctx => Move(ctx.ReadValue<float>());
        controls.Gameplay.Move.canceled += ctx => Move(ctx.ReadValue<float>());
    }

    private void Update() 
    {
        rigidBody.velocity = new Vector2(0, inputSpeed) * MoveSpeed;
    }


    public void Move(float inputReading)
    {
        inputSpeed = inputReading;
    }


    private void OnEnable() 
    {
        controls.Gameplay.Enable();
    }
    private void OnDisable() 
    {
        controls.Gameplay.Disable();
    }
}
