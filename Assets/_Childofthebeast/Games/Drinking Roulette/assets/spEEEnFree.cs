
using System.Collections;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

namespace Childofthebeast.Games.speen
{
    public class spEEEn : UdonSharpBehaviour
    {
        [UdonSynced] public float rotation = 3.75f;
        private Transform Arrow;
        private float wait = 0;
        private int OldSpeen;
        private int ThisSpeen;
        private Vector3 targetrotation = new Vector3(3.75f, 00, 00);
        private Animator animate;
        private void Start()
        {
            Arrow = transform.GetChild(0);
            animate = transform.GetComponent<Animator>();
        }
        public override void Interact()
        {
            SyncSpeen();
        }
        private void Update()
        {
            if (wait > 0)
            {
                wait -= Time.deltaTime;
            }
            if (transform.eulerAngles.x != rotation)
            {
                targetrotation.x = rotation;
                transform.eulerAngles = targetrotation;
            }
        }
        public void Speen()
        {
            if (wait <= 0)
            {
                SendCustomNetworkEvent(NetworkEventTarget.All, "SetWait");
                SendCustomNetworkEvent(NetworkEventTarget.Owner, "SyncSpeen");
            } else
            {
                Debug.LogWarning("SPEEN: Speen > 0");
            }
        }
        public void SyncSpeen()
        {
            ThisSpeen = Random.Range(0, 48);
            rotation = 3.75f + (7.5f * ThisSpeen);
        }
        public void SetWait()
        {
            animate.SetTrigger("SPEEN");
            wait = 3;
        }

    }
}