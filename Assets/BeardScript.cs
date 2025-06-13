using UnityEngine;
using UnityEngine.InputSystem;

public class BeardScript : MonoBehaviour
{
    public new Rigidbody2D rigidbody2D;
    private InputAction jumpAction;
    public float flapStrength = 10;
    public bool isAlive = true;

    public LogicManagerScript logic;

    void Awake()
    {
        logic = GameObject.Find("Logic Manager").GetComponent<LogicManagerScript>();
        if (logic == null)
        {
            Debug.LogError("Logic Manager not found!");
        }
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
        if (isAlive) { 
            rigidbody2D.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isAlive = false;
    }
}
