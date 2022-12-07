using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimationAfterPuzzle : MonoBehaviour
{
    public GameObject puzzle1;
    public GameObject cafea;
    private TriggerAnimation anim;

    void Update()
    {
        if (puzzle1.GetComponent<Puzzle1>().getMass() == 5)
        {
            anim = cafea.GetComponent<TriggerAnimation>();
            anim.enabled = true;
        }
    }
}
