
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;              
using MonsterNamespace;

[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class PlayerFinder : UdonSharpBehaviour
{     
    public MonsterNamespace.Monster 몬스터;
    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {   //플레이어감지
        if (player == Networking.LocalPlayer)
        {
            몬스터.플레이어감지트리거Enter();
            Debug.Log("플레이어 쫒아감");
        }
          
    }
    public override void OnPlayerTriggerExit(VRCPlayerApi player)
    {
        //플레이어범위벗어남
        if (player == Networking.LocalPlayer)
        {
            몬스터.플레이어감지트리거Exit();
            Debug.Log("플레이어를 쫒아가지 않음");
        }
    }       
}
