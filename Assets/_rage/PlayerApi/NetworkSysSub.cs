
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class NetworkSysSub : UdonSharpBehaviour
{
    [UdonSynced(UdonSyncMode.None), FieldChangeCallback(nameof(당근))] private byte _당근 = 0;
    public byte 당근
    {
        get => _당근;
        set
        {
            if (value > 254)
            {
                _당근 = 255;
                Debug.Log("당근개수가 한계입니다!====================");
            }
            else
            {
                _당근 = value;
            }
        }
    }

    const float 간격 = 0.1f;

    public NetworkSysMain main;
    public Transform WeaponHouse;
    
    
    VRCPlayerApi Owner = Networking.LocalPlayer;


    public override void OnOwnershipTransferred(VRCPlayerApi player)
    {
        Owner = player;
    }
    private void FixedUpdate()
    {
        if (Owner != null)
        {
            transform.SetPositionAndRotation(Owner.GetPosition(), Owner.GetRotation());
        }
    } //스폰되면 쫒아오게 설정



    void OnEnable()
    {
        Owner = Networking.GetOwner(this.gameObject);
        if (Owner.isLocal && !Owner.isMaster)
        {
            for (int i = 0; i < main.pool.Pool.Length; i++)
            {
                if (this.gameObject == main.pool.Pool[i].gameObject)
                {
                    main.PlayerObjectNum = (byte)i;
                    break;
                }
            }
        }
   } //오브젝트가 스폰되면 PlayerObjectNum 설정





    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        if (Networking.IsOwner(this.gameObject))
        {
            if (Networking.IsMaster)
            {
                SendCustomEventDelayedSeconds("RequestSync", main.PlayerObjectNum * 0.2f);    //위치싱크
            }
            else
            {
                if (this.gameObject == main.pool.Pool[main.PlayerObjectNum].gameObject)
                {
                    SendCustomEventDelayedSeconds("RequestSync", main.PlayerObjectNum * 0.2f);
                }
            }
        }
    }
    // 다른 플레이어가 들어오면 자신의 오브젝트넘버초후에 싱크.
    // 오브젝트넘버초후에 하는 이유는 동시에 샌드커스텀네트워크를 날릴때 렉을 방지하기 위함



    //플레이어들어오면싱크 (RequestSync)
    #region
    public void RequestSync()
    {
        ReSyncX();
        SendCustomEventDelayedSeconds("ReSyncY", 0.1f);
    }
    public void ReSyncX()   //플레이어가 들어왔을때 리싱크
    {
        int temp = ((int)(WeaponHouse.transform.localPosition.x / 간격));
        if (temp == 0)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "zX");
        }
        else if (temp > 0)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "pX" + temp.ToString());
        }
        else
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "mX" + (-1 * temp).ToString());
        }
    }
    public void ReSyncY()
    {
        int temp = ((int)(WeaponHouse.transform.localPosition.y / 간격));
        if (temp == 0)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "zY");
        }
        else if (temp > 0)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "pY" + temp.ToString());
        }
        else
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "mY" + (-1 * temp).ToString());
        }
    }
    #endregion




    //Main에서 버튼입력받아실행
    #region
    //Set X
    public void pX()
    {
        int temp = ((int)(WeaponHouse.transform.localPosition.x / 간격)) + 1;
        if (temp == 0)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "zX");
        }
        if (temp > 0)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "pX" + temp.ToString());
        }
        else
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "mX" + (-1 * temp).ToString());
        }
    }
    public void mX()
    {
        int temp = ((int)(WeaponHouse.transform.localPosition.x / 간격)) - 1;
        if (temp == 0)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "zX");
        }
        if (temp > 0)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "pX" + temp.ToString());
        }
        else
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "mX" + (-1 * temp).ToString());
        }
    }

    //Set Y
    public void pY()
    {
        int temp = ((int)(WeaponHouse.transform.localPosition.y / 간격)) + 1;
        if (temp == 0)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "zY");
        }
        if (temp > 0)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "pY" + temp.ToString());
        }
        else
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "mY" + (-1 * temp).ToString());
        }

    }
    public void mY()
    {
        int temp = ((int)(WeaponHouse.transform.localPosition.y / 간격)) - 1;
        if (temp == 0)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "zY");
        }
        if (temp > 0)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "pY" + temp.ToString());
        }
        else
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "mY" + (-1 * temp).ToString());
        }
    }    
    #endregion

    //set To Zero
    public void zX()
    {
        WeaponHouse.transform.localPosition = new Vector3(0, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void zY()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 0, WeaponHouse.transform.localPosition.z);
    }

    public void resetP()
    {
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "zX");
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "zY");
    }

    //커스텀네트워크이벤트생긴거 1~30까지 있으면 최대는 30*간격, 즉 
    /*
    public void pX#1#()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * #1#, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX#1#()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * #1#, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }

    public void pY#1#()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * #1#, WeaponHouse.transform.localPosition.z);
    }
    public void mY#1#()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, -간격 * #1#, WeaponHouse.transform.localPosition.z);
    }
    */

    //커스텀네트워크이벤트목록들
    //pX1~20
    #region 
    public void pX1()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 1, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX2()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 2, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX3()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 3, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX4()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 4, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX5()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 5, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX6()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 6, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX7()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 7, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX8()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 8, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX9()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 9, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX10()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 10, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX11()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 11, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX12()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 12, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX13()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 13, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX14()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 14, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX15()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 15, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX16()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 16, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX17()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 17, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX18()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 18, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX19()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 19, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void pX20()
    {
        WeaponHouse.transform.localPosition = new Vector3(간격 * 20, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    #endregion

    //mX1~20
    #region
    public void mX1()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 1, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX2()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 2, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX3()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 3, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX4()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 4, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX5()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 5, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX6()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 6, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX7()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 7, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX8()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 8, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX9()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 9, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX10()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 10, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX11()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 11, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX12()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 12, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX13()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 13, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX14()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 14, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX15()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 15, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX16()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 16, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX17()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 17, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX18()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 18, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX19()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 19, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    public void mX20()
    {
        WeaponHouse.transform.localPosition = new Vector3(-간격 * 20, WeaponHouse.transform.localPosition.y, WeaponHouse.transform.localPosition.z);
    }
    #endregion

    //pY1~30
    #region
    public void pY1()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 1, WeaponHouse.transform.localPosition.z);
    }
    public void pY2()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 2, WeaponHouse.transform.localPosition.z);
    }
    public void pY3()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 3, WeaponHouse.transform.localPosition.z);
    }
    public void pY4()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 4, WeaponHouse.transform.localPosition.z);
    }
    public void pY5()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 5, WeaponHouse.transform.localPosition.z);
    }
    public void pY6()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 6, WeaponHouse.transform.localPosition.z);
    }
    public void pY7()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 7, WeaponHouse.transform.localPosition.z);
    }
    public void pY8()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 8, WeaponHouse.transform.localPosition.z);
    }
    public void pY9()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 9, WeaponHouse.transform.localPosition.z);
    }
    public void pY10()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 10, WeaponHouse.transform.localPosition.z);
    }
    public void pY11()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 11, WeaponHouse.transform.localPosition.z);
    }
    public void pY12()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 12, WeaponHouse.transform.localPosition.z);
    }
    public void pY13()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 13, WeaponHouse.transform.localPosition.z);
    }
    public void pY14()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 14, WeaponHouse.transform.localPosition.z);
    }
    public void pY15()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 15, WeaponHouse.transform.localPosition.z);
    }
    public void pY16()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 16, WeaponHouse.transform.localPosition.z);
    }
    public void pY17()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 17, WeaponHouse.transform.localPosition.z);
    }
    public void pY18()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 18, WeaponHouse.transform.localPosition.z);
    }
    public void pY19()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 19, WeaponHouse.transform.localPosition.z);
    }
    public void pY20()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 20, WeaponHouse.transform.localPosition.z);
    }
    public void pY21()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 21, WeaponHouse.transform.localPosition.z);
    }
    public void pY22()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 22, WeaponHouse.transform.localPosition.z);
    }
    public void pY23()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 23, WeaponHouse.transform.localPosition.z);
    }
    public void pY24()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 24, WeaponHouse.transform.localPosition.z);
    }
    public void pY25()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 25, WeaponHouse.transform.localPosition.z);
    }
    public void pY26()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 26, WeaponHouse.transform.localPosition.z);
    }
    public void pY27()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 27, WeaponHouse.transform.localPosition.z);
    }
    public void pY28()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 28, WeaponHouse.transform.localPosition.z);
    }
    public void pY29()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 29, WeaponHouse.transform.localPosition.z);
    }
    public void pY30()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, 간격 * 30, WeaponHouse.transform.localPosition.z);
    }
    #endregion
    
    //mY1~10
    #region
    public void mY1()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, -간격 * 1, WeaponHouse.transform.localPosition.z);
    }
    public void mY2()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, -간격 * 2, WeaponHouse.transform.localPosition.z);
    }
    public void mY3()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, -간격 * 3, WeaponHouse.transform.localPosition.z);
    }
    public void mY4()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, -간격 * 4, WeaponHouse.transform.localPosition.z);
    }
    public void mY5()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, -간격 * 5, WeaponHouse.transform.localPosition.z);
    }
    public void mY6()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, -간격 * 6, WeaponHouse.transform.localPosition.z);
    }
    public void mY7()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, -간격 * 7, WeaponHouse.transform.localPosition.z);
    }
    public void mY8()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, -간격 * 8, WeaponHouse.transform.localPosition.z);
    }
    public void mY9()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, -간격 * 9, WeaponHouse.transform.localPosition.z);
    }
    public void mY10()
    {
        WeaponHouse.transform.localPosition = new Vector3(WeaponHouse.transform.localPosition.x, -간격 * 10, WeaponHouse.transform.localPosition.z);
    }
    #endregion
                          
}
