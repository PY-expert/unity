using UnityEngine;

public class Test_Script : MonoBehaviour
{
    [SerializeField] private Confirmation_Window myConfirmationWindow;

    void Start()
    {
        OpenConfirmationWindow("Are you sure?");
    }

    private void OpenConfirmationWindow(string message)
{
    Debug.Log("Opening Confirmation Window");
    myConfirmationWindow.gameObject.SetActive(true);
    
    myConfirmationWindow.yesButton.onClick.RemoveAllListeners();
    myConfirmationWindow.noButton.onClick.RemoveAllListeners();

    myConfirmationWindow.yesButton.onClick.AddListener(YesClicked);
    myConfirmationWindow.noButton.onClick.AddListener(NoClicked);

    myConfirmationWindow.messageText.text = message;
}

private void YesClicked()
{
    Debug.Log("Yes Button Clicked");
    myConfirmationWindow.gameObject.SetActive(false);
}

private void NoClicked()
{
    Debug.Log("No Button Clicked");
    myConfirmationWindow.gameObject.SetActive(false);
}
}