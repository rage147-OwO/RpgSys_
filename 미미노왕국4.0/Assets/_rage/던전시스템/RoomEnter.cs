
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using MonsterRoomMainNamespace;
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class RoomEnter : UdonSharpBehaviour
{
    public MonsterRoomMainNamespace.MonsterRoomMain 메인;

    public override void Interact()
    {
        메인.방입장();
    }


}
