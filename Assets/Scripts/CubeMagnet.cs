using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpatialSys.UnitySDK;

public class CubeMagnet : MonoBehaviour
{
    public float magnetDistance;
    public float magnetPower;

    
    void FixedUpdate()
    {
        Vector3 playerPos = SpatialBridge.actorService.localActor.avatar.position;
        playerPos.y = playerPos.y+1;
        Vector3 cubePos = this.gameObject.transform.position;
        

        float dist = Vector3.Distance(playerPos, cubePos);
        
        
        if (dist < magnetDistance)
        {
            cubePos = Vector3.MoveTowards(cubePos, playerPos, magnetPower);
            this.gameObject.transform.position = cubePos;
            
        }
        
        
    }
}
