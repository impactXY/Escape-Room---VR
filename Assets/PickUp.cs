using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PickUp : XRSimpleInteractable
{
    public GameObject key;
    private bool enable = false;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        enable = !enable;
        if (enable == true)
        {
            key.SetActive(false);
        }
        else key.SetActive(false);
    }

}
