
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class 당근 : UdonSharpBehaviour
{
    private float 당근속도 = 0.01f;       
    private void OnEnable()
    {
        SendCustomEventDelayedSeconds("끄기", 3f);
    }
    public void 끄기()
    {
        this.gameObject.SetActive(false);
    }
    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(gameObject.transform.position, Networking.LocalPlayer.GetBonePosition(HumanBodyBones.Spine), 당근속도);

    }
}
