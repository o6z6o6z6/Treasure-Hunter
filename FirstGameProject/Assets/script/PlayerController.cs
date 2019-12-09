using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region
    [Header("速度"), Range(0f, 100f)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(100, 2000)]
    public int jumpHigh = 300;
    [Header("是否在地上")]
    public bool isGround = false;
    [Header("玩家名稱")]
    public string userName = "hello";
    [Header("2D 剛體")]
    public Rigidbody2D r2d;
    public Animator ani;
    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip soundDiamond;
    #endregion

}
