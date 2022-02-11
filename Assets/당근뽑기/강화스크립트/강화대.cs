
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using 회수박스네임스페이스;


namespace 강화대네임스페이스
{
    public class 강화대 : UdonSharpBehaviour
    {

        public 회수박스 회수박스데이터;
        [UdonSynced] public byte[] s;
        void Start()
        {
            /* if (other.name.Contains(회수박스데이터.회수박스이름))
             {
                 if (Networking.IsOwner(this.gameObject))
                 {
                     s = 랜덤뽑기();
                     SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "메테리얼" + s.ToString());
                 }
             }      */
        }
        public override void OnPlayerJoined(VRCPlayerApi player)
        {
            if (Networking.IsOwner(회수박스데이터.gameObject))
                SendCustomEventDelayedSeconds("싱크", 1f);
            if (Networking.LocalPlayer == player)
            {
                SendCustomEventDelayedSeconds("스스로싱크", 1f);
            }
        }
        public void 스스로싱크()
        {
            for (byte i = 0; i < 회수박스데이터.큐브.Length; i++)
            {
                ((MeshRenderer)회수박스데이터.큐브[i].GetComponent(typeof(MeshRenderer))).material = 회수박스데이터.메티리얼6개[s[i]];
            }
        }
        public void 싱크()
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "전체싱크");
        }
        public void 전체싱크()
        {
            for (byte i = 0; i < 회수박스데이터.큐브.Length; i++)
            {
                ((MeshRenderer)회수박스데이터.큐브[i].GetComponent(typeof(MeshRenderer))).material = 회수박스데이터.메티리얼6개[s[i]];
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.name.Contains(회수박스데이터.큐브이름))
            {
                if (Networking.IsOwner(this.gameObject))
                {
                    for (int i = 0; i < 회수박스데이터.큐브.Length; i++)
                    {
                        if (회수박스데이터.큐브[i].name == other.gameObject.name)
                        {
                            if (!(s[i] == 5))
                            {
                                s[i] = 랜덤뽑기();
                                ((MeshRenderer)회수박스데이터.큐브[i].GetComponent(typeof(MeshRenderer))).material = 회수박스데이터.메티리얼6개[s[i]];
                                SendCustomEvent("콜라이더끄기");
                                SendCustomEventDelayedSeconds("콜라이더켜기", 1f);
                            }
                        }
                    }
                    RequestSerialization();
                }
                else
                {
                    SendCustomEvent("콜라이더끄기");
                    SendCustomEventDelayedSeconds("콜라이더켜기", 1f);
                }
            }
        }
        public void 콜라이더끄기()
        {
            ((MeshRenderer)this.gameObject.GetComponent(typeof(MeshRenderer))).material = 회수박스데이터.강화불가메테리얼;
            ((BoxCollider)this.gameObject.GetComponent(typeof(BoxCollider))).enabled = false;
        }
        public void 콜라이더켜기딜레이()
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "콜라이더켜기");
        }
        public void 콜라이더켜기()
        {
            ((MeshRenderer)this.gameObject.GetComponent(typeof(MeshRenderer))).material = 회수박스데이터.강화가능메테리얼;
            ((BoxCollider)this.gameObject.GetComponent(typeof(BoxCollider))).enabled = true;
        }
        public override void OnDeserialization()
        {
            for (byte i = 0; i < 회수박스데이터.큐브.Length; i++)
            {
                ((MeshRenderer)회수박스데이터.큐브[i].GetComponent(typeof(MeshRenderer))).material = 회수박스데이터.메티리얼6개[s[i]];
            }
        }

        private byte 랜덤뽑기()
        {
            int 랜덤수 = 0;
            랜덤수 = UnityEngine.Random.Range(0, 101);

            if (랜덤수 >= 99) //100~99
                return 5;
            if (랜덤수 >= 90)  //95~85
                return 4;
            if (랜덤수 > 70)   //85~70
                return 3;
            if (랜덤수 > 50)  //70~50
                return 2;
            if (50 > 랜덤수) //50~0;
                return 1;
            return 1;
        }

    }
}