using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimationAfterKey : MonoBehaviour
{
    public GameObject puzzle1;
    public GameObject cafea;
    private TriggerAnimation anim;

    void Update()
    {
        if (puzzle1.activeInHierarchy == false)
        {
            anim = cafea.GetComponent<TriggerAnimation>();
            anim.enabled = true;
        }
    }
}
