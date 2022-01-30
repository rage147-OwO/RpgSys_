
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDK3.Components;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
[RequireComponent(typeof(VRCObjectPool))]
public class NetworkSysMain : UdonSharpBehaviour
{
    [System.NonSerialized] public VRCObjectPool pool;
    [System.NonSerialized] public byte PlayerObjectNum = 254;     
    VRCPlayerApi LocalPlayer;

    private void Start()
    {
        pool = ((VRCObjectPool)GetComponent(typeof(VRCObjectPool)));

    }

    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        if (Networking.IsMaster)
        {
            if (player.isLocal)       //마스터가 처음 월드에 들어왔을때 실행
            {
                pool.TryToSpawn();
                PlayerObjectNum = 0;
            }
            else
            {
                if (VRCPlayerApi.GetPlayerCount() > pool.Pool.Length)
                {
                    Debug.Log("오브젝트풀 에러! 플레이어가 오브젝트풀의 사이즈보다 많음");
                }
                else
                {
                    Networking.SetOwner(player, pool.TryToSpawn());
                }
            }
        }
    }            

    public override void OnPlayerLeft(VRCPlayerApi player)
    {
        if (Networking.IsMaster)
        {
            for (int i = 0; i < pool.Pool.Length; i++)
            {
                if ((PlayerObjectNum != i) && (pool.Pool[i].activeInHierarchy) && (Networking.IsOwner(pool.Pool[i].gameObject)))
                {
                    pool.Return(pool.Pool[i].gameObject);
                    break;
                }
            }
        }
    }
}
