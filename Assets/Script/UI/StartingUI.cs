using UnityEngine;

public class StartingUI : MonoBehaviour
{
[SerializeField] GameObject menuPanelUI;

    void Start()
    {
        Time.timeScale = 0f;
    
    }
   public void StartingGame()
    {
        menuPanelUI.SetActive(false);
        Time.timeScale = 1f;
    }

}
