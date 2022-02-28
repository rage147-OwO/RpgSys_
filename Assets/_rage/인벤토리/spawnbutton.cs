﻿
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class spawnbutton : UdonSharpBehaviour
{
    public GameObject ObjectPool;
    public void ButtonInteract()
    {
        ObjectPool.GetComponent<objectPool>().SpawnReq(this.GetComponentInParent<buttonContent>().NetworkMain.PlayerObjectNum);
        Destroy(this.gameObject);
    }
}
