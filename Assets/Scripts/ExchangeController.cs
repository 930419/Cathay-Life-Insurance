using UnityEngine;
using TMPro;

public class ExchangeController : MonoBehaviour
{
    [SerializeField] GameObject back;
    public TextMeshProUGUI exchangetext;
    [SerializeField] GameObject yes;
    [SerializeField] GameObject no;
    public ConditionController conditioncontroller;
    [SerializeField] int prob;
    public MoneyController moneyController;
    [SerializeField] GameObject exchangei;
    [SerializeField] GameObject exchangen;
    public TextMeshProUGUI exchangetext1;
    public TextMeshProUGUI exchangetext2;
    public TextMeshProUGUI exchangetext3;
    public TextMeshProUGUI exchangetext4;
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
        if (collision.gameObject.tag == "Player" && conditioncontroller.exchange)
        {
            back.SetActive(true);
            exchangetext.gameObject.SetActive(true);
            yes.SetActive(true);
            no.SetActive(true);
            Time.timeScale = 0f;
            conditioncontroller.condition = 3;
            buttonController.hasTriggered = false;
            buttonController.hasOK = false;
        }
    }
    public void exchangeyesi()
    {
        prob = Random.Range(1, 101);
        exchangetext1 = exchangei.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        exchangetext2 = exchangei.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        exchangetext3 = exchangei.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        exchangetext4 = exchangei.transform.GetChild(3).GetComponent<TextMeshProUGUI>();
        if (prob < 30)
        {
            moneyController.money -= 1000;
            back.SetActive(true);
            exchangetext1.gameObject.SetActive(true);
            check.SetActive(true);
            ok.SetActive(true);
        }
        else if (prob < 55)
        {
            moneyController.money -= 2000;
            back.SetActive(true);
            exchangetext2.gameObject.SetActive(true);
            check.SetActive(true);
            ok.SetActive(true);
        }
        else if (prob < 75)
        {
            moneyController.money -= 2500;
            back.SetActive(true);
            exchangetext3.gameObject.SetActive(true);
            check.SetActive(true);
            ok.SetActive(true);
        }
        else
        {
            back.SetActive(true);
            exchangetext4.gameObject.SetActive(true);
            luck.SetActive(true);
            ok.SetActive(true);
        }
        Time.timeScale = 0f;
    }

    public void exchangenoi()
    {
        prob = Random.Range(1, 101);
        exchangetext1 = exchangen.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        exchangetext2 = exchangen.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        exchangetext3 = exchangen.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        exchangetext4 = exchangen.transform.GetChild(3).GetComponent<TextMeshProUGUI>();
        if (prob < 30)
        {
            moneyController.money -= 3000;
            back.SetActive(true);
            exchangetext1.gameObject.SetActive(true);
            moneyfly.SetActive(true);
            ok.SetActive(true);
        }
        else if (prob < 55)
        {
            moneyController.money -= 6000;
            back.SetActive(true);
            exchangetext2.gameObject.SetActive(true);
            moneyfly.SetActive(true);
            ok.SetActive(true);
        }
        else if (prob < 75)
        {
            moneyController.money -= 13500;
            back.SetActive(true);
            exchangetext3.gameObject.SetActive(true);
            moneyfly.SetActive(true);
            ok.SetActive(true);
        }
        else
        {
            back.SetActive(true);
            exchangetext4.gameObject.SetActive(true);
            luck.SetActive(true);
            ok.SetActive(true);
        }
        Time.timeScale = 0f;
    }
}
