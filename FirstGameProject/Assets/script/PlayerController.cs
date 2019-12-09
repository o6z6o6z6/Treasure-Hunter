using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region
    [Header("速度"), Range(0f, 100f)]
    public float speed = 35f;
    [Header("跳躍高度"), Range(100, 2000)]
    public int jumpHigh = 1800;
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
    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        r2d.AddForce(new Vector2(speed * h, 0));
        ani.SetBool("Walk", h != 0);
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGround == true)
        {
            isGround = false;
            r2d.AddForce(new Vector2(0, jumpHigh));
            ani.SetTrigger("Jump");
        }
    }

    private void Update()
    {
        Move();
        Jump();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Tilemap")
        {
            isGround = true;
        }
    }
}
