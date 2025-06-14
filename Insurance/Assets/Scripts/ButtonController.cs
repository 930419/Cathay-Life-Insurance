using UnityEngine;
using UnityEngine.UI;
public class ButtonController : MonoBehaviour
{
    public bool hasTriggered = false;
    public bool hasOK = false;

    public Button yesButton;
    public Button noButton;
    public Button okButton;

    void Update()
    {
        if (!hasTriggered && Input.GetKeyDown(KeyCode.Y))
        {
            hasTriggered = true;
            yesButton.onClick.Invoke();
        }

        if (!hasTriggered && Input.GetKeyDown(KeyCode.N))
        {
            hasTriggered = true;
            noButton.onClick.Invoke();
        }

        if (!hasOK && Input.GetKeyDown(KeyCode.Return))
        {
            hasOK = true;
            okButton.onClick.Invoke();
        }
    } 
}
