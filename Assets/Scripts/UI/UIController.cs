using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [Header("References objects")]
    [SerializeField] private GameObject panelMessage = default;

    public static Action<bool> ActivateDeactivatePanelMessage = default;

    private void OnEnable()
    {
        ActivateDeactivatePanelMessage += ActivateDeactivatePanelMess;
    }

    private void OnDisable()
    {
        ActivateDeactivatePanelMessage -= ActivateDeactivatePanelMess;
    }

    private void ActivateDeactivatePanelMess(bool active)
    {
        panelMessage.SetActive(active);
    }
}
