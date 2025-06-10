using UnityEngine;
using UnityEngine.InputSystem;

public class BeardScript : MonoBehaviour
{
    public new Rigidbody2D rigidbody2D;
    private InputAction jumpAction;
    public float flapStrength = 10;

    void Awake()
    {
        jumpAction = new InputAction(type: InputActionType.Button, binding: "<Keyboard>/space");
        jumpAction.performed += ctx => Jump(); 
    }

    void OnEnable()
    {
        jumpAction.Enable();
    }

    void OnDisable()
    {
        jumpAction.Disable();
    }

    private void Jump()
    {
        rigidbody2D.linearVelocity = Vector2.up * flapStrength;
    }
}
