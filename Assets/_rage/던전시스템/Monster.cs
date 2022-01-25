
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using UnityEngine.UI;

[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class Monster : UdonSharpBehaviour
{
    const int 무기A데미지 = 40;
    const int 무기B데미지 = 60;
    const int 무기C데미지 = 100;

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
        PlayerTracking = true;
        this.transform.position = new Vector3(this.transform.position.x, 메인.몬스터스폰위치중앙.position.y, this.transform.position.z);

    }
    public void 플레이어감지트리거Exit()
    {
        PlayerTracking = false;
        몬스터애니메이션.Rebind();
        몬스터애니메이션.Play(이름_대기애니메이션, -1);
        this.transform.position = new Vector3(this.transform.position.x, 메인.몬스터스폰위치중앙.position.y, this.transform.position.z);


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


    #region 몬스터활성화/비활성화/초기설정
    private void Start()
    {
        몬스터애니메이션 = (Animator)this.gameObject.GetComponent(typeof(Animator));
        HpBar.maxValue = 몬스터_최대체력;
        몬스터_몬스터체력 = 몬스터_최대체력;
        HpBar.value = 몬스터_최대체력;
    }
    private void OnEnable()   //스폰돼면
    {
        종료 = false;
        HpBar.value = 몬스터_최대체력;
        몬스터애니메이션 = (Animator)this.gameObject.GetComponent(typeof(Animator));
        몬스터_몬스터체력 = 몬스터_최대체력;
        몬스터애니메이션.applyRootMotion = false;
        플레이어가콜라이더안에있음 = false;
        몬스터_기본공격쿨타임중 = false;
        몬스터애니메이션.Rebind();
        몬스터애니메이션.Play(이름_대기애니메이션, -1);
        PlayerPosition = Networking.LocalPlayer.GetPosition();

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


    #region 무기판정


    //무기판정
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("weapon"))
        {
            SetHpBar();
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
        }
    }
    #endregion

    void 몬스터_사망()
    {
        당근스폰(this.transform.position);
        메인.몬스터죽음();
        this.gameObject.SetActive(false);
    }
    void 당근스폰(Vector3 위치)
    {
        foreach (var 당근 in 메인.당근데이터)
        {
            if (당근.activeInHierarchy == false)
            {
                Debug.Log("당근스폰");
                당근.SetActive(true);
                당근.transform.position = 위치;
                break;
            }
        }
    }
}