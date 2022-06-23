using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject hedef;
    public GameObject PrefabKarakter;//Oluşturulacak alt karakter Prefab'ı
    public GameObject DogmaNoktasi;
    public GameObject VarisNoktasi;

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))//A tuşuna basınca şunu yap
        {
            Instantiate(PrefabKarakter,DogmaNoktasi.transform.position,Quaternion.identity);//Ana karakter arkasında alt karakter oluştur.
        }
    }
}
