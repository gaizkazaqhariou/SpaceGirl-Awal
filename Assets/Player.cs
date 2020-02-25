using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public Text starText;
	public Image starImage;
	public Sprite iconStar;
	public Sprite iconNoStar;
	private bool carryingStar = false;
	// Use this for initialization
	void Start () {
		UpdateStarText ();
	}
	
	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("star")){
			carryingStar = true;
			UpdateStarText();
			UpdateStarImage();
			Destroy(hit.gameObject);
		}
	}
	private void UpdateStarText(){
		string starMessage = "Tidak bawa bintang";
		if(carryingStar) starMessage = "Bawa bintang";
		starText.text = starMessage;
	}
	private void UpdateStarImage(){
		if (carryingStar) {
			starImage.sprite = iconStar;
		} else {
			starImage.sprite = iconNoStar;
		}
	}
}
