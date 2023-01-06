using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watchManager : MonoBehaviour
{

    public GameObject screen;
    public GameObject hand; 
    public GameObject Compass;
    //public Renderer screenRenderer;


    public bool isLit;
    // Start is called before the first frame update
    void Start()
    {
        isLit = false;
        //screenRenderer.enabled = isLit;
        screen.SetActive(false);
        Debug.Log("start ok");
    }

    void Update()
    {
        //screenRenderer.enabled = isLit;

        screen.SetActive(isLit);
    }

    // Update is called once per frame

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == hand)
        {
            isLit = !isLit;
           // screenRenderer.enabled = !screenRenderer.enabled;
            Debug.Log("ecran touché");
        }
    }
    
    
}
