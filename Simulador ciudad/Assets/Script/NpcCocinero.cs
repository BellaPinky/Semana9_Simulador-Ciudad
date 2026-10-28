using UnityEngine;

public class NpcCocinero : NpcBehaviour
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
        Debug.Log("de Cocinero");
    }
}
