
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class RoomEnter : UdonSharpBehaviour
{
    public MonsterRoomMain 메인;

    public override void Interact()
    {
        메인.방입장();
    }


}
