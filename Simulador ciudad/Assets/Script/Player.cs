using UnityEngine;

public class Player : MonoBehaviour
{
   int dinero = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void CambiarDinero()
    {
        dinero += 1;
        //dinero += _cantidad;
        
    }

    private void OnEnable()
    {
        BuildBehaviour.onGanarDinero += CambiarDinero;
    }

    private void OnDisable()
    {
        BuildBehaviour.onGanarDinero -= CambiarDinero;
    }
}
