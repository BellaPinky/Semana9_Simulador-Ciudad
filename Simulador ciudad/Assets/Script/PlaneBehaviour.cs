using UnityEngine;

public class PlaneBehaviour : MonoBehaviour
{
    [SerializeField] GameObject build;
    Vector3 ofset = new Vector3(0, 5, 0);
    
    
    internal void CreateBuild()
    {
        Debug.Log("Crear");
        Instantiate(build, transform.position + ofset, Quaternion.identity);

        
    }
}
