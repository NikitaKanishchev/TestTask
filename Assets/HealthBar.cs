using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviourPunCallbacks
{
    public Slider slider;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
