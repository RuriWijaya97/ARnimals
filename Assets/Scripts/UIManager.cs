using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameObject  panelTutorial, panelInfo, panelExit, mainMenu;
    private AudioSource audioSource;
	public AudioClip ClickSound;
    public Image blackFade;
	public AudioClip KarnivoraSound, HerbivoraSound, OmnivoraSound;

    public GameObject Gear;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
    //    if (Input.GetKeyDown (KeyCode.Escape)) {
    //         if (levelSelectMenu.activeSelf == false) {
    //             panelExit.SetActive(true);
    //             audioSource.PlayOneShot(ClickSound);
    //         } else if (levelSelectMenu.activeSelf == true) {
    //             levelSelectMenu.SetActive(false);
    //             mainMenu.SetActive(true);
    //             blackFade.canvasRenderer.SetAlpha(1.0f);
    //             fadeOut();
    //             audioSource.PlayOneShot(ClickSound);
    //         }
    //     } 
    }
    public void gotoAR() {
        Application.LoadLevel(2);
    }
    public void closeAR() {
        Application.LoadLevel(1);
    }
    public void exitPanel() {
        panelExit.SetActive(true);
        audioSource.PlayOneShot(ClickSound);
    }
    public void gotoExit() {
        Debug.Log("Exit This Game");
        Application.Quit();
        audioSource.PlayOneShot(ClickSound);
    }
    public void gotoCancel() {
        audioSource.PlayOneShot(ClickSound);
        panelExit.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void gotoInfo() {
        panelInfo.SetActive(true);
    }
    public void closeInfo() {
        panelInfo.SetActive(false);
    }
    public void gotoTutorial() {
        panelTutorial.SetActive(true);
    }
    public void closeTutorial() {
        panelTutorial.SetActive(false);
    }
    private IEnumerator DelaylevelSelect() {
        // levelSelectMenu.SetActive(true);
        yield return new WaitForSeconds(0.28f);
        mainMenu.SetActive(false); 
    }
    public void backMenu() {
        // SceneManager.LoadScene("MainMenuScene");
        // levelSelectMenu.SetActive(false);
        mainMenu.SetActive(true);
        audioSource.PlayOneShot(ClickSound);
    }
    
    public void buttonClick() {
        
        audioSource.PlayOneShot(ClickSound);
    }
    public void karnivoraSound() {
        audioSource.PlayOneShot(KarnivoraSound);
    }
    public void karnivoraStop() {
        audioSource.Stop();
    }
    public void herbivoraSound() {
        audioSource.PlayOneShot(HerbivoraSound);
    }
    public void herbivoraStop() {
        audioSource.Stop();
    }
    public void omnivoraSound() {
        audioSource.PlayOneShot(OmnivoraSound);
    }
    public void omnivoraStop() {
        audioSource.Stop();
    }
    void fadeOut() {
        blackFade.CrossFadeAlpha(0, 2, false);
    }
}
