using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScript : MonoBehaviour {
    private static string displayText;
    private Text gui;
	// Use this for initialization
	void Start () {
        gui = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        this.gui.text = displayText;
	}

    public static void addText(string newText) {
        displayText += newText + " ";
    }
    public void ClearText()
    {
        displayText = "";
    }

}
