
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace MainPlayerInfoNamespace
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
    public class MainPlayerInfo : UdonSharpBehaviour
    {
        public SubPlayerInfoNamespace.SubPlayerInfo[] 서브데이터;
        [System.NonSerialized]public byte 로컬번호=255;
        public override void OnPlayerJoined(VRCPlayerApi player)
        {
            오브젝트할당(player);
        }

        public void 오브젝트할당(VRCPlayerApi 플레이어)
        {
            if (Networking.IsMaster)
            {
                if (플레이어 == Networking.LocalPlayer)
                {
                    로컬번호 = ((byte)(서브데이터.Length - 1));
                    Networking.SetOwner(Networking.LocalPlayer, 서브데이터[서브데이터.Length - 1].gameObject);
                }
                else
                {
                    for (byte i = 0; i < 서브데이터.Length - 1; i++)
                    {
                        if (Networking.IsOwner(서브데이터[i].gameObject))
                        {
                            Networking.SetOwner(플레이어, 서브데이터[i].gameObject);
                            break;
                        }
                    }
                }
            }
        }
    }
}

