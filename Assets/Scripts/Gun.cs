using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    [SerializeField] private Projectile projectile;

    public Vector2 lookDirection;
    float accuracyRange = 50f;
    float accuracyAngle = 128f;

    private void Update()
    {
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle - 90f);
    }

    public void Fire()
    {
        print("thinging");
    }
}
