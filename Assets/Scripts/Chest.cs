using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    Animator animator;

    const string anim_trigger_chest = "chest_open";

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        animator.SetTrigger(anim_trigger_chest);
    }
}
