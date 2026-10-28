using System.Collections.Generic;
using UnityEngine;

public class BuildControler : MonoBehaviour
{
    internal static BuildControler buildControler;
    List<Transform> builds = new List<Transform>();
    private void Awake()
    {
        if(buildControler == null)
        {
            buildControler = this;
        }
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddBuild(Transform _newBuild)
    {
        builds.Add(_newBuild);
    }

    internal List<Transform> Builds
    {
        get { return builds; }
    }


    private void OnEnable()
    {
        PlaneBehaviour.onCrearEdificio += AddBuild;
    }

    private void OnDisable()
    {
        PlaneBehaviour.onCrearEdificio -= AddBuild;
    }
}
