using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
   
   public Transform player;  
    public Vector3 offset = new Vector3(53, 4, 45);  
    public float smoothSpeed = 5f;  

    void LateUpdate()
    {
        if (player != null)
        {
            
            Vector3 desiredPosition = player.position + offset;
           
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);

            
            transform.rotation = Quaternion.Euler(25f, -125f, 0f);
        }
    }
}