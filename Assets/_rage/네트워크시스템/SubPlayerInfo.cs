
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace SubPlayerInfoNamespace
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
    public class SubPlayerInfo : UdonSharpBehaviour
    {
        public MainPlayerInfoNamespace.MainPlayerInfo 메인데이터;
        [System.NonSerialized,UdonSynced] public byte 당근개수;

        void 리셋()
        { 
            당근개수 = 0;
        }

        public override void OnOwnershipTransferred(VRCPlayerApi player)
        {
            로컬번호등록(player);
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "리셋");
        }
        public void 로컬번호등록(VRCPlayerApi 플레이어)
        {
            if (플레이어 == Networking.LocalPlayer)
            {
                if (!Networking.IsMaster)
                {
                    for (int i=0;i<메인데이터.서브데이터.Length;i++)
                    {
                        if (메인데이터.서브데이터[i].gameObject == this.gameObject)
                        {
                            리셋();
                            메인데이터.로컬번호 = ((byte)i);
                            RequestSerialization();
                            break;
                        }
                    }
                }
            }
        }

    }
}
