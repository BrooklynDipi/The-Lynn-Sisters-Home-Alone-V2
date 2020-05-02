using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSetActive : InteractiveObject
{
    [Tooltip("Toggled object")]
    [SerializeField] private GameObject objectToToggle;

    [Tooltip("Reusable?")]
    [SerializeField] private bool isReusable = true;

    private bool hasBeenUsed = false;

    /// <summary>
    /// Toggles the activeSelf value for the objectToToggle when the player interacts with this object.
    /// </summary>
    public override void InteractWith()
    {
        if (isReusable || !hasBeenUsed)
        {
            base.InteractWith();
            objectToToggle.SetActive(!objectToToggle.activeSelf);
            hasBeenUsed = true;

            if (!isReusable)
            {
                displayText = string.Empty;
            }
        }
    }
}
