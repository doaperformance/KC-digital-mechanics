using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpatialSys.UnitySDK;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 50f;
    public Vector3 playerPosition;
    
    
    
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        playerPosition = SpatialBridge.actorService.localActor.avatar.position;
        this.transform.position = playerPosition;
    }
}
