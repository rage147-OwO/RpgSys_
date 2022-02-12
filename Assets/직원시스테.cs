
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class 직원시스테 : UdonSharpBehaviour
{
    [SerializeField] private string[] CatName;
    [SerializeField] private GameObject[] TargetObject;
    private bool Cat = true;
    void Start()
    {
        foreach (string Player in CatName)
        {
            if (Networking.LocalPlayer.displayName == Player)
            {
                Cat = false;
            }
        }
        foreach (GameObject Target in TargetObject)
        {
            Target.SetActive(Cat);
        }
    }
}
