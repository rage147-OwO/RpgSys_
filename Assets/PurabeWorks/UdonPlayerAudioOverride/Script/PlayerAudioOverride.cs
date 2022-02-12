
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

namespace PurabeWorks
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class PlayerAudioOverride : UdonSharpBehaviour
    {
        [SerializeField] private GlobalPlayerAudioOverride global;

        [Header("Voice")]
        [SerializeField] private float voiceGain = 15;
        [SerializeField] private float voiceDistanceNear = 0;
        [SerializeField] private float voiceDistanceFar = 25;
        [SerializeField] private float voiceVolumetricRadius = 0;
        [SerializeField] private bool voiceLowPass = true;

        [Header("Avatar")]
        [SerializeField] private float avatarAudioGainLimit = 10;
        [SerializeField] private float avatarAudioFarRadiusLimit = 40;
        [SerializeField] private float avatarAudioNearRadiusLimit = 40;
        [SerializeField] private float avatarAudioVolumetricRadiusLimit = 40;
        [SerializeField] private bool avatarAudioForceSpacial = false;
        [SerializeField] private bool avatarAudioCustomCurve = true;

        //Voice Default
        private float defaultVoiceGain = 15;
        private float defaultVoiceDistanceNear = 0;
        private float defaultVoiceDistanceFar = 25;
        private float defaultVoiceVolumetricRadius = 0;
        private bool defaultVoiceLowPass = true;
        //Avatar Audio Default
        private float defaultAvatarAudioGainLimit = 10;
        private float defaultAvatarAudioFarRadiusLimit = 40;
        private float defaultAvatarAudioNearRadiusLimit = 40;
        private float defaultAvatarAudioVolumetricRadiusLimit = 40;
        private bool defaultAvatarAudioForceSpacial = false;
        private bool defaultAvatarAudioCustomCurve = true;


        private void Start()
        {
            //Globalが設定されていたらdefault値を取得
            if (global != null)
            {
                //Voice Default
                defaultVoiceGain = global.voiceGain;
                defaultVoiceDistanceNear = global.voiceDistanceNear;
                defaultVoiceDistanceFar = global.voiceDistanceFar;
                defaultVoiceVolumetricRadius = global.voiceVolumetricRadius;
                defaultVoiceLowPass = global.voiceLowPass;
                //Avatar Audio Default
                defaultAvatarAudioGainLimit = global.avatarAudioGainLimit;
                defaultAvatarAudioFarRadiusLimit = global.avatarAudioFarRadiusLimit;
                defaultAvatarAudioNearRadiusLimit = global.avatarAudioNearRadiusLimit;
                defaultAvatarAudioVolumetricRadiusLimit = global.avatarAudioVolumetricRadiusLimit;
                defaultAvatarAudioForceSpacial = global.avatarAudioForceSpacial;
                defaultAvatarAudioCustomCurve = global.avatarAudioCustomCurve;
            }
        }

        public override void OnPlayerTriggerEnter(VRCPlayerApi player)
        {
            SetPlayerAudio(player);
        }

        public override void OnPlayerTriggerStay(VRCPlayerApi player)
        {
            SetPlayerAudio(player);
        }

        public override void OnPlayerTriggerExit(VRCPlayerApi player)
        {
            UnsetPlayerAudio(player);
        }

        //設定値をプレイヤーに反映する
        private void SetPlayerAudio(VRCPlayerApi player)
        {
            if (player == Networking.LocalPlayer) return;

            //Voice
            player.SetVoiceGain(voiceGain);
            player.SetVoiceDistanceNear(voiceDistanceNear);
            player.SetVoiceDistanceFar(voiceDistanceFar);
            player.SetVoiceVolumetricRadius(voiceVolumetricRadius);
            player.SetVoiceLowpass(voiceLowPass);
            //Avatar Audio
            player.SetAvatarAudioGain(avatarAudioGainLimit);
            player.SetAvatarAudioFarRadius(avatarAudioFarRadiusLimit);
            player.SetAvatarAudioNearRadius(avatarAudioNearRadiusLimit);
            player.SetAvatarAudioVolumetricRadius(avatarAudioVolumetricRadiusLimit);
            player.SetAvatarAudioForceSpatial(avatarAudioForceSpacial);
            player.SetAvatarAudioCustomCurve(avatarAudioCustomCurve);
        }

        //デフォルトの値に戻す
        private void UnsetPlayerAudio(VRCPlayerApi player)
        {
            if (player == Networking.LocalPlayer) return;

            //Voice
            player.SetVoiceGain(defaultVoiceGain);
            player.SetVoiceDistanceNear(defaultVoiceDistanceNear);
            player.SetVoiceDistanceFar(defaultVoiceDistanceFar);
            player.SetVoiceVolumetricRadius(defaultVoiceVolumetricRadius);
            player.SetVoiceLowpass(defaultVoiceLowPass);
            //Avatar Audio
            player.SetAvatarAudioGain(defaultAvatarAudioGainLimit);
            player.SetAvatarAudioFarRadius(defaultAvatarAudioFarRadiusLimit);
            player.SetAvatarAudioNearRadius(defaultAvatarAudioNearRadiusLimit);
            player.SetAvatarAudioVolumetricRadius(defaultAvatarAudioVolumetricRadiusLimit);
            player.SetAvatarAudioForceSpatial(defaultAvatarAudioForceSpacial);
            player.SetAvatarAudioCustomCurve(defaultAvatarAudioCustomCurve);
        }
    }
}