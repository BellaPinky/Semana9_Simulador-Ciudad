using UnityEngine;

public class NpcRepartidor : NpcBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Trabajar();
        Trabajar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Trabajar()
    {
        Debug.Log("De Repartidor");
    }
}
