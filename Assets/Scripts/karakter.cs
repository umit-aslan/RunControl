using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour
{
   private void FixedUpdate()
   {
        transform.Translate(Vector3.forward * .5f * Time.deltaTime);//karakterin ileri gitmesi
   }

   private void Update() 
   {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Input.GetAxis("Mouse X") < 0)
            {
                transform.position =Vector3.Lerp(transform.position,new Vector3(transform.position.x-.1f,
                 transform.position.y, transform.position.z), .3f);
            }
            else if (Input.GetAxis("Mouse X") > 0)
            {
                 transform.position =Vector3.Lerp(transform.position,new Vector3(transform.position.x+.1f,
                 transform.position.y, transform.position.z), .3f);
            }
        }
    }
}
