
using UdonSharp;
using UnityEngine;
using VRC.SDK3.Components;
using VRC.SDKBase;
using VRC.Udon;

public class rage_당근강화메인 : UdonSharpBehaviour
{    
    public Material[] 메테리얼6개 = new Material[6];
    public VRCObjectPool 당근오브젝트풀;

    public byte 랜덤뽑기()
    {
        int 랜덤수 = 0;
        랜덤수 = UnityEngine.Random.Range(0, 100);

        if (랜덤수 >= 99) //99
            return 5;
        if (랜덤수 >= 92)  //98~92
            return 4;
        if (랜덤수 >= 77)   //91~77
            return 3;
        if (랜덤수 >= 50)  //77~50
            return 2;
        if (50 > 랜덤수) //50~0;
            return 1;
        return 1;
    }
}
