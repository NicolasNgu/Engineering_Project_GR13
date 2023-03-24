using UnityEngine;

public class WatchManager : Singleton<WatchManager>
{
    public GameObject screen;
    public GameObject hand; 
    public GameObject Compass;
    //public Renderer screenRenderer;
    public bool isLit;

    void Start()
    {
        isLit = false;
        //screenRenderer.enabled = isLit;
        screen.SetActive(false);
    }

    void Update()
    {
        //screenRenderer.enabled = isLit;
        screen.SetActive(isLit);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == hand)
        {
            isLit = !isLit;
           // screenRenderer.enabled = !screenRenderer.enabled;
        }
    }
}
