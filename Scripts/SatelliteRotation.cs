using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatelliteRotation : MonoBehaviour
{
    public Transform target;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("Target not specified. Defaulting to parent GameObject");
        }   
    }

    // Update is called once per frame
    void Update()
    {
        // SatelliteRotation takes three arguments, firts is Vector to rotte around
        // second is vector axis to rotate around
        // third is the degree to rotate, in this case the speed per second

        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
