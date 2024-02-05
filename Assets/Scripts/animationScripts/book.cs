using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book : MonoBehaviour
{
    private bool isOpen;
    public Animator bookAnimator;
    public GameObject canvas;

    private bool canInteract = true;
    public float interactionCooldown = 3.0f;

    void Start() {
        isOpen = false;
    }

    void OnCollisionEnter (Collision col) {
        if (canInteract) {
            StartCoroutine(OpenBook());
            canInteract = false;
            Invoke("ResetInteractionCooldown", interactionCooldown);
        }
    }

    IEnumerator OpenBook() {
        isOpen = !isOpen;
        canvas.SetActive(isOpen);
        bookAnimator.SetTrigger(isOpen ? "Open" : "Close");

        yield return new WaitForSeconds(1);
    }

    void ResetInteractionCooldown() {
        canInteract = true;
    }
}
