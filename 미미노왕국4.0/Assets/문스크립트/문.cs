
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class 문 : UdonSharpBehaviour
{
    public Animator Gate_Doors_1;
    public override void Interact()
    {
        Gate_Doors_1.SetTrigger("istri");
    }
}
