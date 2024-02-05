using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book : MonoBehaviour
{
    private bool isOpen;
    public Animator bookAnimator;
    public GameObject canvas;
    private float lastInteractionTime;
    public float interactionCooldown = 3.0f;

    void Start() {
        isOpen = false;
        lastInteractionTime = -interactionCooldown;
    }

    public void BottonClick() {
        float currentTime = Time.time;
        if (Time.time - lastInteractionTime > interactionCooldown) {
            StartCoroutine(OpenBook());
            lastInteractionTime = currentTime;
        }
    }

    IEnumerator OpenBook() {
        isOpen = !isOpen;
        canvas.SetActive(isOpen);
        bookAnimator.SetTrigger(isOpen ? "Open" : "Close");

        yield return new WaitForSeconds(1);
    }
}
