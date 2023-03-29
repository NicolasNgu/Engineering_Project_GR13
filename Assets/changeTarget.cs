using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTarget : MonoBehaviour
{
    [SerializeField] private Compass compass;
    [SerializeField] private GameObject newTarget;

    public void changeTargetcompass(){
        compass.target = newTarget.transform;
    }
}
