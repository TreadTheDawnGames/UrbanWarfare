using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{


    public Vector2 moveDirection;
    public Vector2 lookDirection;

    public float movementDampener = 15f;
    public float movementSpeed = 0.15f;
    
    [SerializeField] private Rigidbody2D rb;
    
    // Update is called once per frame
    void Update()
    {


        rb.AddForce(moveDirection * movementSpeed, ForceMode2D.Impulse);
        rb.linearVelocity = Vector2.Lerp(rb.linearVelocity, Vector2.zero, movementDampener * Time.deltaTime);

    }
}
