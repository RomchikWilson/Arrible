using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/GameStorage", fileName = "GameStorageSO")]
public class GameStorage : ScriptableObject
{
    [SerializeField] private bool play = false;

    public bool Play { get => play; set => play = value; }
}