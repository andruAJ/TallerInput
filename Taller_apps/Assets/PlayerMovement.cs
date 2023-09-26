using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputActionAsset playerInput;
    public Rigidbody rb;
    public InputActionAsset playerJump;
    private float vertical;
    private float speed = 8f;

    Vector2 moveDirection = Vector2.zero;

    private void OnEnable()
    {
        playerInput.Enable();
        playerJump.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
        playerJump.Disable();
    }


    void Update()
    {
        //moveDirection = playerInput.ReadValue<Vector2>();
        rb.velocity = new Vector3(vertical * speed, rb.velocity.y);

    }

    public void jump(PlayerInput context)
    {
        //if (context.performed)
        {
         //   rb.velocity = new Vector3(rb.velocity.y * 0.5f);
        }
    }

}
