using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{
    private string text;
    private string[] sampleText = {"Hello", "Have a nice day", "Nice to see you", 
    "Look what's here", "Goodbye"};
    private int ranIndex;

    public GameObject inputField;
    public GameObject outputField;
    public GameObject reverseText;

    public void GetValue() {
        ranIndex = Random.Range(0, sampleText.Length);
        text = inputField.GetComponent<TMP_InputField>().text;
        outputField.GetComponent<TMP_Text>().text = text.ToUpper() + " " + sampleText[ranIndex];
        reverseText.GetComponent<Toggle>().interactable = true;
        if(reverseText.GetComponent<Toggle>().isOn) {
            ReverseText();
        }
    }

    public void ReverseText() {
        char[] charArray = outputField.GetComponent<TMP_Text>().text.ToCharArray();
        System.Array.Reverse(charArray);
        outputField.GetComponent<TMP_Text>().text =
            new string(charArray);
    }

}
