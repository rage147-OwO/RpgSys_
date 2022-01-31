
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using UnityEngine.UI;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class inventoryDesktop : UdonSharpBehaviour
{
    public GameObject 더미캔버스위치;
    public ScrollRect 스크롤뷰;
    public GameObject 콘텐츠필드;
    public GameObject 버튼;

    GameObject CloneButtonTemp;
    VRC_Pickup PickupTemp;

    public InventoryMain Main;


    private void Start()
    {
        Main = GetComponentInParent<InventoryMain>();
        더미캔버스위치.SetActive(false);
        스크롤뷰.gameObject.SetActive(false);
    }
    public void SpawnButton(GameObject _Objectpool, string _TextName)
    {
        CloneButtonTemp = VRCInstantiate(버튼);
        CloneButtonTemp.SetActive(true);
        CloneButtonTemp.transform.SetParent(콘텐츠필드.transform,false);
        ((Text)CloneButtonTemp.GetComponentInChildren(typeof(Text))).text= _TextName;
        CloneButtonTemp.GetComponent<spawnbutton>().ObjectPool = _Objectpool;
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Networking.LocalPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right) != null)
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

        if (Input.GetKey(KeyCode.Tab))
        {
            if (!더미캔버스위치.activeInHierarchy)
            {
                스크롤뷰.gameObject.SetActive(true);
                더미캔버스위치.SetActive(true);
            }
            더미캔버스위치.transform.SetPositionAndRotation(Networking.LocalPlayer.GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.LocalPlayer.GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        }
        else
        {
            if (더미캔버스위치.activeInHierarchy)
            {
                스크롤뷰.gameObject.SetActive(false);
                더미캔버스위치.SetActive(false);
            }
        }
    }
}
