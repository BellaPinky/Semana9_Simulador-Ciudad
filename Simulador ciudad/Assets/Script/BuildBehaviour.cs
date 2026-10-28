using System.Collections;
using UnityEngine;

public class BuildBehaviour : MonoBehaviour
{
    internal delegate void OnGanarDinero();
    internal static event OnGanarDinero onGanarDinero;

    float tiempoEspereMin = 15;
    float tiempoEspereMax = 30;

    void Start()
    {
        //FindAnyObjectByType<Player>().CambiarDinero();
        StartCoroutine(PagarRenta());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PagarRenta()
    {
        float tiempoEspera = Random.Range(tiempoEspereMin, tiempoEspereMax);
        yield return new WaitForSeconds(tiempoEspera/10);
        if (onGanarDinero != null)
        {
            onGanarDinero();
        }

        StartCoroutine(PagarRenta());

    }
}
