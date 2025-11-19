using UnityEngine;

public class SoldadoScript : MonoBehaviour
{
    public GameObject player;
    public GameObject BalaPrefab;

    private float UltimoDisparo;
    private int Salud = 2;

    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;

        if (direction.x >= 0.0f)
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

        float distancia = Mathf.Abs(player.transform.position.x - transform.position.x);

        if (distancia < 1.0f && Time.time > UltimoDisparo + 1.0f)
        {
            Disparo();
            UltimoDisparo = Time.time;
        }
    }

    private void Disparo()
    {
        Vector3 direction = transform.localScale.x == 1 ? Vector2.right : Vector2.left;

        GameObject bala = Instantiate(BalaPrefab, transform.position + direction * 0.1f, Quaternion.identity);
        bala.GetComponent<Bala>().SetDirection(direction);
    }

    public void Dano()
    {
        Salud--;

        if (Salud <= 0)
        {
            GameManager.Instancia.SoldadoEliminado();
            Destroy(gameObject);
        }
    }
}
