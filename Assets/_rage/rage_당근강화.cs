
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class rage_당근강화 : UdonSharpBehaviour
{
    public rage_당근강화메인 메인;
    byte temp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("강화대"))
        {
            if (Networking.LocalPlayer.IsOwner(this.gameObject))
            {
                temp = 메인.랜덤뽑기();
                if (1 == temp)
                {
                    ((VRC_Pickup)this.GetComponent(typeof(VRC_Pickup))).Drop();
                    메인.당근오브젝트풀.Return(this.gameObject);
                }
                else
                {
                    SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "메테리얼" + temp);
                }
            }
        }
    }
    private void OnEnable()
    {
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "메테리얼0");
    }
    public void 메테리얼0()
    {
        ((MeshRenderer)this.GetComponent(typeof(MeshRenderer))).material = 메인.메테리얼6개[0];
    }
    public void 메테리얼1()
    {
        ((MeshRenderer)this.GetComponent(typeof(MeshRenderer))).material = 메인.메테리얼6개[1];
    }
    public void 메테리얼2()
    {
        ((MeshRenderer)this.GetComponent(typeof(MeshRenderer))).material = 메인.메테리얼6개[2];
    }
    public void 메테리얼3()
    {
        ((MeshRenderer)this.GetComponent(typeof(MeshRenderer))).material = 메인.메테리얼6개[3];
    }
    public void 메테리얼4()
    {
        ((MeshRenderer)this.GetComponent(typeof(MeshRenderer))).material = 메인.메테리얼6개[4];
    }
    public void 메테리얼5()
    {
        ((MeshRenderer)this.GetComponent(typeof(MeshRenderer))).material = 메인.메테리얼6개[5];
    }
}
