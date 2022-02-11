
using UdonSharp;
using UnityEngine;
using VRC.SDK3.Components;
using VRC.SDKBase;
using VRC.Udon;
using 강화대네임스페이스;
namespace 회수박스네임스페이스
{
    public class 회수박스 : UdonSharpBehaviour
    {
        public 강화대 강화대데이터;
        public Material[] 메티리얼6개;
        public GameObject[] 큐브;
        public Material 기본메테리얼;
        public Material 강화가능메테리얼;
        public Material 강화불가메테리얼;

        public string 회수박스이름;
        public string 강화대이름;
        public string 큐브이름;


        public override void Interact()
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "스폰");
        }
        public void 스폰()
        {
            bool 꺼진당근이있음 = false;


            for (int i = 0; i < 큐브.Length; i++)
            {
                if (!큐브[i].activeInHierarchy)
                {
                    꺼진당근이있음 = true;
                    break;
                }
            }

            if (꺼진당근이있음)
            {
                if (Networking.IsOwner(this.gameObject))
                {
                    ((VRCObjectPool)this.GetComponent(typeof(VRCObjectPool))).TryToSpawn();
                }
            }

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.name.Contains(큐브이름))
            {
                ((VRC_Pickup)other.gameObject.GetComponent(typeof(VRC_Pickup))).Drop();
                for (int i = 0; i < 큐브.Length; i++)
                {
                    if (큐브[i].name == other.name)
                    {
                        강화대데이터.s[i] = 0;
                    }
                }

                if (Networking.IsOwner(this.gameObject))
                {
                    ((VRCObjectPool)this.GetComponent(typeof(VRCObjectPool))).Return(other.gameObject);
                }
            }
        }
    }
}


