using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator2 : MonoBehaviour
{
    public Animator startAnim2;
    public DialogueMeneger2 dm;

    public void OnTriggerEnter2D(Collider2D other)
    {
        startAnim2.SetBool("startOpen2", true);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        startAnim2.SetBool("startOpen2", false);
        dm.EndDialogue();
    }
}
