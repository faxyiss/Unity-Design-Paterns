using UnityEngine;

public class Lamp : MonoBehaviour
{

    [SerializeField] private AudioSource AS;
    Light lights;
    private void Start()
    {
        lights = gameObject.GetComponent<Light>(); 
    }
    private void OnEnable()
    {
        Observer.UIManager.OpenLight += OpenLight;
        Observer.UIManager.CloseLight += CloseLight;
        Observer.UIManager.PlaySound += PlaySound;
    }
    private void OnDisable()
    {
        Observer.UIManager.OpenLight -= OpenLight;
        Observer.UIManager.CloseLight -= CloseLight;
        Observer.UIManager.PlaySound -= PlaySound;
    }

    public void OpenLight()
    {
        lights.enabled = true;
    }

    public void CloseLight()
    {
        lights.enabled = false;
    }

    public void PlaySound()
    {
        AS.Play();
    }

}
