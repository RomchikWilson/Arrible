using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_OnStart : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            GameManager.StartGame?.Invoke();
            gameObject.SetActive(false);
        }   
    }
}
