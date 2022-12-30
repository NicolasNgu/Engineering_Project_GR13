using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watchManager : MonoBehaviour
{

    public GameObject screen;
    public GameObject hand; 

    bool isLit;
    // Start is called before the first frame update
    void Start()
    {
        isLit = false;
        screen.SetActive(false);
        Debug.Log("start ok");
    }

    // Update is called once per frame

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == hand)
        {
            isLit = !isLit;
            screen.SetActive(isLit);
            Debug.Log("ecran touché");
        }
    }
}
