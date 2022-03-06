
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
        if (player == Networking.LocalPlayer)
        {
            if (this.gameObject.name.Equals("입장큐브"))
            {
                SendCustomEventDelayedSeconds("Enter", 2f);
            }
            else if (this.gameObject.name.Equals("퇴장큐브"))
            {
                SendCustomEventDelayedSeconds("Exit", 2f);
            }
            페이드아웃.Play("페이드아웃1", -1, 0f);
        }
    }  

    public void Enter()
    {
        메인.방입장();
    }
    public void Exit()
    {         
        메인.방퇴장();
    }

}
