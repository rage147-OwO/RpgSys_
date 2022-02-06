
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class RoomEnter : UdonSharpBehaviour
{
    public MonsterRoomMain 메인;
    public Animator 페이드아웃;
    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        페이드아웃.Play("페이드아웃1", -1, 0f);
    }
    public void Enter()
    {
            메인.방입장();
    }

}
