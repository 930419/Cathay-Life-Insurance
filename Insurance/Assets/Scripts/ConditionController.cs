using UnityEngine;

public class ConditionController : MonoBehaviour
{
    public int condition;
    public bool friend = true;
    public bool friendhappen = false;
    public bool friendi = false;
    public FriendController friendController;
    public bool professor = true;
    public bool professorhappen = false;
    public bool professori = false;
    public ProfessorController professorController;

    public bool exchange = true;
    public bool exchangehappen = false;
    public bool exchangei = false;
    public ExchangeController exchangeController;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // friend
        if (!friend && !friendhappen && !friendi)
        {
            friendhappen = true;
            friendController.friendnoi();
        }
        else if (!friend && !friendhappen && friendi)
        {
            friendhappen = true;
            friendController.friendyesi();
        }

        // professor
        if (!professor && !professorhappen && !professori)
        {
            professorhappen = true;
            professorController.professornoi();
        }
        else if (!professor && !professorhappen && professori)
        {
            professorhappen = true;
            professorController.professoryesi();
        }

        // exchange
        if (!exchange && !exchangehappen && !exchangei)
        {
            exchangehappen = true;
            exchangeController.exchangenoi();
        }
        else if (!exchange && !exchangehappen && exchangei)
        {
            exchangehappen = true;
            exchangeController.exchangeyesi();
        }
    }
}
