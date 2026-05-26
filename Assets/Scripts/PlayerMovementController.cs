using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private InputActionAsset input;

    [SerializeField] private Movement playerMovement;
    [SerializeField] private Hand hand;



    private void OnEnable()
    {
        input.FindActionMap("Player").Enable();
    }

    private void OnDisable()
    {
        input.FindActionMap("Player").Disable();
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Get mouse position in world space
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mouseWorldPos.z = 0; // Ensure 2D plane

        // 2. Calculate direction from object to mouse
        
        playerMovement.moveDirection = InputSystem.actions.FindAction("Move").ReadValue<Vector2>().normalized;
        //playerMovement.lookDirection = (Vector2)mouseWorldPos - (Vector2)transform.position;
        hand.mousePos = (Vector2)mouseWorldPos;

        if (InputSystem.actions.FindAction("Attack").ReadValue<float>() > 0f)
        {
            hand.Fire();
        }
    }


}
