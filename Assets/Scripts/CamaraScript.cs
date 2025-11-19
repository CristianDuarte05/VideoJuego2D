using UnityEngine;

public class CamaraScript : MonoBehaviour
{
    public GameObject Personaje;

    [Header("Límites de la cámara")]
    public float minX;
    public float maxX;

    void Update()
    {
        Vector3 position = transform.position;

        // Seguir al personaje en X
        position.x = Personaje.transform.position.x;

        // Aplicar límites
        position.x = Mathf.Clamp(position.x, minX, maxX);

        transform.position = position;
    }
}
