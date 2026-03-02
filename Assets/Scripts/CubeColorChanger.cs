using UnityEngine;

public class CubeColorChanger : MonoBehaviour
{
    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Appelé quand ce cube entre en collision avec un autre objet (colliders + Rigidbody)
    void OnCollisionEnter(Collision collision)
    {
        if (_renderer != null)
        {
            // Change la couleur du cube en rouge lorsqu'il touche un autre objet
            _renderer.material.color = Color.red;
        }
    }
}