
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class 텔레포트 : UdonSharpBehaviour
{
    public Transform 텔레포트위치;
    public GameObject 디자인;
    public override void Interact()
    {
        디자인.gameObject.SetActive(true);
        Networking.LocalPlayer.TeleportTo(텔레포트위치.position, 텔레포트위치.rotation);
    }
}
