using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;//Kamera ve  player arasındaki mesafeyi hesaplar
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset,.25f);
    }
}
