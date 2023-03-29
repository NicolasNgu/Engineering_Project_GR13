using UnityEngine;
using TMPro;

public class SendToIT : MonoBehaviour
{
    [Header("Codes")]
    public TMP_Text code1;

    [Header("Instructions")]
    public GameObject instruction3;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("To Send To IT"))
        {
            code1.gameObject.SetActive(true);
            Destroy(other.gameObject);
            animator.SetTrigger("Send");
        }
    }

    private void PrintMailsInstructions()
    {
        instruction3.SetActive(true);
    }
}
