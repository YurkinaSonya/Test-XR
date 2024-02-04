using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class book : MonoBehaviour
{
    private bool isOpen;
    public Animator bookAnimator;

    void Start() {
        Debug.Log("start!");
        isOpen = false;
    }

    void OnCollisionEnter (Collision col) {
        if (isOpen) {
            bookAnimator.SetTrigger("Close");
            isOpen = false;
        }
        else {
            bookAnimator.SetTrigger("Open");
            isOpen = true;
        }
    }
}
