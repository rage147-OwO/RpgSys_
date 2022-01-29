
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class 문 : UdonSharpBehaviour
{
    public Animator Gate_Doors_1;
    public override void Interact()
    {
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "문싱크");
    }
    public void 문싱크()
    {
        Gate_Doors_1.SetTrigger("istri");
    }
}
