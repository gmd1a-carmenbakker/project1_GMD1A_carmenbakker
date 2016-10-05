using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class programmerenXgui : MonoBehaviour {

    public Button knop;
    public Text tekst;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {

    }
	
    public void buttonClicked()
    {
        tekst.text = "geklikt";
    }
	
}

   