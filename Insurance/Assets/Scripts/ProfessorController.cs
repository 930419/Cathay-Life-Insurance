using UnityEngine;
using TMPro;

public class ProfessorController : MonoBehaviour
{
   [SerializeField] GameObject back;
    public TextMeshProUGUI professortext;
    [SerializeField] GameObject yes;
    [SerializeField] GameObject no;
    public ConditionController conditioncontroller;
    [SerializeField] int prob;
    public MoneyController moneyController;
    [SerializeField] GameObject professori;
    [SerializeField] GameObject professorn;
    public TextMeshProUGUI professortext1;
    public TextMeshProUGUI professortext2;
    public TextMeshProUGUI professortext3;
    public TextMeshProUGUI professortext4;
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
        if (collision.gameObject.tag == "Player" && conditioncontroller.professor)
        {
            back.SetActive(true);
            professortext.gameObject.SetActive(true);
            yes.SetActive(true);
            no.SetActive(true);
            Time.timeScale = 0f;
            conditioncontroller.condition = 2;
            buttonController.hasTriggered = false;
            buttonController.hasOK = false;
        }
    }
    public void professoryesi()
    {
        prob = Random.Range(1, 101);
        professortext1 = professori.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        professortext2 = professori.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        professortext3 = professori.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        professortext4 = professori.transform.GetChild(3).GetComponent<TextMeshProUGUI>();
        if (prob < 30)
        {
            moneyController.money -= 500;
            back.SetActive(true);
            professortext1.gameObject.SetActive(true);
            check.SetActive(true);
            ok.SetActive(true);
        }
        else if (prob < 55)
        {
            moneyController.money -= 2000;
            back.SetActive(true);
            professortext2.gameObject.SetActive(true);
            check.SetActive(true);
            ok.SetActive(true);
        }
        else if (prob < 75)
        {
            moneyController.money -= 3000;
            back.SetActive(true);
            professortext3.gameObject.SetActive(true);
            check.SetActive(true);
            ok.SetActive(true);
        }
        else
        {
            back.SetActive(true);
            professortext4.gameObject.SetActive(true);
            luck.SetActive(true);
            ok.SetActive(true);
        }
        Time.timeScale = 0f;
    }

    public void professornoi()
    {
        prob = Random.Range(1, 101);
        professortext1 = professorn.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        professortext2 = professorn.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        professortext3 = professorn.transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        professortext4 = professorn.transform.GetChild(3).GetComponent<TextMeshProUGUI>();
        if (prob < 30)
        {
            moneyController.money -= 2000;
            back.SetActive(true);
            professortext1.gameObject.SetActive(true);
            moneyfly.SetActive(true);
            ok.SetActive(true);
        }
        else if (prob < 55)
        {
            moneyController.money -= 8000;
            back.SetActive(true);
            professortext2.gameObject.SetActive(true);
            moneyfly.SetActive(true);
            ok.SetActive(true);
        }
        else if (prob < 75)
        {
            moneyController.money -= 15000;
            back.SetActive(true);
            professortext3.gameObject.SetActive(true);
            moneyfly.SetActive(true);
            ok.SetActive(true);
        }
        else
        {
            back.SetActive(true);
            professortext4.gameObject.SetActive(true);
            luck.SetActive(true);
            ok.SetActive(true);
        }
        Time.timeScale = 0f;
    }
}
