using UnityEngine;

public class SonImprimante : MonoBehaviour
{
    [SerializeField] private AudioSource _sonImprimante;
    [SerializeField] private GameObject _consignes;

    void Start()
    {
        _consignes.gameObject.SetActive(false);
    }

    public void Printing()
    {
        _sonImprimante.Play();
    }

    public void ConsignesApparition()
    {
        _consignes.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
