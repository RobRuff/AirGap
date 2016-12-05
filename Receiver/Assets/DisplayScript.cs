using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScript : MonoBehaviour {
    private static string displayText;
    private Text gui;
    private static bool formatted;


    private static ArrayList specialCharacters = new ArrayList{"Back", "Tab", "Return", "Enter", "Space", "D0", "NumPad0", "D1", "NumPad1", "D2", "NumPad2",
        "D3", "NumPad3", "D4", "NumPad4", "D5", "NumPad5", "D6", "NumPad6", "D7", "NumPad7", "D8", "NumPad8", "D9", "NumPad9"};

    // Use this for initialization
    void Start () {
        gui = GetComponent<Text>();
        formatted = false;
    }

    // Update is called once per frame
    void Update () {
        this.gui.text = displayText;
	}

    public static void addText(string newText) {
        if (formatted && specialCharacters.Contains(newText))
        {
            setFormattedText(newText);
        }
        else
        {
            displayText += newText + " ";
        }
    }
    public void ClearText()
    {
        displayText = "";
    }
    public void toggleTextFormatted()
    {
        formatted = !formatted;
        Transform tmp = GameObject.Find("Mode").transform;
        tmp.FindChild("Text").GetComponent<Text>().text = (tmp.FindChild("Text").GetComponent<Text>().text == "Formatted") ? "NonFormat." : "Formatted";
    }

    static void setFormattedText(string str)
    {
        switch (str)
        {
            case "Back":
                displayText = displayText.Substring(0, displayText.Length - 2);
                break;
            case "Tab":
                displayText += "    ";
                break;
            case "Return":
            case "Enter":
                displayText += "\n";
                break;
            case "Space":
                displayText += "  ";
                break;
            case "D0":
            case "NumPad0":
                displayText += "0 ";
                break;
            case "D1":
            case "NumPad1":
                displayText += "1 ";
                break;
            case "D2":
            case "NumPad2":
                displayText += "2 ";
                break;
            case "D3":
            case "NumPad3":
                displayText += "3 ";
                break;
            case "D4":
            case "NumPad4":
                displayText += "4 ";
                break;
            case "D5":
            case "NumPad5":
                displayText += "5 ";
                break;
            case "D6":
            case "NumPad6":
                displayText += "6 ";
                break;
            case "D7":
            case "NumPad7":
                displayText += "7 ";
                break;
            case "D8":
            case "NumPad8":
                displayText += "8 ";
                break;
            case "D9":
            case "NumPad9":
                displayText += "9 ";
                break;
            default:
                break;
    }
}

}
