using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push_UP : MonoBehaviour {
	public GameObject obj;
	public int enter_up=0;
	public push_LEFT left;
	public push_RIGHT right;
	public push_DOWN down;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	    void OnTriggerEnter(Collider other) {
			if(enter_up==0 && left.enter_left==0 && right.enter_right==0 && down.enter_down==0){
				obj.transform.Translate(0, 0, 1);
				enter_up=1;
			}				
        }
		void OnTriggerExit(Collider other){
			enter_up=0;
		}
}