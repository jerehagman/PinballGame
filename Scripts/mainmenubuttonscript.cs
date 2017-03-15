using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mainmenubuttonscript : MonoBehaviour {

	public void GoToMainMenu() {
		//Application.LoadLevel("MenuScene");
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }
}