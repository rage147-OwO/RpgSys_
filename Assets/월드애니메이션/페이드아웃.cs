
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class 페이드아웃 : UdonSharpBehaviour
{
    public Animator Fadeout;
    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        Fadeout.Play("페이드아웃1", -1, 0f);
    }
}
