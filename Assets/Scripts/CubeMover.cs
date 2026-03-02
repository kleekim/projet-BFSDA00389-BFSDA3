using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Récupérer les touches directionnelles (flèches ou WASD)
        float horizontal = Input.GetAxisRaw("Horizontal");  // Gauche / Droite
        float vertical = Input.GetAxisRaw("Vertical");      // Haut / Bas

        // Direction de déplacement dans le plan XZ
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        // Appliquer le mouvement
        if (direction.magnitude >= 0.1f)
        {
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
        }
    }
}