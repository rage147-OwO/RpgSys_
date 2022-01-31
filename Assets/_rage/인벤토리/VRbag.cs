
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]

public class VRbag : UdonSharpBehaviour
{
    public Slider 슬라이더;
    public GameObject VR헤드;
    public GameObject 버튼;
    public GameObject 콘텐츠필드;


    VRC_Pickup PickupTemp;
    GameObject CloneButtonTemp;

    void Start()
    {
        VR헤드.SetActive(false);
    }
    public void SliderChange()
    {
        this.transform.localPosition = new Vector3(-0.3f, 슬라이더.value, 0);
    }

    public void SpawnButton(GameObject _Objectpool, string _TextName)
    {
        CloneButtonTemp = VRCInstantiate(버튼);
        CloneButtonTemp.SetActive(true);
        CloneButtonTemp.transform.SetParent(콘텐츠필드.transform,false);
        ((Text)CloneButtonTemp.GetComponentInChildren(typeof(Text))).text = _TextName;
        CloneButtonTemp.GetComponent<spawnbutton>().ObjectPool = _Objectpool;
    }

    public void OnTriggerEnter(Collider other)
    {
        if ((Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right) != null)) { 
            if (Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right).gameObject.name==other.gameObject.name)
            {
                PickupTemp = Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right);
                if (PickupTemp.GetComponentInParent<objectPool>() != null)
                {
                    SpawnButton(PickupTemp.GetComponentInParent<objectPool>().gameObject, PickupTemp.gameObject.name.Remove(PickupTemp.gameObject.name.Length - 3));
                    PickupTemp.Drop();
                    PickupTemp.GetComponentInParent<objectPool>().SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "PoolReturn" + PickupTemp.name[PickupTemp.name.Length - 2]);
                }
            }
        }
        if ((Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left) != null))
        {
            if (Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left).gameObject.name == other.gameObject.name)
            {
                PickupTemp = Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Left);
                if (PickupTemp.GetComponentInParent<objectPool>() != null)
                {
                    SpawnButton(PickupTemp.GetComponentInParent<objectPool>().gameObject, PickupTemp.gameObject.name.Remove(PickupTemp.gameObject.name.Length - 3));
                    PickupTemp.Drop();
                    PickupTemp.GetComponentInParent<objectPool>().SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "PoolReturn" + PickupTemp.name[PickupTemp.name.Length - 2]);
                }
            }
        }       
    }

    public override void Interact()
    {
        if (VR헤드.activeInHierarchy)
        {
            VR헤드.SetActive(false);
        }
        else
        {
            VR헤드.transform.SetPositionAndRotation(Networking.LocalPlayer.GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.LocalPlayer.GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
            VR헤드.SetActive(true);
        }
    }
}
