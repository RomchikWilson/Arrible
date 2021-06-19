using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameStorage gameStorageSO = default;

    public static Action StartGame = default;
    public static Action<GameObject> ActivateDeactivateObject = default;

    private void Awake()
    {
        gameStorageSO.Play = false;
    }

    private void OnEnable()
    {
        ActivateDeactivateObject += ActivateDeactivateObj;
        StartGame += OnStartGame;
    }

    private void OnDisable()
    {
        ActivateDeactivateObject -= ActivateDeactivateObj;
        StartGame -= OnStartGame;
    }

    private void ActivateDeactivateObj(GameObject _object)
    {
        _object.SetActive(!_object.active);
    }

    private void OnStartGame()
    {
        gameStorageSO.Play = true;
    }
}
