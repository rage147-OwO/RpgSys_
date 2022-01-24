
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

namespace WeaponNamespace
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class weapon : UdonSharpBehaviour
    {
        const float 간격 = 0.1f;
        Vector3 O_Position;
        Vector3 N_Position;
        float 가로 = 0;
        float 세로=0;
        bool IsVR;
        private void Start()
        {
            O_Position = this.gameObject.transform.localPosition;
            ((Rigidbody)this.gameObject.GetComponent(typeof(Rigidbody))).isKinematic = true;
        }
        public void Right()
        {
            가로 = 가로 + 간격;
            this.gameObject.transform.localPosition = new Vector3(O_Position.x+가로,O_Position.y+세로,0);
        }
        public void Left()
        {
            가로 = 가로 - 간격;
            this.gameObject.transform.localPosition = new Vector3(O_Position.x + 가로, O_Position.y + 세로, 0);
        }
        public void Up()
        {
            세로 = 세로 + 간격;
            this.gameObject.transform.localPosition = new Vector3(O_Position.x + 가로, O_Position.y + 세로, 0);
        }
        public void Down()
        {
            세로 = 세로 - 간격;
            this.gameObject.transform.localPosition = new Vector3(O_Position.x + 가로, O_Position.y + 세로, 0);
        }
    }
}

