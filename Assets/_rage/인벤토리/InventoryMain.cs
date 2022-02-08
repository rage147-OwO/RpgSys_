
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class InventoryMain : UdonSharpBehaviour
{
    public inventoryDesktop Deskop;
    public VRbag VR;
    public GameObject VR더미;


    private void Start()
    {
        if (Networking.LocalPlayer.IsUserInVR()) {
            Deskop.gameObject.SetActive(false);
            VR더미.gameObject.SetActive(true);
        }
        else
        {
            Deskop.gameObject.SetActive(true);
            VR더미.gameObject.SetActive(false);
        }
    }
    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {

    }



}
