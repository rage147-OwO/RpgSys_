
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
    public GameObject 브이알;
    public GameObject 피씨;


    private void Start()
    {
        if (Networking.LocalPlayer.IsUserInVR()) {
            Deskop.gameObject.SetActive(false);
            VR더미.gameObject.SetActive(true);
            브이알.gameObject.SetActive(true);
            피씨.gameObject.SetActive(false);
        }
        else
        {
            Deskop.gameObject.SetActive(true);
            VR더미.gameObject.SetActive(false);
            브이알.gameObject.SetActive(false);
            피씨.gameObject.SetActive(true);
        }
    }
}
