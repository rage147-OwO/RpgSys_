
using System.Collections.Generic;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Yodo_StaffMarker_Controller : UdonSharpBehaviour
{
    [HeaderAttribute("トラッキングモード[0:プレイヤー位置][1:頭ボーン位置][2:腕章(左腕)][3:腕章(右腕)] / Tracking mode[0:Player position][1:Head bone position][2:Armring(Left)][3:Armring(Right)]")]
    public int Yodo_Tracking_Mode = 0;

    [Tooltip("高さのオフセット / Height offset"), HeaderAttribute("高さのオフセット / Height offset")]
    public float Yodo_Height_Offset = 0.0f;

    [Tooltip("スタッフの名前一覧 / List of staff names")]
    public string[] Yodo_Staff_Names;

    private int _staffNum = 0;  //EnumにしたいがNot exposedなので……。
    private Vector3 _heightOffset;
    private int[] _playerIds;
    private VRCPlayerApi[] _staffPlayers;
    private GameObject[] _markers;

    private bool _IsStaffName(string name)
    {
        foreach (string list in Yodo_Staff_Names)
        {
            if(list == name)
            {
                return true;
            }
        }
        return false;
    }

    private void _ResetObjects()
    {
        _playerIds = new int[_staffNum];
        _staffPlayers = new VRCPlayerApi[_staffNum];
        _markers = new GameObject[_staffNum];

        for (int cur = 0; cur < _playerIds.Length; cur++)
        {
            _playerIds[cur] = -1;
            _staffPlayers[cur] = null;
        }

        int n = 0;
        foreach (Transform child in this.transform)
        {
            if (_staffNum <= n) { break; }
            _markers[n] = child.gameObject;
            n++;
        }
    }

    private void _RegisterStaff(VRCPlayerApi player)
    {
        for (int cur = 0; cur < _staffNum; cur++)
        {
            if (_playerIds[cur] < 0)
            {
                _playerIds[cur] = player.playerId;
                _staffPlayers[cur] = player;
                break;
            }
        }
    }

    public void Start()
    {
        _staffNum = Yodo_Staff_Names.Length;
        if(_staffNum == 0)
        {
            Debug.LogError("[Yodo]スタッフ名がひとりも登録されていません。1人以上登録してください。\nThere's 0 staff names. Please add 1 or more names.");
        }
        _ResetObjects();

        _heightOffset = new Vector3(0.0f,Yodo_Height_Offset,0.0f);
    }

    public override void OnPlayerJoined(VRCPlayerApi player)
    {
        if(_IsStaffName(player.displayName))
        {
            _RegisterStaff(player);
        }
    }

    public override void OnPlayerLeft(VRCPlayerApi player)
    {
        if(_IsStaffName(player.displayName))
        {
            for(int cur = 0; cur<_staffNum;cur++)
            {
                if(_playerIds[cur] == player.playerId)
                {
                    _playerIds[cur] = -1;
                    _staffPlayers[cur] = null;
                    _markers[cur].transform.position = this.transform.position;
                    break;
                }
            }
        }
    }

    public void Update()
    {
        for(int cur =0; cur<_staffNum;cur++)
        {
            int id = _playerIds[cur];
            if(id < 0) { continue; }
            switch(Yodo_Tracking_Mode)
            {
                case 0: // Player position
                    _markers[cur].transform.position = _staffPlayers[cur].GetPosition() + _heightOffset;
                    break;

                case 1: // Head bone
                    _markers[cur].transform.position = _staffPlayers[cur].GetBonePosition(HumanBodyBones.Head) + _heightOffset;
                    break;

                case 2: // Left
                    _markers[cur].transform.position = Vector3.Lerp(_staffPlayers[cur].GetBonePosition(HumanBodyBones.LeftUpperArm), _staffPlayers[cur].GetBonePosition(HumanBodyBones.LeftLowerArm), 0.5f);
                    _markers[cur].transform.LookAt(_staffPlayers[cur].GetBonePosition(HumanBodyBones.LeftLowerArm));
                    break;

                case 3: // Right
                    _markers[cur].transform.position = Vector3.Lerp(_staffPlayers[cur].GetBonePosition(HumanBodyBones.RightUpperArm), _staffPlayers[cur].GetBonePosition(HumanBodyBones.RightLowerArm), 0.5f);
                    _markers[cur].transform.LookAt(_staffPlayers[cur].GetBonePosition(HumanBodyBones.RightLowerArm));
                    break;

                default:
                    Debug.LogError("[Yodo]トラッキングモードが指定範囲値外です / Tracking mode value is invalid");
                    break;
            }
        }
    }

    public void OnEnable()
    {   // Off→Onされたらリセットする
        _ResetObjects();
        VRCPlayerApi[] players = new VRCPlayerApi[80];
        VRCPlayerApi.GetPlayers(players);
        foreach (VRCPlayerApi player in players)
        {
            if(player == null) { continue; }
            if(_IsStaffName(player.displayName))
            {
                _RegisterStaff(player);
            }
        }
    }

}
