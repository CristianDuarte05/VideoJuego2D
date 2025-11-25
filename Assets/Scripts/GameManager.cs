using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;

    public int VidaPersonaje = 10;
    public int SoldadosMuertos = 0;

    private bool juegoTerminado = false;   

    private void Awake()
    {
        Instancia = this;
    }

    private void Start()
    {
        UIControllerTMP.Instancia.ActualizarUI();
    }

    public void RestarVida(int cantidad)
    {
        if (juegoTerminado) return;   

        VidaPersonaje -= cantidad;

        UIControllerTMP.Instancia.ActualizarUI();

        if (VidaPersonaje <= 0)
        {
            FinDelJuego(false);
        }
    }

    public void SoldadoEliminado()
    {
        if (juegoTerminado) return;   

        SoldadosMuertos++;

        UIControllerTMP.Instancia.ActualizarUI();

        if (SoldadosMuertos >= 10)
        {
            FinDelJuego(true);
        }
    }

    public void FinDelJuego(bool victoria)
    {
        if (juegoTerminado) return;   
        juegoTerminado = true;      

        Time.timeScale = 0f;

        if (victoria)
            UIControllerTMP.Instancia.MostrarMensaje("¡GANASTE! Eliminaste 10 soldados.");
        else
            UIControllerTMP.Instancia.MostrarMensaje("PERDISTE :(");

        UIControllerTMP.Instancia.MostrarBotonReiniciar();
    }

    public void ReiniciarJuego()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
