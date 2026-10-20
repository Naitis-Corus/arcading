using UnityEngine;
using UnityEngine.SceneManagement;

public class you_dedus : MonoBehaviour
{
    [SerializeField] GameObject paneilka_you_Ded;
    [SerializeField]geroi gghka;
    Camera main_camera;
    void Awake()
    {
        main_camera = Camera.main;
    }
    void Update()
    {
        if(main_camera.transform.position.y - 12 > gghka.transform.position.y)
        {
            paneilka_you_Ded.SetActive(true);
            Time.timeScale = 0f;
            gghka.gameObject.SetActive(false);
        }
    }
    public void restratish()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
