using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playbuttonscript : MonoBehaviour {

	public void StartGame() {
		//Application.LoadLevel("PinballScene");
        SceneManager.LoadScene("PinballScene", LoadSceneMode.Single);
	}
}
