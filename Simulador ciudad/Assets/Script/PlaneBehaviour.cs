using UnityEngine;

public class PlaneBehaviour : MonoBehaviour
{
    internal delegate void OnCrearEdificio(Transform _newBuild);
    internal static event OnCrearEdificio onCrearEdificio;
    [SerializeField] GameObject build;
    Vector3 ofset = new Vector3(0, 1.5f, 0);
    [SerializeField] bool ocupado = false;
  
    
    internal void CreateBuild()
    {

        if(ocupado == false)
        {
            Transform newBuild = Instantiate(build, transform.position + ofset, Quaternion.identity).transform;

            if (onCrearEdificio != null)
            {
                onCrearEdificio(newBuild);
            }
            Debug.Log("Crear");
            ocupado = true;
        }
        else
        {
            Debug.Log("Este espacio ya esta ocupado");
        }

        





    }
}
