
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class 직원용트리거 : UdonSharpBehaviour
{
    [SerializeField] private string[] CatName;
    [SerializeField] private GameObject[] TargetObject;
    private bool Cat = false;
    void Start()
    {
        foreach (string Player in CatName)
        {
            if (Networking.LocalPlayer.displayName == Player)
            {
                Cat = true;
            }
        }
        foreach (GameObject Target in TargetObject)
        {
            Target.SetActive(Cat);
        }
    }
}
