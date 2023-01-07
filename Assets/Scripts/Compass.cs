using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Compass : MonoBehaviour
{
        public GameObject target;

    // Update is called once per frame
    void Update()
    {
        float angle = Vector3.SignedAngle(transform.forward, target.transform.position - transform.position, Vector3.up);
        transform.rotation = Quaternion.Euler(0,0,angle);
    }

}*/

public class Compass : MonoBehaviour
{
    public Transform target; // The object to point towards

    // Update is called once per frame
    void Update()
    {
        // Rotate the arrow towards the target
        transform.LookAt(target);
    }
}