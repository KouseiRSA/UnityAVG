using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamescript : MonoBehaviour {

	public Text TextID;
	public RawImage boy;
	public RawImage harpy;
	public GameObject btn1;
	public GameObject btn2;
	public Text btntxt1;
	public Text btntxt2;
	public CanvasGroup cg;

	[SerializeField]
	private int TextNo = 0;

	private string btnClicked = "";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown (KeyCode.J)) {
			cg.alpha = 1 - cg.alpha;
		}



		if (Input.GetMouseButtonDown(0)){
			if (TextNo != 4) 
			TextNo = TextNo + 1;
		}
		if (TextNo == 0) {
			TextID.text = "line 0";
			harpy.enabled = false;
		
			btn1.SetActive (false);
			btn2.SetActive (false);
		} else if (TextNo == 1) {
			TextID.text = "line 1";
		} else if (TextNo == 2) {
			TextID.text = "line 2";
			boy.enabled = false;
			harpy.enabled = true;
		} else if (TextNo == 3) {
			TextID.text = "line 3";
		} else if (TextNo == 4) {
			TextID.text = "line 4";
			btn1.SetActive (true);
			btn2.SetActive (true);
			btntxt2.text = "choice 2";
			btntxt1.text = "choice 1";
			if (btnClicked == "Button1") {
				TextNo = 100;
				btnClicked = "";
			} else if (btnClicked == "Button2") {
				TextNo = 200;
				btnClicked = "";

			}




		} else if (TextNo == 100) {
			TextID.text = "line 100";
			btn1.SetActive (false);
			btn2.SetActive (false);
		} 
		else if (TextNo == 101) {
			TextID.text = "line 101";
		}



		else if (TextNo == 200) {
			TextID.text = "line 200";
			btn1.SetActive (false);
			btn2.SetActive (false);
		}
		else if (TextNo == 201) {
			TextID.text = "line 201";
		}
	
	}


	public void myOnclick (GameObject btn){
		print (btn.name);
		btnClicked = btn.name;
	
	}
	}

