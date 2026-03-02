using UnityEngine;

public class CubeMoverHoldSpace : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Le cube ne bouge QUE si ESPACE est maintenu
        if (Input.GetKey(KeyCode.Space))
        {
            float horizontal = Input.GetAxisRaw("Horizontal");  // Gauche / Droite
            float vertical = Input.GetAxisRaw("Vertical");      // Haut / Bas

            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if (direction.magnitude >= 0.1f)
            {
                transform.Translate(direction * speed * Time.deltaTime, Space.World);
            }
        }
    }
}