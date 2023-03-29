using UnityEngine;
using TMPro;

public class SendToIT : MonoBehaviour
{
    public TMP_Text code1;

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
}
