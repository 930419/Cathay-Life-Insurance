using UnityEngine;
using TMPro;
using Unity.VisualScripting;
public class FriendController : MonoBehaviour
{
    [SerializeField] GameObject back;
    public TextMeshProUGUI friendtext;
    [SerializeField] GameObject yes;
    [SerializeField] GameObject no;
    public ConditionController conditioncontroller;
    [SerializeField] int prob;
    public MoneyController moneyController;
    [SerializeField] GameObject friendi;
    [SerializeField] GameObject friendn;
    public TextMeshProUGUI friendtext1;
    public TextMeshProUGUI friendtext2;
    public TextMeshProUGUI friendtext3;
    public TextMeshProUGUI friendtext4;
    [SerializeField] GameObject moneyfly;
    [SerializeField] GameObject luck;
    [SerializeField] GameObject check;
    [SerializeField] GameObject ok;
    public ButtonController buttonController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && conditioncontroller.friend)
        {
            back.SetActive(true);
            friendtext.gameObject.SetActive(true);
            yes.SetActive(true);
            no.SetActive(true);
            Time.timeScale = 0f;
            conditioncontroller.condition = 1;
            buttonController.hasTriggered = false;
            buttonController.hasOK = false;
        }
    }
    public void friendyesi()
    {
        prob = Random.Range(1, 101);
        friendtext1 = friendi.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        friendtext2 = friendi.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        friendtext3 = friendi.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        friendtext4 = friendi.transform.GetChild(3).GetComponent<TextMeshProUGUI>();
        if (prob < 30)
        {
            moneyController.money -= 200;
            back.SetActive(true);
            friendtext1.gameObject.SetActive(true);
            check.SetActive(true);
            ok.SetActive(true);
        }
        else if (prob < 55)
        {
            moneyController.money -= 800;
            back.SetActive(true);
            friendtext2.gameObject.SetActive(true);
            check.SetActive(true);
            ok.SetActive(true);
        }
        else if (prob < 75)
        {
            moneyController.money -= 1500;
            back.SetActive(true);
            friendtext3.gameObject.SetActive(true);
            check.SetActive(true);
            ok.SetActive(true);
        }
        else
        {
            back.SetActive(true);
            friendtext4.gameObject.SetActive(true);
            luck.SetActive(true);
            ok.SetActive(true);
        }
        Time.timeScale = 0f;
    }

    public void friendnoi()
    {
        prob = Random.Range(1, 101);
        friendtext1 = friendn.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        friendtext2 = friendn.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        friendtext3 = friendn.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        friendtext4 = friendn.transform.GetChild(3).GetComponent<TextMeshProUGUI>();
        if (prob < 30)
        {
            moneyController.money -= 1000;
            back.SetActive(true);
            friendtext1.gameObject.SetActive(true);
            moneyfly.SetActive(true);
            ok.SetActive(true);
        }
        else if (prob < 55)
        {
            moneyController.money -= 5000;
            back.SetActive(true);
            friendtext2.gameObject.SetActive(true);
            moneyfly.SetActive(true);
            ok.SetActive(true);
        }
        else if (prob < 75)
        {
            moneyController.money -= 10000;
            back.SetActive(true);
            friendtext3.gameObject.SetActive(true);
            moneyfly.SetActive(true);
            ok.SetActive(true);
        }
        else
        {
            back.SetActive(true);
            friendtext4.gameObject.SetActive(true);
            luck.SetActive(true);
            ok.SetActive(true);
        }
        Time.timeScale = 0f;
    }
}
