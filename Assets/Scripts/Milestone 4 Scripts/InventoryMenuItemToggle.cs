using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenuItemToggle : MonoBehaviour
{
    [Tooltip("Used to display inventory icon.")]
    [SerializeField] 
    private Image iconImage;

    private InventoryObject associatedInventoryObject;

    public static event Action<InventoryObject> InventoryMenuItemSelected;
    public InventoryObject AssociatedInventoryObject
    {
        get { return associatedInventoryObject; }
        set
        {
            associatedInventoryObject = value;
            iconImage.sprite = associatedInventoryObject.Icon;
        }
    }

    /// <summary>
    /// This will be plugged into the toggle's "OnValueChanged" property in the editor 
    /// and called whenever the toggle is clicked.
    /// </summary>
 
    private void Awake()
    {
        Toggle toggle = GetComponent<Toggle>();
        ToggleGroup toggleGroup = GetComponentInParent<ToggleGroup>();
        toggle.group = toggleGroup;
    }

    public void InventoryMenuItemWasToggled(bool isOn)
    {
        // We only want to do the stuff when the toggle has been selected, not when it has been deselected.

        Debug.Log($"Toggled: {isOn}");
        if (isOn)
        {
            InventoryMenuItemSelected?.Invoke(AssociatedInventoryObject);
        }
    }

}
