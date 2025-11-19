using UnityEngine;
using TMPro;

public class UIControllerTMP : MonoBehaviour
{
    public static UIControllerTMP Instancia;
    public GameObject Reiniciar;



    public TMP_Text VidaTMP;
    public TMP_Text KillsTMP;
    public TMP_Text MensajeFinalTMP;

    private void Awake()
    {
        Instancia = this;
    }

    public void ActualizarUI()
    {
        VidaTMP.text = "Vida: " + GameManager.Instancia.VidaPersonaje;
        KillsTMP.text = "Soldados Eliminados: " + GameManager.Instancia.SoldadosMuertos;
    }

    public void MostrarMensaje(string msg)
    {
        MensajeFinalTMP.text = msg;
        MensajeFinalTMP.gameObject.SetActive(true);
    }

    public void MostrarBotonReiniciar()
    {
        Reiniciar.SetActive(true);
    }

}
