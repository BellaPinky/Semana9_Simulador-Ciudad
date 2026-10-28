using UnityEngine;

public class PlaneBehaviour : MonoBehaviour
{
    [SerializeField] GameObject build;
    Vector3 ofset = new Vector3(0, 1.5f, 0);
    [SerializeField] bool ocupado = false;
  
    
    internal void CreateBuild()
    {

        if(ocupado == false)
        {
            Instantiate(build, transform.position + ofset, Quaternion.identity);
            Debug.Log("Crear");
            ocupado = true;
        }
        else
        {
            Debug.Log("Este espacio ya esta ocupado");
        }

        





    }
}
