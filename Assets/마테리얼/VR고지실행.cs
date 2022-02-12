
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class VR고지실행 : UdonSharpBehaviour
{
    public Animator VRison;
    public Animator VRiso;
    public override void Interact()
    {
        VRison.Play("버튼작동", -1, 0f);
        VRiso.Play("버튼작동", -1, 0f);
    }
}
