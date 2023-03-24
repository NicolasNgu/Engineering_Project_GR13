using UnityEngine;

public class activateCompass : MonoBehaviour
{

    public GameObject hand;
    public GameObject CompassApp;
    public GameObject watchScreen;
    public bool isCompass;

    // Start is called before the first frame update
    void Start()
    {
        isCompass = false;
        WatchManager.Instance.Compass.SetActive(isCompass);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == hand)
        {
            isCompass = !isCompass;
            WatchManager.Instance.Compass.SetActive(isCompass);
            WatchManager.Instance.isLit = !WatchManager.Instance.isLit;
        }
    }
}
