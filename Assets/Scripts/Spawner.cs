using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject SoldadoPrefab;
    public GameObject player;
    public Vector2 minPos;
    public Vector2 maxPos;
    public float intervalo = 2f;

    private float tiempo;

    void Update()
    {
        if (Time.time > tiempo + intervalo)
        {
            SpawnSoldado();
            tiempo = Time.time;
        }
    }

    void SpawnSoldado()
    {
        // Posición aleatoria entre minPos y maxPos
        float x = Random.Range(minPos.x, maxPos.x);
        float y = Random.Range(minPos.y, maxPos.y);
        Vector2 spawnPos = new Vector2(x, y);

        // Crear soldado
        GameObject s = Instantiate(SoldadoPrefab, spawnPos, Quaternion.identity);

        // ASIGNAR player al soldado recién creado
        s.GetComponent<SoldadoScript>().player = player;

        // También puedes asignar BalaPrefab si lo necesitas
    }
}
