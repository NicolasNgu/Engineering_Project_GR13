using UnityEngine;
using TMPro;
using System.Collections;

public class DisplayGameOverMessage : MonoBehaviour
{
    public float letterPause = 0.3f;
    public AudioClip sound;

    private string message;
    private TMP_Text textComp;

    void Start()
    {
        message = GameManagerBis.Instance.LoadMessage();
        textComp = GetComponent<TMP_Text>();
    }

    public void TypeText()
    {
        StartCoroutine(TypeTextCoroutine());
    }

    IEnumerator TypeTextCoroutine()
    {
        foreach (char letter in message.ToCharArray())
        {
            textComp.text += letter;

            if (sound)
            {
                GetComponent<AudioSource>().PlayOneShot(sound);
            }

            yield return new WaitForSeconds(letterPause);
        }
    }
}
