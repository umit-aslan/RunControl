using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alt_Karakter : MonoBehaviour
{
    GameObject Target;
    NavMeshAgent _NavMesh;

    void Start()
    {
        _NavMesh=GetComponent<NavMeshAgent>();
        Target=GameObject.FindWithTag("GameManager").GetComponent<GameManager>().VarisNoktasi;
    }

    void LateUpdate()
    {
        _NavMesh.SetDestination(Target.transform.position);
    }


}
