using UnityEngine;

public class PrinterScript : MonoBehaviour
{
    [SerializeField] private GameObject _consigne1;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            _consigne1.SetActive(true);
        }
    }
}
