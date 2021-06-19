using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [Header("References objects")]
    [SerializeField] GameObject _object = default;

    public void ActivateDeactivateObject()
    {
        if (!_object) return;

        GameManager.ActivateDeactivateObject?.Invoke(_object);
    }
}
