using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LvManager : MonoBehaviour {
	public void LvLoader (string name){
		Debug.Log("==== "+"Loaded for "+name+" ====");
		SceneManager.LoadScene(name);
	}

	public void LvLoader_quit (string name){
		Debug.Log("==== "+"Quited for "+name+" ====");
		SceneManager.LoadScene(name);
	}

	public void QuitRequest (){
		Application.Quit();
	}

	}

