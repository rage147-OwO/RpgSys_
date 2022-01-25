
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;
using VRC.SDK3.Components;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class MonsterRoomMain : UdonSharpBehaviour
{

    public Monster[] 몬스터데이터;

    public Transform 몬스터스폰위치중앙;

    public Transform 입장위치;
    public Transform 플레이어죽었을때스폰위치;
    public Camera 카메라;

    public GameObject[] 당근데이터;

    [SerializeField] int 몬스터스폰범위 = 5;
    [SerializeField] public int 체력_최대체력 = 100;
    [SerializeField] public int 체력_현재플레이어체력 = 100;

    [SerializeField] public bool 플레이어가죽었음;

    [SerializeField] Transform[] 위치;
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
    public void 몬스터죽음()
    {
        // SendCustomEventDelayedSeconds("몬스터스폰", 1f);
    }
    public void 방입장()
    {
        방리셋();
        Networking.LocalPlayer.TeleportTo(입장위치.position, 입장위치.rotation);
        //Networking.LocalPlayer.CombatSetMaxHitpoints(100);
        몬스터스폰(0);
        몬스터스폰(1);
        몬스터스폰(2);
        몬스터스폰(3);
        몬스터스폰(4);
        몬스터스폰(5);

        /*
        몬스터스폰();
        몬스터스폰();
        몬스터스폰();
        몬스터스폰();
        */
    }
    public void 몬스터스폰(int Type)
    {

        몬스터데이터[Type].gameObject.SetActive(true);
        몬스터데이터[Type].gameObject.transform.position = 위치[Type].position;

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
        for (int i = 0; i < 당근데이터.Length; i++)
        {
            당근데이터[i].gameObject.SetActive(false);
        }
    }
    public override void OnSpawn()
    {
    }
    public override void OnPlayerRespawn(VRCPlayerApi player)
    {
        방리셋();
        //Networking.LocalPlayer.CombatSetCurrentHitpoints(100);
    }
    /*
    public void 몬스터스폰()
    {           

        int counter = 0;
        for(int i = 0; i < 몬스터데이터.Length; i++)
        {
            if (!몬스터데이터[i].gameObject.activeInHierarchy)
            {
                counter++;
            }
        }
        int R = Random.Range(0, counter+1);

        if (counter == 0)
        {
            Debug.Log("소환가능한 몬스터가 없음");
            return;
        }   
             counter = 0;
        for (int i = 0; i < 몬스터데이터.Length; i++)
        {
            if (!몬스터데이터[i].gameObject.activeInHierarchy)
            {
                if (counter == R)
                {
                    몬스터데이터[i].gameObject.SetActive(true);
                    몬스터데이터[i].gameObject.transform.position = new Vector3(
                    몬스터스폰위치중앙.position.x + Random.Range(-몬스터스폰범위, 몬스터스폰범위),
                    몬스터스폰위치중앙.position.y,
                    몬스터스폰위치중앙.position.z + Random.Range(-몬스터스폰범위, 몬스터스폰범위)
                    );
                    break;
                }
                counter++;
            }
        }
    }   */
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
            }
        }
    }
    public void 플레이어사망모션()
    {
        Networking.LocalPlayer.CombatSetCurrentHitpoints(0);
    }
}


