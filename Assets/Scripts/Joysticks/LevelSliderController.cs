using UnityEngine;
using UnityEngine.UI;

public class LevelSliderController : MonoBehaviour
{
  [SerializeField] private Image slider;
  [SerializeField] private Text levelText;
  private static LevelSliderController _instance;
  public static LevelSliderController Instance => _instance;
  private void Awake()
  {
    if (_instance == null)
    {
      _instance = this;
      return;
    }

    Destroy(gameObject);
  }


  public void UpdateLevelSlider(float level)
  {
    slider.fillAmount = level;
  }
  public void UpdateLevelText(float level)
  {
    levelText.text = level.ToString();
  }
  
}
