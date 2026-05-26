using UnityEngine;

public class Hand : MonoBehaviour
{
    public Vector2 mousePos;
    [SerializeField] private Gun activeGun;

    private void Start()
    {
        if (!activeGun)
        {
            activeGun = GetComponentInChildren<Gun>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lookDirection = (Vector2)mousePos - (Vector2)transform.position;
        // 3. Calculate angle in degrees
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

        // 4. Apply rotation (adjust -90f if sprite faces up instead of right)
        transform.rotation = Quaternion.Euler(0, 0, angle - 90f);
        //transform.LookAt(lookPosition);

        activeGun.lookDirection = (Vector2)mousePos - (Vector2)activeGun.transform.position;

    }

    public void Fire()
    {
        activeGun.Fire();
    }
}
