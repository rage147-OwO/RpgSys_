
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class 리셋장치 : UdonSharpBehaviour
{
    public Animator Reset;
    public override void Interact()
    {
        Reset.Play("공속포션리셋", -1, 0f);
    }
}
