using Unity.VisualScripting;
using UnityEngine;

public class PlanosHover : MonoBehaviour
{
    public Camera camara;
    public LayerMask capaPlanos; // Asigna la capa de los planos en el Inspector

    private GameObject planoActual;
    private Color colorOriginal;

    void Update()
    {

        HoverRey();
        CheckClik();
       
    }

    void HoverRey()
    {
        Ray rayo = camara.ScreenPointToRay(Input.mousePosition);


        if (Physics.Raycast(rayo, out RaycastHit hit, 100f, capaPlanos))
        {
            GameObject nuevoPlano = hit.collider.gameObject;

            if (nuevoPlano != planoActual)
            {
                // Restaurar el anterior
                if (planoActual != null)
                    planoActual.GetComponent<Renderer>().material.color = colorOriginal;

                // Guardar color original del nuevo y cambiar
                planoActual = nuevoPlano;
                Renderer rend = planoActual.GetComponent<Renderer>();
                colorOriginal = rend.material.color;
                rend.material.color = Color.green; // o el color que quieras
            }
        }
        else
        {
            // No hay nada bajo el cursor: restaurar
            if (planoActual != null)
            {
                planoActual.GetComponent<Renderer>().material.color = colorOriginal;
                planoActual = null;
            }
        }
    }

    void CheckClik ()
    {
        if(Input.GetMouseButtonDown(0) && planoActual !=null)
        {
            //FindAnyObjectByType<CreatorHelper>().CreateBuild();
            planoActual.GetComponent<PlaneBehaviour>().CreateBuild();

        }
    }
}