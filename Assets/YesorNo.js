#pragma strict
var Word : UnityEngine.UI.Text;
var Press : GameObject;

function Start () {
	Word.text = "";
	Press.SetActive (true);
}

function yesorno () {
	var number = Random.Range(1,3);
	Press.SetActive (false);
	if (number == 1) {
		Word.text = "Yes!";
	}else if (number == 2) {
		Word.text = "No!";
	}
}