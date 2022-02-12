
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
    public GameObject 이동버튼;
    public GameObject 버튼;


    private void Start()
    {
        if (Networking.LocalPlayer.IsUserInVR()) {
            Deskop.gameObject.SetActive(false);
            VR더미.gameObject.SetActive(true);
            이동버튼.gameObject.SetActive(true);
            버튼.gameObject.SetActive(false);
        }
        else
        {
            Deskop.gameObject.SetActive(true);
            VR더미.gameObject.SetActive(false);
            이동버튼.gameObject.SetActive(false);
            버튼.gameObject.SetActive(true);
        }
    }
}
