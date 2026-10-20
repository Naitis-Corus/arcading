using UnityEngine;

public class knipka_start : MonoBehaviour
{
[SerializeField] GameObject panelika_menu;

    void Start()
    {
        Time.timeScale = 0f;
    
    }
   public void startink_Igri()
    {
        panelika_menu.SetActive(false);
        Time.timeScale = 1f;
    }

}
