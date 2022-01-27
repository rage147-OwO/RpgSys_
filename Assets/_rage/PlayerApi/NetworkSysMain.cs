
using UdonSharp;
using UnityEngine;
using VRC.SDK3.Components;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
[RequireComponent(typeof(VRCObjectPool))] //컴포넌트추가시오브젝트풀동시생성
public class NetworkSysMain : UdonSharpBehaviour
{
    public VRCObjectPool pool;
    [System.NonSerialized] public byte PlayerObjectNum = 254; //플레이어오브젝트풀넘버임

    private void FixedUpdate()
    {
        for(int i = 0; i < pool.Pool.Length; i++)
        {
            if (pool.Pool[i].gameObject.activeInHierarchy == true){
                Debug.Log("당근" + pool.Pool[i].GetComponent<NetworkSysSub>().당근);
            }
        }
    }

    //캔버스에서 버튼클릭받아서 weaponHouse(검집)이동시킴 
    #region 
    public void RequestSync()
    {
        pool.Pool[PlayerObjectNum].GetComponent<NetworkSysSub>().RequestSync();
    }
    public void resetP()
    {
        pool.Pool[PlayerObjectNum].GetComponent<NetworkSysSub>().resetP();
    }
    public void up()
    {
        pool.Pool[PlayerObjectNum].GetComponent<NetworkSysSub>().pY();
    }
    public void down()
    {
        pool.Pool[PlayerObjectNum].GetComponent<NetworkSysSub>().mY();
    }
    public void right()
    {
        pool.Pool[PlayerObjectNum].GetComponent<NetworkSysSub>().pX();
    }
    public void left()
    {
        pool.Pool[PlayerObjectNum].GetComponent<NetworkSysSub>().mX();
    }
    #endregion

    //초기설정 Start,OnPlayerJoin,OnPlayerLeft 에서 오브젝트풀을 스폰하고 오너설정해줌
    #region
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
    #endregion   
}
