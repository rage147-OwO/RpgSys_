
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

namespace PurabeWorks
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class GlobalPlayerAudioOverride : UdonSharpBehaviour
    {
        [SerializeField] private int maxPlayerNumber = 50;

        [Header("Voice")]
        [SerializeField] public float voiceGain = 15;
        [SerializeField] public float voiceDistanceNear = 0;
        [SerializeField] public float voiceDistanceFar = 25;
        [SerializeField] public float voiceVolumetricRadius = 0;
        [SerializeField] public bool voiceLowPass = true;

        [Header("Avatar")]
        [SerializeField] public float avatarAudioGainLimit = 10;
        [SerializeField] public float avatarAudioFarRadiusLimit = 40;
        [SerializeField] public float avatarAudioNearRadiusLimit = 40;
        [SerializeField] public float avatarAudioVolumetricRadiusLimit = 40;
        [SerializeField] public bool avatarAudioForceSpacial = false;
        [SerializeField] public bool avatarAudioCustomCurve = true;

        private VRCPlayerApi[] allPlayers;

        private void Start()
        {
            //全プレイヤー情報の格納領域を確保
            allPlayers = new VRCPlayerApi[maxPlayerNumber];
        }

        public override void OnPlayerJoined(VRCPlayerApi player)
        {
            //全プレイヤー情報を取得
            VRCPlayerApi.GetPlayers(allPlayers);

            foreach (VRCPlayerApi p in allPlayers)
            {
                if (p == null || p == Networking.LocalPlayer) continue;

                //ボイス情報設定
                player.SetVoiceGain(voiceGain);
                player.SetVoiceDistanceNear(voiceDistanceNear);
                player.SetVoiceDistanceFar(voiceDistanceFar);
                player.SetVoiceVolumetricRadius(voiceVolumetricRadius);
                player.SetVoiceLowpass(voiceLowPass);
                //アバター音情報設定
                player.SetAvatarAudioGain(avatarAudioGainLimit);
                player.SetAvatarAudioFarRadius(avatarAudioFarRadiusLimit);
                player.SetAvatarAudioNearRadius(avatarAudioNearRadiusLimit);
                player.SetAvatarAudioForceSpatial(avatarAudioForceSpacial);
                player.SetAvatarAudioCustomCurve(avatarAudioCustomCurve);
            }
        }
    }
}