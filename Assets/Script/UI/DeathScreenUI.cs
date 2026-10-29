using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenUI : MonoBehaviour
{
    [SerializeField] GameObject deathPanelUI;
    [SerializeField]Player player;
    [SerializeField] float lowerDeathEdjes = 12f;
    Camera cameraMain;
    void Awake()
    {
        cameraMain = Camera.main;
    }
    void Update()
    {
        if(cameraMain.transform.position.y - lowerDeathEdjes > player.transform.position.y)
        {
            deathPanelUI.SetActive(true);
            Time.timeScale = 0f;
            player.gameObject.SetActive(false);
        }
    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
