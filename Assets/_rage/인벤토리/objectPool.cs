
using UdonSharp;
using UnityEngine;
using VRC.SDK3.Components;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
[RequireComponent(typeof(VRCObjectPool))]
public class objectPool : UdonSharpBehaviour
{
    [System.NonSerialized] public VRCObjectPool 오브젝트풀;
    [System.NonSerialized] public ObjectPoolMain PoolMain;

    private void Start()
    {
        PoolMain = GetComponentInParent<ObjectPoolMain>();
        오브젝트풀 = (VRCObjectPool)GetComponent(typeof(VRCObjectPool));
    }
    public override void Interact()
    {
        오브젝트풀.TryToSpawn();
    }
    public void SpawnReq(int playerNum)
    {
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, "Spawn" + playerNum);
    }

    #region 오브젝트풀리턴

    public void PoolReturn0()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[0]);
        오브젝트풀.Return(오브젝트풀.Pool[0]);
    }
    public void PoolReturn1()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[1]);
        오브젝트풀.Return(오브젝트풀.Pool[1]);
    }
    public void PoolReturn2()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[2]);
        오브젝트풀.Return(오브젝트풀.Pool[2]);
    }
    public void PoolReturn3()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[3]);
        오브젝트풀.Return(오브젝트풀.Pool[3]);
    }
    public void PoolReturn4()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[4]);
        오브젝트풀.Return(오브젝트풀.Pool[4]);
    }
    public void PoolReturn5()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[5]);
        오브젝트풀.Return(오브젝트풀.Pool[5]);
    }
    public void PoolReturn6()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[6]);
        오브젝트풀.Return(오브젝트풀.Pool[6]);
    }
    public void PoolReturn7()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[7]);
        오브젝트풀.Return(오브젝트풀.Pool[7]);
    }
    public void PoolReturn8()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[8]);
        오브젝트풀.Return(오브젝트풀.Pool[8]);
    }
    public void PoolReturn9()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[9]);
        오브젝트풀.Return(오브젝트풀.Pool[9]);
    }
    public void PoolReturn10()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[10]);
        오브젝트풀.Return(오브젝트풀.Pool[10]);
    }
    public void PoolReturn11()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[11]);
        오브젝트풀.Return(오브젝트풀.Pool[11]);
    }
    public void PoolReturn12()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[12]);
        오브젝트풀.Return(오브젝트풀.Pool[12]);
    }
    public void PoolReturn13()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[13]);
        오브젝트풀.Return(오브젝트풀.Pool[13]);
    }
    public void PoolReturn14()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[14]);
        오브젝트풀.Return(오브젝트풀.Pool[14]);
    }
    public void PoolReturn15()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[15]);
        오브젝트풀.Return(오브젝트풀.Pool[15]);
    }
    public void PoolReturn16()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[16]);
        오브젝트풀.Return(오브젝트풀.Pool[16]);
    }
    public void PoolReturn17()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[17]);
        오브젝트풀.Return(오브젝트풀.Pool[17]);
    }
    public void PoolReturn18()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[18]);
        오브젝트풀.Return(오브젝트풀.Pool[18]);
    }
    public void PoolReturn19()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[19]);
        오브젝트풀.Return(오브젝트풀.Pool[19]);
    }
    public void PoolReturn20()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[20]);
        오브젝트풀.Return(오브젝트풀.Pool[20]);
    }
    public void PoolReturn21()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[21]);
        오브젝트풀.Return(오브젝트풀.Pool[21]);
    }
    public void PoolReturn22()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[22]);
        오브젝트풀.Return(오브젝트풀.Pool[22]);
    }
    public void PoolReturn23()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[23]);
        오브젝트풀.Return(오브젝트풀.Pool[23]);
    }
    public void PoolReturn24()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[24]);
        오브젝트풀.Return(오브젝트풀.Pool[24]);
    }
    public void PoolReturn25()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[25]);
        오브젝트풀.Return(오브젝트풀.Pool[25]);
    }
    public void PoolReturn26()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[26]);
        오브젝트풀.Return(오브젝트풀.Pool[26]);
    }
    public void PoolReturn27()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[27]);
        오브젝트풀.Return(오브젝트풀.Pool[27]);
    }
    public void PoolReturn28()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[28]);
        오브젝트풀.Return(오브젝트풀.Pool[28]);
    }
    public void PoolReturn29()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[29]);
        오브젝트풀.Return(오브젝트풀.Pool[29]);
    }
    public void PoolReturn30()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[30]);
        오브젝트풀.Return(오브젝트풀.Pool[30]);
    }
    public void PoolReturn31()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[31]);
        오브젝트풀.Return(오브젝트풀.Pool[31]);
    }
    public void PoolReturn32()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[32]);
        오브젝트풀.Return(오브젝트풀.Pool[32]);
    }
    public void PoolReturn33()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[33]);
        오브젝트풀.Return(오브젝트풀.Pool[33]);
    }
    public void PoolReturn34()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[34]);
        오브젝트풀.Return(오브젝트풀.Pool[34]);
    }
    public void PoolReturn35()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[35]);
        오브젝트풀.Return(오브젝트풀.Pool[35]);
    }
    public void PoolReturn36()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[36]);
        오브젝트풀.Return(오브젝트풀.Pool[36]);
    }
    public void PoolReturn37()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[37]);
        오브젝트풀.Return(오브젝트풀.Pool[37]);
    }
    public void PoolReturn38()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[38]);
        오브젝트풀.Return(오브젝트풀.Pool[38]);
    }
    public void PoolReturn39()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[39]);
        오브젝트풀.Return(오브젝트풀.Pool[39]);
    }
    public void PoolReturn40()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[40]);
        오브젝트풀.Return(오브젝트풀.Pool[40]);
    }
    public void PoolReturn41()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[41]);
        오브젝트풀.Return(오브젝트풀.Pool[41]);
    }
    public void PoolReturn42()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[42]);
        오브젝트풀.Return(오브젝트풀.Pool[42]);
    }
    public void PoolReturn43()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[43]);
        오브젝트풀.Return(오브젝트풀.Pool[43]);
    }
    public void PoolReturn44()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[44]);
        오브젝트풀.Return(오브젝트풀.Pool[44]);
    }
    public void PoolReturn45()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[45]);
        오브젝트풀.Return(오브젝트풀.Pool[45]);
    }
    public void PoolReturn46()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[46]);
        오브젝트풀.Return(오브젝트풀.Pool[46]);
    }
    public void PoolReturn47()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[47]);
        오브젝트풀.Return(오브젝트풀.Pool[47]);
    }
    public void PoolReturn48()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[48]);
        오브젝트풀.Return(오브젝트풀.Pool[48]);
    }
    public void PoolReturn49()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[49]);
        오브젝트풀.Return(오브젝트풀.Pool[49]);
    }
    public void PoolReturn50()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[50]);
        오브젝트풀.Return(오브젝트풀.Pool[50]);
    }
    public void PoolReturn51()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[51]);
        오브젝트풀.Return(오브젝트풀.Pool[51]);
    }
    public void PoolReturn52()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[52]);
        오브젝트풀.Return(오브젝트풀.Pool[52]);
    }
    public void PoolReturn53()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[53]);
        오브젝트풀.Return(오브젝트풀.Pool[53]);
    }
    public void PoolReturn54()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[54]);
        오브젝트풀.Return(오브젝트풀.Pool[54]);
    }
    public void PoolReturn55()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[55]);
        오브젝트풀.Return(오브젝트풀.Pool[55]);
    }
    public void PoolReturn56()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[56]);
        오브젝트풀.Return(오브젝트풀.Pool[56]);
    }
    public void PoolReturn57()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[57]);
        오브젝트풀.Return(오브젝트풀.Pool[57]);
    }
    public void PoolReturn58()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[58]);
        오브젝트풀.Return(오브젝트풀.Pool[58]);
    }
    public void PoolReturn59()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[59]);
        오브젝트풀.Return(오브젝트풀.Pool[59]);
    }
    public void PoolReturn60()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[60]);
        오브젝트풀.Return(오브젝트풀.Pool[60]);
    }
    public void PoolReturn61()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[61]);
        오브젝트풀.Return(오브젝트풀.Pool[61]);
    }
    public void PoolReturn62()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[62]);
        오브젝트풀.Return(오브젝트풀.Pool[62]);
    }
    public void PoolReturn63()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[63]);
        오브젝트풀.Return(오브젝트풀.Pool[63]);
    }
    public void PoolReturn64()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[64]);
        오브젝트풀.Return(오브젝트풀.Pool[64]);
    }
    public void PoolReturn65()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[65]);
        오브젝트풀.Return(오브젝트풀.Pool[65]);
    }
    public void PoolReturn66()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[66]);
        오브젝트풀.Return(오브젝트풀.Pool[66]);
    }
    public void PoolReturn67()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[67]);
        오브젝트풀.Return(오브젝트풀.Pool[67]);
    }
    public void PoolReturn68()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[68]);
        오브젝트풀.Return(오브젝트풀.Pool[68]);
    }
    public void PoolReturn69()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[69]);
        오브젝트풀.Return(오브젝트풀.Pool[69]);
    }
    public void PoolReturn70()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[70]);
        오브젝트풀.Return(오브젝트풀.Pool[70]);
    }
    public void PoolReturn71()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[71]);
        오브젝트풀.Return(오브젝트풀.Pool[71]);
    }
    public void PoolReturn72()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[72]);
        오브젝트풀.Return(오브젝트풀.Pool[72]);
    }
    public void PoolReturn73()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[73]);
        오브젝트풀.Return(오브젝트풀.Pool[73]);
    }
    public void PoolReturn74()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[74]);
        오브젝트풀.Return(오브젝트풀.Pool[74]);
    }
    public void PoolReturn75()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[75]);
        오브젝트풀.Return(오브젝트풀.Pool[75]);
    }
    public void PoolReturn76()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[76]);
        오브젝트풀.Return(오브젝트풀.Pool[76]);
    }
    public void PoolReturn77()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[77]);
        오브젝트풀.Return(오브젝트풀.Pool[77]);
    }
    public void PoolReturn78()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[78]);
        오브젝트풀.Return(오브젝트풀.Pool[78]);
    }
    public void PoolReturn79()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[79]);
        오브젝트풀.Return(오브젝트풀.Pool[79]);
    }
    public void PoolReturn80()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[80]);
        오브젝트풀.Return(오브젝트풀.Pool[80]);
    }
    public void PoolReturn81()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[81]);
        오브젝트풀.Return(오브젝트풀.Pool[81]);
    }
    public void PoolReturn82()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[82]);
        오브젝트풀.Return(오브젝트풀.Pool[82]);
    }
    public void PoolReturn83()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[83]);
        오브젝트풀.Return(오브젝트풀.Pool[83]);
    }
    public void PoolReturn84()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[84]);
        오브젝트풀.Return(오브젝트풀.Pool[84]);
    }
    public void PoolReturn85()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[85]);
        오브젝트풀.Return(오브젝트풀.Pool[85]);
    }
    public void PoolReturn86()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[86]);
        오브젝트풀.Return(오브젝트풀.Pool[86]);
    }
    public void PoolReturn87()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[87]);
        오브젝트풀.Return(오브젝트풀.Pool[87]);
    }
    public void PoolReturn88()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[88]);
        오브젝트풀.Return(오브젝트풀.Pool[88]);
    }
    public void PoolReturn89()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[89]);
        오브젝트풀.Return(오브젝트풀.Pool[89]);
    }
    public void PoolReturn90()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[90]);
        오브젝트풀.Return(오브젝트풀.Pool[90]);
    }
    public void PoolReturn91()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[91]);
        오브젝트풀.Return(오브젝트풀.Pool[91]);
    }
    public void PoolReturn92()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[92]);
        오브젝트풀.Return(오브젝트풀.Pool[92]);
    }
    public void PoolReturn93()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[93]);
        오브젝트풀.Return(오브젝트풀.Pool[93]);
    }
    public void PoolReturn94()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[94]);
        오브젝트풀.Return(오브젝트풀.Pool[94]);
    }
    public void PoolReturn95()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[95]);
        오브젝트풀.Return(오브젝트풀.Pool[95]);
    }
    public void PoolReturn96()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[96]);
        오브젝트풀.Return(오브젝트풀.Pool[96]);
    }
    public void PoolReturn97()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[97]);
        오브젝트풀.Return(오브젝트풀.Pool[97]);
    }
    public void PoolReturn98()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[98]);
        오브젝트풀.Return(오브젝트풀.Pool[98]);
    }
    public void PoolReturn99()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[99]);
        오브젝트풀.Return(오브젝트풀.Pool[99]);
    }
    public void PoolReturn100()
    {
        Networking.SetOwner(Networking.LocalPlayer, 오브젝트풀.Pool[100]);
        오브젝트풀.Return(오브젝트풀.Pool[100]);
    }



    #endregion

    #region 플레이어번호받아서스폰

    public void Spawn0()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[0].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[0].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn1()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[1].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[1].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {
                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn2()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[2].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[2].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn3()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[3].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[3].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn4()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[4].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[4].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn5()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[5].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[5].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn6()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[6].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[6].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn7()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[7].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[7].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn8()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[8].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[8].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn9()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[9].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[9].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn10()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[10].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[10].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn11()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[11].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[11].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn12()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[12].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[12].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn13()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[13].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[13].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn14()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[14].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[14].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn15()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[15].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[15].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn16()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[16].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[16].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn17()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[17].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[17].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn18()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[18].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[18].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn19()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[19].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[19].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn20()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[20].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[20].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn21()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[21].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[21].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn22()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[22].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[22].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn23()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[23].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[23].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn24()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[24].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[24].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn25()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[25].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[25].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn26()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[26].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[26].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn27()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[27].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[27].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn28()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[28].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[28].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn29()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[29].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[29].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn30()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[30].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[30].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn31()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[31].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[31].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn32()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[32].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[32].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn33()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[33].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[33].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn34()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[34].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[34].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn35()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[35].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[35].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn36()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[36].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[36].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn37()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[37].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[37].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn38()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[38].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[38].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn39()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[39].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[39].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn40()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[40].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[40].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn41()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[41].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[41].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn42()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[42].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[42].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn43()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[43].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[43].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn44()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[44].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[44].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn45()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[45].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[45].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn46()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[46].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[46].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn47()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[47].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[47].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn48()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[48].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[48].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn49()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[49].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[49].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn50()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[50].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[50].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn51()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[51].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[51].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn52()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[52].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[52].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn53()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[53].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[53].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn54()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[54].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[54].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn55()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[55].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[55].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn56()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[56].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[56].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn57()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[57].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[57].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn58()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[58].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[58].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn59()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[59].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[59].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn60()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[60].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[60].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn61()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[61].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[61].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn62()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[62].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[62].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn63()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[63].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[63].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn64()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[64].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[64].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn65()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[65].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[65].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn66()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[66].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[66].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn67()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[67].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[67].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn68()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[68].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[68].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn69()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[69].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[69].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn70()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[70].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[70].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn71()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[71].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[71].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn72()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[72].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[72].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn73()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[73].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[73].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn74()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[74].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[74].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn75()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[75].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[75].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn76()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[76].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[76].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn77()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[77].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[77].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn78()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[78].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[78].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn79()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[79].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[79].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn80()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[80].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[80].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn81()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[81].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[81].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn82()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[82].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[82].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn83()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[83].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[83].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn84()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[84].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[84].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn85()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[85].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[85].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn86()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[86].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[86].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn87()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[87].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[87].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn88()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[88].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[88].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn89()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[89].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[89].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn90()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[90].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[90].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn91()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[91].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[91].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn92()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[92].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[92].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn93()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[93].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[93].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn94()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[94].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[94].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn95()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[95].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[95].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn96()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[96].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[96].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn97()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[97].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[97].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn98()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[98].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[98].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn99()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[99].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[99].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }
    public void Spawn100()
    {
        PoolMain.더미.SetPositionAndRotation(Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[100].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).position, Networking.GetOwner(PoolMain.NetworkMain.pool.Pool[100].gameObject).GetTrackingData(VRCPlayerApi.TrackingDataType.Head).rotation);
        for (int i = 0; i < 오브젝트풀.Pool.Length; i++)
        {
            if (!오브젝트풀.Pool[i].activeInHierarchy)
            {

                (오브젝트풀.TryToSpawn()).transform.position = PoolMain.더미앞.position;
                break;
            }
        }
    }



    #endregion




}
