using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PLayerInputt : MonoBehaviour
{
    [SerializeField] private float fsalto = 250f;
    [SerializeField] private float speed = 100f;

    private PlayerInput control;
    private Vector2 input;
    private Vector2 zero;

    private Rigidbody rb;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        control = GetComponent<PlayerInput>();
        anim = GetComponent<Animator>();
        zero.x = 0;
        zero.y = 0;
    }

    // Update is called once per frame
    void Update()
    {
        input = control.actions["Run"].ReadValue<Vector2>();
        //Debug.Log(input);
    }
    private void FixedUpdate()
    {
        if (input != zero)
        {
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
        }
        rb.AddForce(new Vector3(input.x, 0, input.y) * speed);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            rb.AddForce(Vector3.up * fsalto);
            Debug.Log("jump");
            anim.SetTrigger("jump");
        }
    }
}
