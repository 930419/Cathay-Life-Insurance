using UnityEngine;
using TMPro;
using System.Collections;

public class MoneyController : MonoBehaviour
{
    public ConditionController conditioncontroller;
    public TextMeshProUGUI moneytext;
    [SerializeField] GameObject back;
    public TextMeshProUGUI friendtext;
    public TextMeshProUGUI professortext;
    public TextMeshProUGUI exchangetext;
    [SerializeField] GameObject yes;
    [SerializeField] GameObject no;
    [SerializeField] GameObject ok;
    [SerializeField] GameObject friend;
    [SerializeField] GameObject professor;
    [SerializeField] GameObject exchange;
    [SerializeField] FriendController friendController;
    [SerializeField] ProfessorController professorController;
    [SerializeField] ExchangeController exchangeController;
    [SerializeField] GameObject moneyfly;
    [SerializeField] GameObject luck;
    [SerializeField] GameObject check;
    public int money = 30000;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickyes()
    {
        if (conditioncontroller.condition == 1)
        {
            back.SetActive(false);
            friendtext.gameObject.SetActive(false);
            yes.SetActive(false);
            no.SetActive(false);
            friend.SetActive(false);
            StartCoroutine(HandleClickYes1());
        }

        else if (conditioncontroller.condition == 2)
        {
            back.SetActive(false);
            professortext.gameObject.SetActive(false);
            yes.SetActive(false);
            no.SetActive(false);
            professor.SetActive(false);
            StartCoroutine(HandleClickYes2());
        }

        else if (conditioncontroller.condition == 3)
        {
            back.SetActive(false);
            exchangetext.gameObject.SetActive(false);
            yes.SetActive(false);
            no.SetActive(false);
            exchange.SetActive(false);
            StartCoroutine(HandleClickYes3());
        }
    }

    public void clickno()
    {
        if (conditioncontroller.condition == 1)
        {
            moneytext.text = money.ToString();
            back.SetActive(false);
            friendtext.gameObject.SetActive(false);
            yes.SetActive(false);
            no.SetActive(false);
            friend.SetActive(false);
            Time.timeScale = 1f;
            conditioncontroller.friend = false;
        }
        else if (conditioncontroller.condition == 2)
        {
            moneytext.text = money.ToString();
            back.SetActive(false);
            professortext.gameObject.SetActive(false);
            yes.SetActive(false);
            no.SetActive(false);
            professor.SetActive(false);
            Time.timeScale = 1f;
            conditioncontroller.professor = false;
        }
        else if (conditioncontroller.condition == 3)
        {
            moneytext.text = money.ToString();
            back.SetActive(false);
            exchangetext.gameObject.SetActive(false);
            yes.SetActive(false);
            no.SetActive(false);
            exchange.SetActive(false);
            Time.timeScale = 1f;
            conditioncontroller.exchange = false;
        }
    }

    public void clickok()
    {
        if (conditioncontroller.condition == 1)
        {
            friendController.friendtext1.gameObject.SetActive(false);
            friendController.friendtext2.gameObject.SetActive(false);
            friendController.friendtext3.gameObject.SetActive(false);
            friendController.friendtext4.gameObject.SetActive(false);
        }
        else if (conditioncontroller.condition == 2)
        {
            professorController.professortext1.gameObject.SetActive(false);
            professorController.professortext2.gameObject.SetActive(false);
            professorController.professortext3.gameObject.SetActive(false);
            professorController.professortext4.gameObject.SetActive(false);
        }
        else if (conditioncontroller.condition == 3)
        {
            exchangeController.exchangetext1.gameObject.SetActive(false);
            exchangeController.exchangetext2.gameObject.SetActive(false);
            exchangeController.exchangetext3.gameObject.SetActive(false);
            exchangeController.exchangetext4.gameObject.SetActive(false);
        }
        StartCoroutine(HandleClickOk());
    }

    IEnumerator HandleClickOk()
    {
        back.SetActive(false);
        moneyfly.SetActive(false);
        luck.SetActive(false);
        check.SetActive(false);
        ok.SetActive(false);
        if (moneytext.text != money.ToString())
        {
            moneytext.color = Color.red;
            yield return new WaitForSecondsRealtime(0.5f);
            moneytext.text = money.ToString();
            yield return new WaitForSecondsRealtime(0.5f);
            moneytext.color = Color.black;
        }
        Time.timeScale = 1f;
    }


    IEnumerator HandleClickYes1()
    {
        moneytext.color = Color.red;
        yield return new WaitForSecondsRealtime(0.4f);
        money -= 2500;
        moneytext.text = money.ToString();
        yield return new WaitForSecondsRealtime(0.5f);
        moneytext.color = Color.black;
        yield return new WaitForSecondsRealtime(0.7f);
        conditioncontroller.friend = false;
        conditioncontroller.friendi = true;
        Time.timeScale = 1f;
    }

    IEnumerator HandleClickYes2()
    {
        moneytext.color = Color.red;
        yield return new WaitForSecondsRealtime(0.4f);
        money -= 5000;
        moneytext.text = money.ToString();
        yield return new WaitForSecondsRealtime(0.5f);
        moneytext.color = Color.black;
        yield return new WaitForSecondsRealtime(0.7f);
        conditioncontroller.professor = false;
        conditioncontroller.professori = true;
        Time.timeScale = 1f;
    }
    IEnumerator HandleClickYes3()
    {
        moneytext.color = Color.red;
        yield return new WaitForSecondsRealtime(0.4f);
        money -= 2000;
        moneytext.text = money.ToString();
        yield return new WaitForSecondsRealtime(0.5f);
        moneytext.color = Color.black;
        yield return new WaitForSecondsRealtime(0.7f);
        conditioncontroller.exchange = false;
        conditioncontroller.exchangei = true;
        Time.timeScale = 1f;
    }

}
