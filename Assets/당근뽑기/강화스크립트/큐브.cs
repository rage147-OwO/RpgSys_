
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using 회수박스네임스페이스;

public class 큐브 : UdonSharpBehaviour
{
    public 회수박스 회수박스데이터;
    private void OnEnable()
    {
        ((MeshRenderer)this.gameObject.GetComponent(typeof(MeshRenderer))).material = 회수박스데이터.기본메테리얼;
    }
}
