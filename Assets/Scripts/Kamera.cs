using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    public Transform target;//Kameranın takip edeceği hedef(karakter).
    public Vector3 offset;//Belli bir açıdan takip edebilmesi için offset yani bir pozisyon verdik.

    void Start()
    {
        offset = transform.position - target.position;//Kameramızın pozisyonundan hedef pozisyonu çıkardık. Yani aradaki mesafeyi hesapladık.
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset,.25f);
        //Yumuşak bir takip için Vector3.Lerp kullandık.
        //Bu hareketi hangi yumuşaklıkta yapacağını float olarak belirledik.
        //Bu değer  genel olarak 100-150 arası olmalıdır.
    }
}
