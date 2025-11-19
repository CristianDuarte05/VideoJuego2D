using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad;
    private Vector2 direccion;
    private Rigidbody2D rb;
    public AudioClip Sonido;

    private void Start()
    {
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Sonido);
    }

    public void SetDirection(Vector2 dir)
    {
        direccion = dir.normalized;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = direccion * velocidad;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Soldado"))
        {
            collision.GetComponent<SoldadoScript>()?.Dano();
        }

        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Personaje>()?.Dano();
        }

        Destroy(gameObject);
    }

    public void Desaparece()
    {
        Destroy(gameObject);
    }

}
