using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Vector2 touchStartPos;
    private Vector2 touchDirection;
    private bool isTouching = false;
    public TextMeshProUGUI moneytext;
    public MoneyController moneycontroller;
    void Start()
    {
        moneytext.text = moneycontroller.money.ToString();
    }

    void Update()
    {
        Vector2 moveDir = Vector2.zero;

        // 手機觸控處理
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Began)
            {
                touchStartPos = touch.position;
                isTouching = true;
            }
            else if (touch.phase == TouchPhase.Moved && isTouching)
            {
                touchDirection = touch.position - touchStartPos;
                Vector2 dirNormalized = touchDirection.normalized;

                moveDir = dirNormalized; // 直接把觸控方向用作移動方向
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                isTouching = false;
            }
        }

        // 電腦 WASD 控制
        if (Input.GetKey(KeyCode.W)) moveDir += Vector2.up;
        if (Input.GetKey(KeyCode.S)) moveDir += Vector2.down;
        if (Input.GetKey(KeyCode.A)) moveDir += Vector2.left;
        if (Input.GetKey(KeyCode.D)) moveDir += Vector2.right;

        // 實際移動
        transform.Translate(moveDir.normalized * moveSpeed * Time.deltaTime);
    }
}
