
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class 당근강화 : UdonSharpBehaviour
{
    public Material[] 메테리얼6개;

    [UdonSynced] int 동기화강화단계;
    int 로컬강화단계;
    [UdonSynced] public bool 동기화메쉬;
    public bool 로컬메쉬;
    public GameObject 강화대오브젝트;
    public GameObject 회수대오브젝트;

    public void 메테리얼세팅(int 숫자)
    {
        ((MeshRenderer)this.GetComponent(typeof(MeshRenderer))).material = 메테리얼6개[숫자];
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Networking.IsOwner(this.gameObject))
        {
            if (other.gameObject == 강화대오브젝트)
            {
                동기화강화단계 = 랜덤뽑기();
                로컬강화단계 = 동기화강화단계;
                메테리얼세팅(동기화강화단계);
            }

            if (other.gameObject == 회수대오브젝트)
            {
                VRC_Pickup temp_pickup = (VRC_Pickup)this.gameObject.GetComponent(typeof(VRC_Pickup));
                temp_pickup.Drop();
                동기화강화단계 = 0;
                로컬강화단계 = 동기화강화단계;
                메테리얼세팅(동기화강화단계);
                this.GetComponent<MeshRenderer>().enabled = false;
                동기화메쉬 = false;
                로컬메쉬 = 동기화메쉬;
            }
        }
    }

    public override void OnDeserialization()
    {
        if (로컬강화단계 != 동기화강화단계)
        {
            메테리얼세팅(동기화강화단계);
            로컬강화단계 = 동기화강화단계;
        }
        if (로컬메쉬 != 동기화메쉬)
        {
            this.GetComponent<MeshRenderer>().enabled = 동기화메쉬;
            로컬메쉬 = 동기화메쉬;
        }
    }

    private int 랜덤뽑기()
    {
        int 랜덤수 = 0;
        랜덤수 = UnityEngine.Random.Range(0, 101);

        if (랜덤수 > 0) //50~0;
            return 1;
        if (랜덤수 > 50)  //70~50
            return 2;
        if (랜덤수 > 70)   //85~70
            return 3;
        if (랜덤수 >= 85)  //95~85
            return 4;
        if (랜덤수 >= 95) //100~95
            return 5;
        return 5;
    }
}
