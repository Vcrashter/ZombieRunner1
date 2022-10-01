using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float intensityAmount = 5f;
    [SerializeField] float restoreAngle = 90;

    public void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashLightSystem>().RestoreLightAngle(restoreAngle);
            other.GetComponentInChildren<FlashLightSystem>().RestoreLightIntensity(intensityAmount);
            Destroy(gameObject);
        }
    }
}
