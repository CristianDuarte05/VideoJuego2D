using UnityEngine;

public class Personaje : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpForce = 5f;
    public GameObject BalaPrefab;
    public AudioClip Salto;

    private Rigidbody2D rb;
    private Animator animator;
    private float horizontal;
    private bool Piso;
    private float UltimoDisparo;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        rb.WakeUp();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        else if (horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

        animator.SetBool("running", horizontal != 0.0f);

        Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);

        Piso = Physics2D.Raycast(transform.position + Vector3.down * 0.2f, Vector2.down, 0.3f);


        if (Input.GetKeyDown(KeyCode.W) && Piso)
        {
            rb.AddForce(Vector2.up * JumpForce);

            if (Salto != null)
            {
                audioSource.PlayOneShot(Salto);
            }
        }

        if (Input.GetKey(KeyCode.Space) && Time.time > UltimoDisparo + 0.25f)
        {
            Disparo();
            UltimoDisparo = Time.time;
        }

        if (transform.position.y < -6f)
        {
            GameManager.Instancia.FinDelJuego(false);
        }

    }

    private void Disparo()
    {
        Vector3 direction = transform.localScale.x == 1 ? Vector2.right : Vector2.left;

        GameObject bala = Instantiate(BalaPrefab, transform.position + direction * 0.1f, Quaternion.identity);
        bala.GetComponent<Bala>().SetDirection(direction);
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * Speed, rb.linearVelocity.y);
    }

    public void Dano()
    {
        GameManager.Instancia.RestarVida(1);
    }


}

