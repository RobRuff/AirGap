using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class DummyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AudioSettings.outputSampleRate = 48000;
        SceneManager.LoadScene("a", LoadSceneMode.Single);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
