
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;
using VRC.SDK3.Components;

[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class Monster : UdonSharpBehaviour
{
    const int 무기A데미지 = 40;
    const int 무기B데미지 = 60;
    const int 무기C데미지 = 100;
    const float 몬스터피격쿨타임 = 0.5f;
    bool 피격쿨타임중=false;

    [System.NonSerialized, FieldChangeCallback(nameof(PlayerTracking))] private bool _playerTracking;
    public bool PlayerTracking
    {
        get => _playerTracking;
        set
        {
            _playerTracking = value;
            if (_playerTracking)
            {
                몬스터애니메이션.Rebind();
                몬스터애니메이션.Play(이름_달리는애니메이션, -1);
            }
        }
    }   //바뀌면 달려감     
    public MonsterRoomMain 메인;

    public string 이름_대기애니메이션 = string.Empty;
    public string 이름_공격애니메이션 = string.Empty;
    public string 이름_달리는애니메이션 = string.Empty;

    public float 몬스터_공격쿨타임 = 1.5f;



    bool 몬스터_기본공격쿨타임중;
    bool 플레이어가콜라이더안에있음;

    Animator 몬스터애니메이션;
    Vector3 PlayerPosition;



    public Slider HpBar;
    public int 몬스터_공격력 = 10;
    public int 몬스터_최대체력 = 100;
    int 몬스터_몬스터체력 = 100;
    [SerializeField] float 몬스터_이동속도 = 0.02f;
    bool 종료;
    float Timer = 2;    //fixedupdate에서 도는 타이머    
    Vector3 O_pos;
    bool check;


    public void 몬스터1이죽었을경우()         //몬스터가 죽으면 Ui에 넣기
    {
        오브젝트0스폰();
    }
    public void 몬스터2이죽었을경우()
    {
        오브젝트1스폰();
    }



    void 오브젝트0스폰()
    {
        foreach (var 오브젝트 in 메인.몬스터가죽고나서드랍되는오브젝트0)
        {
            if (오브젝트.activeInHierarchy == false)
            {
                오브젝트.SetActive(true);
                오브젝트.transform.position = this.transform.position;
                if (Networking.LocalPlayer.IsUserInVR())
                {
                    메인.인벤토리메인.VR.SpawnButton(메인.오브젝트풀0, 오브젝트.name.Remove(오브젝트.name.Length - 3));
                }
                else
                {
                    메인.인벤토리메인.Deskop.SpawnButton(메인.오브젝트풀0, 오브젝트.name.Remove(오브젝트.name.Length - 3));
                }
                break;
            }
        }
    }
    void 오브젝트1스폰()
    {
        foreach (var 오브젝트 in 메인.몬스터가죽고나서드랍되는오브젝트1)
        {
            if (오브젝트.activeInHierarchy == false)
            {
                오브젝트.SetActive(true);
                오브젝트.transform.position = this.transform.position;
                if (Networking.LocalPlayer.IsUserInVR())
                {
                    메인.인벤토리메인.VR.SpawnButton(메인.오브젝트풀1, 오브젝트.name.Remove(오브젝트.name.Length - 3));
                }
                else
                {
                    메인.인벤토리메인.Deskop.SpawnButton(메인.오브젝트풀1, 오브젝트.name.Remove(오브젝트.name.Length - 3));
                }
                break;
            }
        }
    }
    private void FixedUpdate()
    {
        PlayerPosition = Networking.LocalPlayer.GetPosition();
        HpBar.transform.LookAt(PlayerPosition);
        if (PlayerTracking)
        {
            if (Timer > 1)     //1초에한번씩실행
            {
                transform.LookAt(new Vector3(PlayerPosition.x, PlayerPosition.y, PlayerPosition.z));
                Timer = 0;
            }
            transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(PlayerPosition.x, this.gameObject.transform.position.y, PlayerPosition.z), 몬스터_이동속도);
            Timer = Timer + Time.deltaTime;
        }
    }

    #region 플레이어감지와공격
    public void 플레이어감지트리거Enter()
    {
        check = true;
        PlayerTracking = true;
        this.transform.position = new Vector3(this.transform.position.x, 메인.몬스터스폰위치중앙.position.y, this.transform.position.z);

    }
    public void 플레이어감지트리거Exit()
    {
        check = false;
        몬스터애니메이션.Rebind();
        몬스터애니메이션.Play(이름_대기애니메이션, -1);
        this.transform.position = new Vector3(this.transform.position.x, 메인.몬스터스폰위치중앙.position.y, this.transform.position.z);
        PlayerTracking = false;
        플레이어가콜라이더안에있음 = false;
    }

    //플레이어가 공격범위 안에 들어오면       
    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        if (player == Networking.LocalPlayer)
        {
            플레이어가콜라이더안에있음 = true;
            if (!몬스터_기본공격쿨타임중)                                        
            {
                몬스터_기본공격쿨타임중 = true;
                PlayerTracking = false;
                몬스터_공격();
                SendCustomEventDelayedSeconds("공격쿨타임", 몬스터_공격쿨타임);
            }
        }
    }
    public void 공격쿨타임()
    {
        if (check)
        {
            몬스터_기본공격쿨타임중 = false;
            if (플레이어가콜라이더안에있음)
            {
                OnPlayerTriggerEnter(Networking.LocalPlayer);
            }
            else
            {
                PlayerTracking = true;
            }
        }
    }
    void 몬스터_공격()
    {
        몬스터애니메이션.Rebind();
        PlayerPosition = Networking.LocalPlayer.GetPosition();
        transform.LookAt(new Vector3(PlayerPosition.x, PlayerPosition.y, PlayerPosition.z));
        몬스터애니메이션.Play(이름_공격애니메이션, -1);
        if (!종료)
        {
            if (메인.체력_현재플레이어체력 >= 0)
            {
                메인.체력_현재플레이어체력 = 메인.체력_현재플레이어체력 - 몬스터_공격력;
                메인.플레이어체력업데이트();
            }
        }
    }
    public override void OnPlayerTriggerExit(VRCPlayerApi player)
    {
        if (player == Networking.LocalPlayer)
        {
            플레이어가콜라이더안에있음 = false;
        }
    }
    #endregion
    void SetHpBar()
    {
        HpBar.value = 몬스터_몬스터체력;
    }


    #region 몬스터활성화,스타트,인에이블
    private void Start()
    {
        O_pos = this.transform.position;
        몬스터애니메이션 = (Animator)this.gameObject.GetComponent(typeof(Animator));
        HpBar.maxValue = 몬스터_최대체력;
        몬스터_몬스터체력 = 몬스터_최대체력;
        HpBar.value = 몬스터_최대체력;
    }
    private void OnEnable()   //스폰돼면
    {
        if (O_pos == null)
        {
            O_pos = this.transform.position;
        }
        else
        {
            this.gameObject.transform.position = O_pos;
        }
        종료 = false;
        피격쿨타임중 = false;
        HpBar.value = 몬스터_최대체력;
        몬스터애니메이션 = (Animator)this.gameObject.GetComponent(typeof(Animator));
        몬스터_몬스터체력 = 몬스터_최대체력;
        몬스터애니메이션.applyRootMotion = false;
        플레이어가콜라이더안에있음 = false;
        몬스터_기본공격쿨타임중 = false;
        몬스터애니메이션.Rebind();
        몬스터애니메이션.Play(이름_대기애니메이션, -1);
        PlayerPosition = Networking.LocalPlayer.GetPosition();
        PlayerTracking = false;

    }
    public void MonsterDisEnable()  //비활성화
    {
        몬스터애니메이션 = (Animator)this.gameObject.GetComponent(typeof(Animator));
        종료 = false;
        몬스터_몬스터체력 = 몬스터_최대체력;
        HpBar.value = 몬스터_최대체력;
        플레이어가콜라이더안에있음 = false;
        몬스터_기본공격쿨타임중 = false;
        몬스터애니메이션.Rebind();
        this.gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        종료 = true;
    }
    #endregion

    #region "무기판정 온트리거엔터"


    //무기판정
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("weapon"))
        {
            if (!피격쿨타임중)
            {
                if (Networking.GetOwner(other.gameObject)==Networking.LocalPlayer)
                {
                    if (other.name.Contains("A"))
                    {
                        몬스터_몬스터체력 = 몬스터_몬스터체력 - 무기A데미지;
                    }
                    else if (other.name.Contains("B"))
                    {
                        몬스터_몬스터체력 = 몬스터_몬스터체력 - 무기B데미지;
                    }
                    else if (other.name.Contains("C"))
                    {
                        몬스터_몬스터체력 = 몬스터_몬스터체력 - 무기C데미지;
                    }
                    if (몬스터_몬스터체력 < 0)
                    {
                        몬스터_사망();
                    }
                    SetHpBar();
                    피격쿨타임중 = true;
                    SendCustomEventDelayedSeconds("피격쿨타임돌리기", 몬스터피격쿨타임);
                }
            
            }
        }
    }
    public void 피격쿨타임돌리기()
    {
        피격쿨타임중 = false;
    }
    #endregion

    void 몬스터_사망()
    {
        if (this.name[name.Length - 5] == '1')
        {
            몬스터1이죽었을경우();
        }
        if (this.name[name.Length - 5] == '2')
        {
            몬스터2이죽었을경우();
        }
        메인.몬스터리스폰(this.gameObject);                      
        this.gameObject.SetActive(false);
    }

    public void 티켓스폰()
    {

    }

}