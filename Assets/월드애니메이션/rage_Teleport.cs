
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class rage_Teleport : UdonSharpBehaviour
{
    public RoomEnter RoomEnter;
    private void Start()
    {
        this.gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        RoomEnter.Enter();
        this.gameObject.SetActive(false);
    }
}
