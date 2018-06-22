using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push_LEFT : MonoBehaviour {
	public GameObject obj;
	public int enter_left=0;
	public push_DOWN down;
	public push_RIGHT right;
	public push_UP up;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	    void OnTriggerEnter(Collider other) {
			if(enter_left==0 && down.enter_down==0 && right.enter_right==0 && up.enter_up==0){
				obj.transform.Translate(-1, 0, 0);
				enter_left=1;
			}			
        }
		void OnTriggerExit(Collider other){
			enter_left=0;
		}
}
