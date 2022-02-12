
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;
using VRC.SDK3.Components;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class MonsterRoomMain : UdonSharpBehaviour
{
    public GameObject 던전디자인;
    public NetworkSysMain NetworkSys;
    public Monster[] 몬스터데이터;

    public Transform 몬스터스폰위치중앙;

    public Transform 입장위치;
    public Transform 퇴장위치;
    public Transform 플레이어죽었을때스폰위치;
    public Camera 카메라;


    public GameObject[] 몬스터가죽고나서드랍되는오브젝트0;
    public GameObject[] 몬스터가죽고나서드랍되는오브젝트1;

    [SerializeField] public int 체력_최대체력 = 100;
    [SerializeField] public int 체력_현재플레이어체력 = 100;

    [SerializeField] float 몬스터리스폰시간 = 3f;

    [System.NonSerialized] public bool 플레이어가죽었음;

    public InventoryMain 인벤토리메인;
    public GameObject 오브젝트풀0;
    public GameObject 오브젝트풀1;
    public GameObject 던전브금;
    public GameObject 광장브금;



    #region 몬스터리스폰(Monster.cs)에서호출당해타이머동작후리스폰
    public void 몬스터리스폰(GameObject MonsterDeath)
    {
        for (int i = 0; i < 몬스터데이터.Length; i++)
        {
            if (MonsterDeath == 몬스터데이터[i].gameObject)
            {
                SendCustomEventDelayedSeconds("MonseterRespawn" + i.ToString(), 몬스터리스폰시간);
                break;
            }
        }
    }
    public void MonseterRespawn0()
    {
        몬스터데이터[0].gameObject.SetActive(true);
    }
    public void MonseterRespawn1()
    {
        몬스터데이터[1].gameObject.SetActive(true);
    }
    public void MonseterRespawn2()
    {
        몬스터데이터[2].gameObject.SetActive(true);
    }
    public void MonseterRespawn3()
    {
        몬스터데이터[3].gameObject.SetActive(true);
    }
    public void MonseterRespawn4()
    {
        몬스터데이터[4].gameObject.SetActive(true);
    }
    public void MonseterRespawn5()
    {
        몬스터데이터[5].gameObject.SetActive(true);
    }
    #endregion


    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        if (player == Networking.LocalPlayer)
        {

            Networking.LocalPlayer.CombatSetup();
            Networking.LocalPlayer.CombatSetRespawn(true, 6f, 플레이어죽었을때스폰위치);
            Networking.LocalPlayer.CombatSetMaxHitpoints(100);
            Networking.LocalPlayer.CombatSetCurrentHitpoints(100);
            Networking.LocalPlayer.CombatSetDamageGraphic(null);
            Networking.LocalPlayer.CombatSetup();
            for (int i = 0; i < 몬스터데이터.Length; i++)
            {
                몬스터데이터[i].gameObject.SetActive(false);
            }
        }
    }

    public void 방입장()
    {
        던전디자인.SetActive(true);
        방리셋();
        Networking.LocalPlayer.TeleportTo(입장위치.position, 입장위치.rotation);
        //Networking.LocalPlayer.CombatSetMaxHitpoints(100);

        for(int i = 0; i < 몬스터데이터.Length; i++)
        {
            몬스터스폰(i);
        }
    }
    public void 방퇴장()
    {
        던전디자인.SetActive(false);
        for (int i = 0; i < 몬스터데이터.Length; i++)
        {
            몬스터데이터[i].gameObject.SetActive(false);
        }
        Networking.LocalPlayer.TeleportTo(퇴장위치.position, 퇴장위치.rotation);
    }

    public void 몬스터스폰(int Num)
    {
        몬스터데이터[Num].gameObject.SetActive(true);
    }    
    public void 방리셋()
    {
        Networking.LocalPlayer.CombatSetCurrentHitpoints(10);
        카메라.enabled = false;
        플레이어가죽었음 = false;
        체력_최대체력 = 100;
        체력_현재플레이어체력 = 100;

        for (int i = 0; i < 몬스터데이터.Length; i++)
        {
            몬스터데이터[i].MonsterDisEnable();
            몬스터데이터[i].gameObject.SetActive(false);
        }
        for(int i = 0; i < 몬스터가죽고나서드랍되는오브젝트0.Length; i++)
        {
            몬스터가죽고나서드랍되는오브젝트0[i].SetActive(false);
            몬스터가죽고나서드랍되는오브젝트1[i].SetActive(false);

        }                                                                       
    }
 
    public override void OnPlayerRespawn(VRCPlayerApi player)
    {
        방리셋();
        //Networking.LocalPlayer.CombatSetCurrentHitpoints(100);
    }

    public void 플레이어체력업데이트()
    {

        if (체력_현재플레이어체력 <= 0)
        {
            if (!플레이어가죽었음)
            {
                카메라.transform.position = new Vector3(Networking.LocalPlayer.GetPosition().x, Networking.LocalPlayer.GetPosition().y + 3, Networking.LocalPlayer.GetPosition().z);
                카메라.enabled = true;
                SendCustomEventDelayedSeconds("플레이어사망모션", 0.5f);
                SendCustomEventDelayedSeconds("방리셋", 5.9f);
                플레이어가죽었음 = true;
                던전브금.gameObject.SetActive(false);
                광장브금.gameObject.SetActive(true);
            }
        }
    }
    public void 플레이어사망모션()
    {
        Networking.LocalPlayer.CombatSetCurrentHitpoints(0);
    }
}


