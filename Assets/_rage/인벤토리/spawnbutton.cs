
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class spawnbutton : UdonSharpBehaviour
{
    public GameObject ObjectPool;
    public void ButtonInteract()
    {
        ObjectPool.GetComponent<objectPool>().SpawnReq(this.GetComponentInParent<buttonContent>().NetworkMain.PlayerObjectNum);
        Destroy(gameObject);
    }
}
