using UnityEngine;
using TMPro;

public class Scanner : MonoBehaviour
{
    [Header("Codes in Screen")]
    public TMP_Text code1;
    public TMP_Text code2;
    public TMP_Text code3;
    public TMP_Text code4;
    public TMP_Text code5;

    [Header("Door")]
    public GameObject exitDoor;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Code"))
        {
            switch (other.gameObject.name)
            {
                // case "Code 1":
                //     code1.gameObject.SetActive(true);
                //     break;
                case "Code 2": // END DEMO
                    code2.gameObject.SetActive(true);

                    // if (GameManagerBis.Instance.isDemo)
                    // {
                    //     GameManagerBis.Instance.OpenExitDoor();
                    // }

                    break;
                case "Code 3":
                    code3.gameObject.SetActive(true);

                    if (GameManagerBis.Instance.isDemo)
                    {
                        OpenExitDoor();
                    }

                    break;
                case "Code 4":
                    code4.gameObject.SetActive(true);
                    break;
                case "Code 5": // END GAME
                    code5.gameObject.SetActive(true);
                    OpenExitDoor();
                    break;
            }

            Destroy(other.gameObject);
        }
    }

    public void OpenExitDoor()
    {
        exitDoor.GetComponent<Animator>().SetTrigger("Open Exit Door");
        exitDoor.GetComponent<AudioSource>().Play();
        GameManagerBis.Instance.authorizeExit = true;
    }
}
