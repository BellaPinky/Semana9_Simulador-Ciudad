using System.Collections.Generic;
using UnityEngine;

public class NpcBehaviour : MonoBehaviour
{
    List<Transform> targets = new List<Transform>();
    int targetsIndex = 0;
    //public Transform target1;
    //public Transform target2;
    //public Transform target3;
    //public Transform target4;
    public float speed;
    //public int puntoActual = 1;
    //Animator animator;


    void Start()
    {
        //animator = GetComponent<Animator>();
        Trabajar();
    }

    
    void Update()
    {
        //Si hay 0 edificios no se mueve 
        if(BuildControler.buildControler.Builds.Count != 0)
        {
            Moverse();
        }
        
        //Debug.Log("Punto actual = " + puntoActual);
        

        //if (puntoActual == 2)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, targets[targetsIndex].position, 1);
        //}

        //if (transform.position == targets[targetsIndex].position)
        //{
        //    Debug.Log("Llegaste al target 1");
        //    targetsIndex += 1;
        //}

        //if (puntoActual == 3)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, targets[targetsIndex].position, 0);
        //}

        //if (transform.position == targets[targetsIndex].position)
        //{
        //    Debug.Log("Llegaste al target 2");
        //    targetsIndex += 1;
        //}

        //if (puntoActual == 4)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, targets[targetsIndex].position, 0);
        //}

        //if (transform.position == targets[targetsIndex].position)
        //{
        //    Debug.Log("Llegaste al target 3");
        //    targetsIndex += 1;
        //}


    }

    void Moverse()
    {
        Debug.Log("Moverse");
        float step = speed * Time.deltaTime;
        //if (puntoActual == targetsIndex -1)
        {
            transform.position = Vector3.MoveTowards(transform.position, targets[targetsIndex].position, step);
        }

        if (transform.position == targets[targetsIndex].position)
        {

            Debug.Log("Llegaste al target 0");
            targetsIndex += 1;
            if (targetsIndex == targets.Count)
            {
                targetsIndex = 0;
            }

        }
    }

    void ActualizarWayPoints(Transform _newBuild)
    {
        targets.Add(_newBuild);
    }

    protected void Trabajar()
    {
        Debug.Log("En camino");
    }

    private void OnEnable()
    {
        PlaneBehaviour.onCrearEdificio += ActualizarWayPoints;
    }

    private void OnDisable()
    {
        PlaneBehaviour.onCrearEdificio -= ActualizarWayPoints;
    }
}
