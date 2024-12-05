using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpatialSys.UnitySDK;

public class TrackingParticles : MonoBehaviour
{
    public GameObject particles;
    public ParticleSystem subParticles;
    public Vector3 psPos;
    public float AddPosY;
    public float minX;
    public float maxX;
    public float posX;
    public float minZ;
    public float maxZ;
    public float posZ;
    public float rot;
    public bool distanceSubEmi;
    public float distanceToTimeScale=1;


    void Update()
    {
        Vector3 playerPosition;  

        playerPosition = SpatialBridge.actorService.localActor.avatar.position;
        //Debug.Log(playerPosition);
        posZ = playerPosition.z;
        posX = playerPosition.x;
        if (playerPosition.z < minZ) posZ = minZ;
        if (playerPosition.z > maxZ) posZ = maxZ;

        if (playerPosition.x < minX) posX = minX;
        if (playerPosition.x > maxX) posX = maxX;
        /*
        if (distanceSubEmi&& subParticles!=null)
        {
            float dist = Vector3.Distance(playerPosition, particles.transform.position);
            var main = particles.GetComponent<ParticleSystem>().main;
            var sub = subParticles.main;
            float simSpeed = Mathf.Clamp(dist-1.5f, 0, distanceToTimeScale);
            main.simulationSpeed = simSpeed;
            sub.simulationSpeed = simSpeed;
        }
        */
        psPos.Set(posX, playerPosition.y + AddPosY, posZ);
        particles.transform.SetPositionAndRotation(psPos, Quaternion.Euler(0, rot, 90));
        
    }
}
